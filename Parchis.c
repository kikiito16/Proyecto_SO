#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>

int j=0;
typedef struct {
	char nombre[20];
	int socket;
}Conectado;

typedef struct {
	Conectado conectados[100];
	int num;
}ListaConectados;

void DameGanador (char id[30], char respuesta[60])
{
	// Vamos a buscar el ganador de la partida cuyo Identificador de partida es uno dado por el usuario				
	// construimos la consulta SQL
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
	
	
	strcpy (consulta,"SELECT Ganador FROM Partida WHERE Id = '"); 
	strcat (consulta, id);
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
		sprintf(respuesta, "No existe esa partida \n");
	}
	else
	{
		printf ("El ganador de la partida es: %s\n", row[0] );
		sprintf(respuesta, "%s \n", row[0]);
	}
}

void DameContra(char contra[30], char respuesta[512])
{
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
	
	strcpy (consulta,"SELECT Psw FROM Jugador WHERE Us = '");
	strcat (consulta, contra);
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
		sprintf(respuesta, "No existe este usuario \n");
	}
	else
	{
		printf ("La contraseña es: %s\n", row[0] );
		sprintf(respuesta, "Tu clave es: %s ", row[0]);
	}
	
}

void DimeJugadores (char id[30], char respuesta[60])
{
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
		sprintf (respuesta,"Este ID de partida no existe \n");
	
	else
	{
		printf("Los jugadores de la partida son: \n");
		sprintf(respuesta, "Los jugadores de la partida son: %s\n",row [0]);
		//sprintf(respuesta, "%s \n", row[0]);
	}
	//sprintf(respuesta,"%s",res);
}

int PonUsuario (ListaConectados *lista,char nombre[20], int socket)
{	//Añade un nuevo conectado  (0 todo ok, -1 si esta llena)
	if (lista->num==100)
		return -1;
	else{
		strcpy(lista->conectados[lista->num].nombre,nombre);
		lista->conectados[lista->num].socket=socket;
		lista->num++;
		printf("Conectado %d \n", socket);
		return 0;
	}
}

void LogIn(ListaConectados *l,char us[60], char psw[60], char respuesta[512])
{
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
		sprintf (respuesta,"Este usuario no existe \n");
	
	else
	{
		if(strcmp(psw,row[0])==0){
			printf("Usuario: %s, Contraseña: %s\n", us, psw);
			sprintf(respuesta, "%s",psw);
			PonUsuario(l,us,j);		
			j++;
		}
	}
	
}



int DamePos (ListaConectados *lista,char nombre[20])
{
	//Devuelve la posicion o -1 si no esta en la lista el usuario.
	int i=0;
	int encontrado=0;
	while ((i<lista->num) && !encontrado)
	{
		if (strcmp(lista->conectados[i].nombre,nombre)==0)
			encontrado=1;
		if(!encontrado)
			i++;		
	}
	if (encontrado)
		return i;
	else 
		return -1;
}

int EliminaUsuario (ListaConectados *lista,char nombre[20])
{	//retorna 0 si se elimina correctamente o -1 si el usuario no está en la lista
	int pos= DamePos(lista,nombre);
	if (pos==-1)
		return -1;
	else{
		int i;
		for (i=pos;i<lista->num-1;i++)
		{
			lista->conectados[i]=lista->conectados[i+1];
		}
		lista->num--;
		return 0;
	}
	
}

void DameConectados (ListaConectados *lista,char conectados[300])
{    //Nos devuelve todos los conectados separados por /. Primero pone el número de conectados
	// Ejemplo: 3/Enric/Juan/Pep
	sprintf(conectados,"%d", lista->num);
	
	int i;
	for (i=0;i<lista->num;i++)
	{
		sprintf(conectados, "%s/%s", conectados, lista->conectados[i].nombre);
	}	
}
int contador;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
		
	int ret;
	
	ListaConectados miLista;
	miLista.num=0;


	char consulta [80];
	char peticion[512];
	char respuesta[512];
	
	
	
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
		
		if ((codigo !=0) && (codigo!=5))
		{
			
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		
		if (codigo ==0) 
		{//peticion de desconexion
			terminar=1;
			
		}
		
		else if (codigo ==1) 	//piden el ganador
		{
			DameGanador(nombre,respuesta);
		}
		
		else if (codigo ==2){ // Vamos a consultar la contraseña sabiendo el nombre de usuario
			DameContra(nombre,respuesta);
		}
		
		else if(codigo==3)  //pide los jugadores que han jugado X partida
		{
			DimeJugadores(nombre,respuesta);
		}
		
		else if(codigo==4)  //Inicia sesion
		{
			
			char us[60];
			char psw[60];
			p = strtok( NULL, "/");
			strcpy(us,nombre);
			strcpy(psw,p);
			printf("Socket %d \n",j);
			LogIn(&miLista,us,psw,respuesta);
			
		}
		
		else if (codigo==5)   //envia la lista de conectados
		{
			DameConectados(&miLista,respuesta);
			printf("Resultado: %s \n", respuesta);
		}
		if (codigo !=0)
		{
			
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
		}
		if ((codigo ==1)||(codigo ==2)||(codigo ==3)||(codigo ==4)||(codigo ==5))
		{
			pthread_mutex_lock( &mutex); //NO me interrumpas ahora
			contador=contador+1;
			pthread_mutex_unlock( &mutex); //ya puedes interrumpirme
		}
		
	}
	close(sock_conn);
}


int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	
	
	
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
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i=0;
	int sockets[100];
	pthread_t thread[100];
	
	// Infinito
	for (;;){

		printf ("Escuchando\n");		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		sockets[i] = sock_conn;
		pthread_create (&thread[i],NULL,AtenderCliente,&sockets[i]);

	}
}

