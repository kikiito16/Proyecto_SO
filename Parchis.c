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

pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;
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

//Construimos la consulta SQL
MYSQL *conn;    //Preparamos las variables para usar la base de datos
int err;
MYSQL_RES *resultado;
MYSQL_ROW row;
char consulta [80];

//----------------------------------------------------------------------------//

//Vamos a definir el método DameGanador para la implementación: 1
//Buscar el ganador de la partida cuyo Identificador de partida es uno dado por el usuario	

void DameGanador (char id[30], char respuesta[60])
{
	printf("---------------------------------------------------\n");
	printf("Has entrado en la implementación 1 (DameGanador)\n");
	
	
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

//Vamos a definir el método DameContra para la implementación: 2
//Buscar la contraseña del usuario cuya contraseña recibimos por parametro
void DameContra(char contra[30], char respuesta[512])
{
	printf("---------------------------------------------------\n");
	printf("Has entrado en la implementación 2 (DameContra)\n");
	
	
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
		printf ("La contraseña es: %s\n", row[0] );
		sprintf(respuesta, "2/Tu clave es: %s ", row[0]);
	}
	printf("%s \n", respuesta);
	
}
//----------------------------------------------------------------------------//

//Vamos a definir el método DimeJugadores para la implementación: 3
//Buscar los jugadores que están jugando una partida cuyo identificador lo pasamos parametro
void DimeJugadores (char id[30], char respuesta[60])
{
	printf("---------------------------------------------------\n");
	printf("Has entrado en la implementación 3 (DimeJugadores)\n");
	
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
	}
}
//----------------------------------------------------------------------------//
//Vamos a definir la función de registrar que nos añadirá el usuario y contraseña
//a nuestra base de datos
/*void RegistrarUsuario(ListaConectados *lista, char UsuarioRegistrar[20], char ContraseñaRegistrar[20])
{
printf("---------------------------------------------------\n");
printf("Has entrado en la implementación 4 (RegistrarUsuarios)\n");

//Inicializamos la conexion
MYSQL *conn;
int err;
char dni[10]; 
char nombre [25]; 
int edad;
char edads [3];
int i;
char consulta [80];

//Creamos una conexion al servidor MYSQL 
conn = mysql_init(NULL);
if (conn==NULL) {
printf ("Error al crear la conexion: %u %s\n",
mysql_errno(conn), mysql_error(conn));
exit (1);
}
//inicializar la conexion, entrando nuestras claves de acceso y
//el nombre de la base de datos a la que queremos acceder 
conn = mysql_real_connect (conn, "localhost","root", "mysql", "T10_BD",0, NULL, 0);
if (conn==NULL) {
printf ("Error al inicializar la conexion: %u %s\n",
mysql_errno(conn), mysql_error(conn));
exit (1);
}
//Introduciremos en la base de datos de la persona, 
//cuyos datos pedimos al usuario
for (i=0; i<4; i++) 
{
printf ("Escribe el DNI, nombre y edad de la persona, separados por un blanco\n");
err = scanf ("%s %s %d", dni, nombre, &edad);
if (err!=3) 
{
printf ("Error al introducir los datos \n");
exit (1);
}
}



}
*/
//----------------------------------------------------------------------------//

//Vamos a definir el método PonUsuario para la implementación: 4
//Añadiremos usuarios a nuestra ListaConectados recibido por parametro
int PonUsuario (ListaConectados *lista,char nombre[20], int socket_pon)
{	//Añade un nuevo conectado  (0 todo ok, -1 si esta llena)
	printf("---------------------------------------------------\n");
	printf("Has entrado en la función (PonUsuario)\n");
	if (lista->num==100)
		return -1;
	else{
		strcpy(lista->conectados[lista->num].nombre,nombre);
		lista->conectados[lista->num].socket=socket_pon;
		lista->num++;
		printf("Hemos añadido el socket con el que has conectado: %d \n", socket_pon);
		return 0;
	}
}

//A partir del metodo PonUsuario creamos el metodo LogIn en el que pediremos 
//al cliente que se registre y lo añadiremos a nuestra ListaConectados
void LogIn(ListaConectados *l,char us[60], char psw[60], int socket_login, char respuesta[512])
{
	
	printf("---------------------------------------------------\n");
	printf("Has entrado en la implementación 4 (LogIn)\n");
	
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
		sprintf (respuesta,"4/Alguno de los datos es incorrecto \n");
	
	else
	{
		if(strcmp(psw,row[0])==0){
			printf("Acabas de iniciar sesion como --> |Usuario: %s|Contraseña: %s|\n", us, psw);
			sprintf(respuesta, "4/%s",us);
			pthread_mutex_lock( &mutex);
			PonUsuario(l,us,socket_login);	
			//printf("Guardo en la lista %d %s\n",i,us);
			i++;
			pthread_mutex_unlock( &mutex);
		}
	}
	printf ("Hemos enviado la respuesta: %s\n",respuesta);
}
//----------------------------------------------------------------------------//

