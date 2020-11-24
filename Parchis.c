#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>
//#include <my_global.h>
int i=0;
//----------------------------------------------------------------------------//
//Vamos a definir la estructuras para los conectados y la lista de conectados
typedef struct {
	char nombre[20];
	int socket;
}Conectado;

typedef struct {
	Conectado conectados[100];
	int num;
}ListaConectados;

ListaConectados miLista;

//Creamos una lista de sockets
int sockets[100];
int i;
//----------------------------------------------------------------------------//

//Vamos a definir el m�todo DameGanador para la implementaci�n: 1
//Buscar el ganador de la partida cuyo Identificador de partida es uno dado por el usuario	

void DameGanador (char id[30], char respuesta[60])
{
	
	//Construimos la consulta SQL
	MYSQL *conn;    //Preparamos las variables para usar la base de datos
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
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "T10_BD",0, NULL, 0);
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
		sprintf(respuesta, "1/No existe esa partida \n");
	}
	else
	{
		printf ("El ganador de la partida es: %s\n", row[0] );
		sprintf(respuesta, "1/%s \n", row[0]);
	}
}
//----------------------------------------------------------------------------//

//Vamos a definir el m�todo DameContra para la implementaci�n: 2
//Buscar la contrase�a del usuario cuya contrase�a recibimos por parametro
void DameContra(char contra[30], char respuesta[512])
{
	//Construimos la consulta SQL
	MYSQL *conn;    //Preparamos las variables para usar la base de datos
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
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "T10_BD",0, NULL, 0);
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
		sprintf(respuesta, "2/No existe este usuario \n");
	}
	else
	{
		printf ("La contrase�a es: %s\n", row[0] );
		sprintf(respuesta, "2/Tu clave es: %s ", row[0]);
	}
	printf("%s \n", respuesta);
	
}
//----------------------------------------------------------------------------//

//Vamos a definir el m�todo DimeJugadores para la implementaci�n: 3
//Buscar los jugadores que est�n jugando una partida cuyo identificador lo pasamos parametro
void DimeJugadores (char id[30], char respuesta[60])
{
	//Construimos la consulta SQL
	MYSQL *conn;    //Preparamos las variables para usar la base de datos
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
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "T10_BD",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	strcpy(consulta,"SELECT jugadores FROM Historial WHERE Id_part = '");
	strcat(consulta, id);
	strcat(consulta, "'");
	
	//Hacemos la consulta
	err=mysql_query (conn, consulta);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	//Recogemos el resultado de la consulta
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	if (row == NULL)
		sprintf (respuesta,"3/Este ID de partida no existe \n");
	
	else
	{
		printf("Los jugadores de la partida son: \n");
		sprintf(respuesta, "3/Los jugadores de la partida son: %s\n",row [0]);
		//sprintf(respuesta, "%s \n", row[0]);
	}
	//sprintf(respuesta,"%s",res);
}
//----------------------------------------------------------------------------//

