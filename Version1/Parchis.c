#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>

int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr)); // inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina.
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9020);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	
	// Infinito
	for (;;){
		MYSQL *conn;    //preparamos las variables para usar la base de datos
		int err;
		MYSQL_RES *resultado;
		MYSQL_ROW row;
		char consulta [80];
		
		//Creamos una conexion al servidor MYSQL
		conn = mysql_init(NULL);
		if (conn==NULL) {
			printf ("Error al crear la conexion: %u %s\n",
					mysql_errno(conn), mysql_error(conn));
			exit (1);
		}
		
		//inicializamos la conexion
		conn = mysql_real_connect (conn, "localhost","root", "mysql", "BD",0, NULL, 0);
		if (conn==NULL) {
			printf ("Error al inicializar la conexion: %u %s\n",
					mysql_errno(conn), mysql_error(conn));
			exit (1);
		}
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		int terminar =0;
		// Entramos en un bucle para atender todas las peticiones de este cliente
		//hasta que se desconecte
		while (terminar ==0)
		{
			// Ahora recibimos la peticion
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			// Tenemos que aÃ±adirle la marca de fin de string
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			
			
			printf ("Peticion: %s\n",peticion);
			
			// vamos a ver que quieren
			char *p = strtok( peticion, "/");
			int codigo =  atoi (p);
			// Ya tenemos el codigo de la peticion
			char nombre[20];
			
			if (codigo !=0)
			{
				
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				// Ya tenemos el nombre
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			}
			
			if (codigo ==0) 
			{//peticion de desconexion
				terminar=1;
				mysql_close (conn);
			}
			else if (codigo ==1) 	//piden el ganador
			{
				// Vamos a buscar el ganador de la partida cuyo Identificador de partida es uno dado por el usuario				
				// construimos la consulta SQL
				strcpy (consulta,"SELECT Ganador FROM Partida WHERE Id = '"); 
				strcat (consulta, nombre);
				strcat (consulta,"'");
				// hacemos la consulta 
				err=mysql_query (conn, consulta); 
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				
				//recogemos el resultado de la consulta 
				resultado = mysql_store_result (conn); 
				row = mysql_fetch_row (resultado);
				if (row == NULL)
				{
					printf ("No se han obtenido datos en la consulta\n");
					sprintf(respuesta, "No existe esa partida \0");
				}
				else
				{
					printf ("El ganador de la partida es: %s\n", row[0] );
					sprintf(respuesta, "%s \0", row[0]);
				}
			}
			// cerramos la conexión
			else if (codigo ==2){ // Vamos a consultar la contraseña sabiendo el nombre de usuario
				
				// construimos la consulta SQL
				strcpy (consulta,"SELECT Psw FROM Jugador WHERE Us = '");
				strcat (consulta, nombre);
				strcat (consulta,"'");
				// hacemos la consulta
				err=mysql_query (conn, consulta);
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				
				//recogemos el resultado de la consulta
				resultado = mysql_store_result (conn);
				row = mysql_fetch_row (resultado);
				if (row == NULL)
				{
					printf ("No se han obtenido datos en la consulta\n");
					sprintf(respuesta, "No existe este usuario \0");
				}
				else
					{
					printf ("La contraseña es: %s\n", row[0] );
					sprintf(respuesta, "Tu clave es: %s \0", row[0]);
					}

			}
			
			else if(codigo==3)
			{
				char id [120];
				strcpy(id,nombre);
				strcpy(consulta,"SELECT jugadores FROM Historial WHERE Id_part = '");
				strcat(consulta, id);
				strcat(consulta, "'");
				err=mysql_query (conn, consulta);
				
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				
				resultado = mysql_store_result (conn);
				
				row = mysql_fetch_row (resultado);
				
				if (row == NULL)
					sprintf (respuesta,"Este ID de partida no existe \0");
				
				else
				{
						printf("Los jugadores de la partida son: \n");
						sprintf(respuesta, "Los jugadores de la partida son: %s\0",row [0]);
					//sprintf(respuesta, "%s \n", row[0]);
				}
				//sprintf(respuesta,"%s",res);
			}
			
			else if(codigo==4)
			{
				char us[60];
				char psw[60];
				p = strtok( NULL, "/");
				strcpy(us,nombre);
				strcpy(psw,p);
				strcpy(consulta,"SELECT Psw FROM Jugador WHERE Us = '");
				strcat(consulta, us);
				strcat(consulta, "'");
				err=mysql_query (conn, consulta);
				
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				
				resultado = mysql_store_result (conn);
				
				row = mysql_fetch_row (resultado);
				
				if (row == NULL)
					sprintf (respuesta,"Este usuario no existe\n");
				
				else
				{
					if(strcmp(psw,row[0])==0){
						printf("Usuario: %s, Contraseña: %s\n", us, psw);
						sprintf(respuesta, "%s\0",psw);}
					//sprintf(respuesta, "%s \n", row[0]);
				}
				//sprintf(respuesta,"%s",res);
			}
			if (codigo !=0)
			{
				
				printf ("Respuesta: %s\n", respuesta);
				// Enviamos respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
		}
		
		// Se acabo el servicio para este cliente
		close(sock_conn);
		
	}
}
