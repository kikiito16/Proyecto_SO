
#include <mysql.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
int main(int argc, char **argv)
{
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char identificador[20];
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
	
	// Vamos a buscar el ganador de la partida cuyo Identificador
	// de partida es uno dado por el usuario
	printf ("Dame el Identificador de la partida que quieres buscar\n"); 
	scanf ("%s", identificador);
	// construimos la consulta SQL
	strcpy (consulta,"SELECT Ganador FROM Partida WHERE Id = '"); 
	strcat (consulta, identificador);
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
		printf ("No se han obtenido datos en la consulta\n");
	else
		printf ("El ganador de la partida es: %s\n", row[0] );
	// cerramos la conexión
	mysql_close (conn);
	exit(0);
}