//Vamos a definir los siguientes métodos para la implementación: 5

//Devuelve la posicion 0 si está en la lista el usuario o -1 si no esta en la lista el usuario.
int DamePos (ListaConectados *lista,char nombre[20])
{
	printf("---------------------------------------------------\n");
	printf("Has entrado en la función (ListaConectados)\n");
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

int DameSocket (ListaConectados *lista, char nombre [20])
{ //Devuelve el socket o -1 si no esta en la lista
	printf("---------------------------------------------------\n");
	printf("Has entrado en la función (DameSocket)\n");
	int i = 0;
	int encontrado =0;
	while ((i<lista->num)&&(encontrado == 0))
	{
		if (strcmp(lista->conectados[i].nombre, nombre) == 0)
		{
			encontrado = 1;
			return lista->conectados[i].socket;
		}
		i++;
	}
	if (!encontrado)
		return -1;
}


//retorna 0 si se elimina correctamente o -1 si el usuario no está en la lista
int EliminaUsuario (ListaConectados *lista,char nombre[20])
{	
	printf("---------------------------------------------------\n");
	printf("Has entrado en la función (EliminaUsuario)\n");
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


//Nos devuelve todos los conectados separados por /. Primero pone el número de conectados
// Ejemplo: 3/Enric/Juan/Pep
void DameConectados (ListaConectados *lista,char conectados[300])
{   
	printf("---------------------------------------------------\n");
	printf("Has entrado en la función (DameConectados)\n");
	sprintf(conectados,"%d/", lista->num);
	for (int i=0;  i<lista->num; i++)
	{
		sprintf(conectados, "%s%s\n", conectados, lista->conectados[i].nombre);
	}
	
	if (lista->num==0)
		sprintf(conectados,"%d\n", lista->num);
}
//----------------------------------------------------------------------------//

/*Crearemos el siguiente metodo en el que hemos declarado la solución al error 
de conexión de múltles clientes y atenderlos adecuadamente que lo llamaremos AtenderCliente
y sirve para llamar a las diversas funciones*/


//Método para saber que hacer en cada caso
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
		printf("---------------------------------------------------\n");
		printf("Has entrado en la función (AtenderCliente)\n");
		// Ahora recibimos la peticion
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido, el socket conectado es: %d\n",sock_conn);
		
		// Tenemos que aÃ±adirle la marca de fin de string
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		
		printf ("La peticion que vamos a procesar y buscar la funcion es: %s\n",peticion);
		
		// vamos a ver que quieren
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		// Ya tenemos el codigo de la peticion
		char nombre[20];
		char us[60];
		
		if (codigo !=0)
		{
			
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Podemos saber que el Codigo es: %d y el Nombre: %s\n", codigo, nombre);
		}
		
		if (codigo ==0) //Peticion para la desconexion
		{
			printf("---------------------------------------------------\n");
			printf("Entramos en la petición (Desconexion)\n");
			terminar=1;
			pthread_mutex_lock( &mutex);
			EliminaUsuario(&miLista,nombre);
			char conectados [512];
			DameConectados(&miLista, conectados);
			sprintf(notificacion,"5/%s ",conectados);			
			for(int j =0; j<miLista.num;j++)
			{
				write(miLista.conectados[i].socket,notificacion,strlen(notificacion));
				printf("%s\n",notificacion);
			}
			strcpy(notificacion,"");
			pthread_mutex_unlock( &mutex);
		}
		
		else if (codigo ==1) //Peticion de la implementacion: 1 (DameGanador)
		{
			printf("---------------------------------------------------\n");
			printf("Entramos en la peticion (DameGanador)\n");
			DameGanador(nombre,respuesta);
		}
		
		else if (codigo ==2) //Peticion de la implementacion: 2 (DameContra)
		{ 
			printf("---------------------------------------------------\n");
			printf("Entramos en la peticion (DameContra)\n");
			DameContra(nombre,respuesta);
		}
		
		else if(codigo==3) //Peticion de la implementacion: 3 (DimeJugadores)
		{
			printf("---------------------------------------------------\n");
			printf("Entramos en la peticion (DimeJugadores)\n");
			DimeJugadores(nombre,respuesta);
		}
		
		else if(codigo==4) //Peticion de la implementacion: 4 (LogIn)
		{
			printf("---------------------------------------------------\n");
			printf("Entramos en la peticion (LogIn)\n");
			char psw[60];
			strcpy(us,nombre);
			p = strtok( NULL, "/");
			strcpy(psw,p);
			printf("El usuario es: %s y la contraseña es %s \n" ,us, psw);
			//printf("Socket: %d \n",i);
			LogIn(&miLista,us,psw,sock_conn,respuesta);
			
			if (strcmp(respuesta,us)==0){
				char conectados [512];
				DameConectados(&miLista, conectados);
				sprintf(notificacion,"5/%s", conectados);			
				for(int j =0; j<=miLista.num;j++)
				{
					write(sockets[j],notificacion,strlen(notificacion));
					printf("La notificación es: %s\n",notificacion);
				}
				strcpy(notificacion,"");
			}
			
		}
		
		/*else if (codigo == 5) //PEticion de la implementacion 5 (Registrar)
		{
		
		}
		*/
		else if (codigo == 6)
			// cuando el cliente invita a otra persona
		{
			printf("---------------------------------------------------\n");
			printf("Entramos en la peticion (InvitarAOtraPersona)\n");
			char invitado [20];
			strcpy (invitado, nombre);
			int socket_invitado;
			socket_invitado = DameSocket(&miLista,invitado);  //obtenemos el socket del invitado
			printf ("Voy a invitar a %d, %s \n", socket_invitado, invitado);
			strcpy(respuesta,"");
			sprintf (respuesta,"6/%s",us);
			write (socket_invitado,respuesta, strlen(respuesta));  //le enviamos la solicitud solo al invitado
			strcpy(respuesta,"");
			
		}
		else if (codigo == 7)
			// cuando invitan al cliente
		{
			printf("---------------------------------------------------\n");
			printf("Entramos en la peticion (CuandoInvitamos)\n");
			char invitador [20];
			char decision [10];
			int socket_invitador;
			strcpy (invitador, nombre);
			p = strtok( NULL, "/");
			strcpy (decision, p);
			
			if (strcmp(decision, "SI")==0)
			{
				printf("invitador: %s \n",invitador);
				socket_invitador = DameSocket(&miLista,invitador);  //buscamos el socket de la persona que nos ha invitado
				sprintf (respuesta,"7/%d",1);
			}
			if (strcmp(decision, "NO")==0)
			{
				printf("invitador: %s \n",invitador);
				socket_invitador = DameSocket(&miLista,invitador);  //buscamos el socket de la persona que nos ha invitado
				sprintf (respuesta,"7/%d",0);
			}
			
			write (socket_invitador,respuesta, strlen(respuesta));  //respondemos solo a quien nos ha invitado
			printf("%s\n",respuesta);
			strcpy(respuesta,"");
		}
		
		if ((codigo !=0) && (codigo!=6) && (codigo!= 7))
		{
			
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
		}
		if ((codigo ==1)||(codigo ==2)||(codigo ==3)||(codigo ==4)) //Mientras se están procesando todas las acciones
		{
			printf("---------------------------------------------------\n");
			printf("Esto lo ejecutamos mientras todo se procesa\n");
			pthread_mutex_lock( &mutex);
			char conectados[512];
			DameConectados (&miLista, conectados);
			
			sprintf(notificacion,"5/%s",conectados);
			
			printf("La notificacion es: %s\n",notificacion);
			
			//notificar a todos los clientes conectados
			for(int j =0; j<miLista.num;j++)
			{
				write(sockets[j],notificacion,strlen(notificacion));
				printf("notificamos a todos los clientes que: %s\n",notificacion);
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
	int puerto = 9019;
	
	
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
	{
		printf ("Error al bind, cambia el puerto\n");
	}
	else if (listen(sock_listen, 3) < 0)
	{
		printf("Error en el Listen\n");
	}
	else 
	{
		i=0;
		pthread_t thread[100];
		// Infinito
		for (;;)
		{
			
			printf ("Escuchando\n");		
			sock_conn = accept(sock_listen, NULL, NULL);
			printf ("He otorgado el socket: %d a esta conexión\n",sock_conn);
			//sock_conn es el socket que usaremos para este cliente		
			
			sockets[i] = sock_conn;
			
			pthread_create (&thread[i],NULL,AtenderCliente,&sockets[i]);
			i=i+1;
			
		}
	}
}