//Vamos a definir el m�todo PonUsuario para la implementaci�n: 4
//A�adiremos usuarios a nuestra ListaConectados recibido por parametro
int PonUsuario (ListaConectados *lista,char nombre[20], int socket)
{	//A�ade un nuevo conectado  (0 todo ok, -1 si esta llena)
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

//A partir del metodo PonUsuario creamos el metodo LogIn en el que pediremos 
//al cliente que se registre y lo a�adiremos a nuestra ListaConectados
void LogIn(ListaConectados *l,char us[60], char psw[60], char respuesta[512])
{
	//Construimos la consulta SQL
	MYSQL *conn;    //Preparamos las variables para usar la base de datos
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
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "T10_BD",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	strcpy(consulta,"SELECT Psw FROM Jugador WHERE Us = '");
	strcat(consulta, us);
	strcat(consulta, "'");
	
	//Hacemos la consulta
	err=mysql_query (conn, consulta);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	//Recogemos el resultado de la consulta
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	if (row == NULL)
		sprintf (respuesta,"4/Este usuario no existe \n");
	
	else
	{
		if(strcmp(psw,row[0])==0){
			printf("Usuario: %s, Contrase�a: %s\n", us, psw);
			sprintf(respuesta, "4/%s",us);
			PonUsuario(l,us,i);		
			i++;
		}
	}
	printf ("%s\n",respuesta);
}
//----------------------------------------------------------------------------//

//Vamos a definir los siguientes m�todos para la implementaci�n: 5

//Devuelve la posicion 0 si est� en la lista el usuario o -1 si no esta en la lista el usuario.
int DamePos (ListaConectados *lista,char nombre[20])
{
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


//retorna 0 si se elimina correctamente o -1 si el usuario no est� en la lista
int EliminaUsuario (ListaConectados *lista,char nombre[20])
{	
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


//Nos devuelve todos los conectados separados por /. Primero pone el n�mero de conectados
// Ejemplo: 3/Enric/Juan/Pep
void DameConectados (ListaConectados *lista,char conectados[300])
{    
	//sprintf(conectados,"%d/", lista->num);
	
	for (int i=0;  i<lista->num; i++)
	{
		sprintf(conectados, "%s %s", conectados, lista->conectados[i].nombre);
	}
	
	if (lista->num==0)
		sprintf(conectados,"%d", lista->num);
}
//----------------------------------------------------------------------------//

/*Crearemos el siguiente metodo en el que hemos declarado la soluci�n al error 
de conexi�n de m�ltles clientes y atenderlos adecuadamente que lo llamaremos AtenderCliente
y sirve para llamar a las diversas funciones*/

int contador;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

//M�todo para saber que hacer en cada caso
void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	int ret;
	
	
	char consulta [80];
	char peticion[512];
	char respuesta[512];
	char notificacion[512];
	
	
	
	int terminar =0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar ==0)
	{
		// Ahora recibimos la peticion
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que añadirle la marca de fin de string
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
		
		if (codigo ==0) //Peticion para la desconexion
		{
			terminar=1;
			EliminaUsuario(&miLista,nombre);				
		}
		
		else if (codigo ==1) //Peticion de la implementacion: 1 (DameGanador)
		{
			DameGanador(nombre,respuesta);
		}
		
		else if (codigo ==2){ //Peticion de la implementacion: 2 (DameContra)
			DameContra(nombre,respuesta);
		}
		
		else if(codigo==3) //Peticion de la implementacion: 3 (DimeJugadores)
		{
			DimeJugadores(nombre,respuesta);
		}
		
		else if(codigo==4) //Peticion de la implementacion: 4 (LogIn)
		{
			
			char us[60];
			char psw[60];
			strcpy(us,nombre);
			p = strtok( NULL, "/");
			strcpy(psw,p);
			printf("Socket: %d \n",i);
			LogIn(&miLista,us,psw,respuesta);
			
			if (strcmp(respuesta,us)==0){
				char conectados [512];
				DameConectados(&miLista, conectados);
				sprintf(notificacion,"5/%s ",conectados);			
				for(int j =0; j<i;j++)
				{
					write(sockets[j],notificacion,strlen(notificacion));
					printf("%s\n",notificacion);
				}
				strcpy(notificacion,"");
			}
			
		}
		
		if (codigo !=0)
		{
			
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
		}
		if ((codigo ==1)||(codigo ==2)||(codigo ==3)||(codigo ==4)) //Mientras se est�n procesando todas las acciones
		{
			/*
			//algunos clientes pueden
			pthread_mutex_lock( &mutex); //NO me interrumpas ahora
			contador=contador+1;
			pthread_mutex_unlock( &mutex); //ya puedes interrumpirme
			
			//Notificar a todos los clientes conectados
			char notificacion [20];
			sprintf(notificacion, "5/%s", conectados);
			int j;
			for(j=0; j<i; j++)
				write (sockets[j], notificacion, strlen(notificacion)); 
			//no estar conectados, se arreglar� m�s adelante*/
			pthread_mutex_lock( &mutex);
		char conectados[512];
		DameConectados (&miLista, conectados);
		
		sprintf(notificacion,"5/%s",conectados);
		
		printf("%s\n",notificacion);
		
		//notificar a todos los clientes conectados
		for(int j =0; j<i;j++)
		{
			write(sockets[j],notificacion,strlen(notificacion));
		}
		strcpy(notificacion,"");
		pthread_mutex_unlock( &mutex); //ya puedes interrumpirme
		}
		
	}
	close(sock_conn);
}

//----------------------------------------------------------------------------//

int main(int argc, char *argv[])
{
	miLista.num=0;
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	//int puerto = 50079;
	int puerto = 9060;
	
	
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
	serv_adr.sin_port = htons(puerto);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	
	
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
