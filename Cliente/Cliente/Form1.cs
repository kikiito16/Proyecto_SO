using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Cliente
{
    public partial class Form1 : Form
    {
        Socket server;
        string usuario;
        string psw;
        Thread atender;

        delegate void DelegadoParaEscribir(string mensaje);

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //Necesario para que los elementos de los formularios puedan ser
            ConectadosBox.Text = "No hay nadie conectado";

            Conectados_lab.Visible = false;
            ConectadosBox.Visible = false;
            Desconectarse_Del_Servidor.Visible = false;
            label1.Visible = false;
            nombre.Visible = false;
            Contraseña_Usuario.Visible = false;
            label2.Visible = false;
            ID.Visible = false;
            Jugadores_Partidas.Visible = false;
            Ganador_Partida.Visible = false;
            Realizar_Consulta.Visible = false;
            Tablero.Visible = false;
            dado.Visible = false;
            fichas.Visible = false;
            Invitado_group.Visible = false;
            Invitacion_group.Visible = false;

        }

        
        private void Conectar_Servidor_Click(object sender, EventArgs e)
        {
            int Puerto1 = 50079;
            //int Puerto3 = 50080;
            //int Puerto2 = 50081;

            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
           // IPAddress direc = IPAddress.Parse("147.83.117.53");
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep1 = new IPEndPoint(direc, 9050);
            //IPEndPoint ipep2 = new IPEndPoint(direc, Puerto2);
            //IPEndPoint ipep3 = new IPEndPoint(direc, Puerto3);
            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep1);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

            //Vamos a poner en marcha el thread que atenderá todos los mensajes que nos envie el servidor
            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();


         
        }

        private void Desconectarse_Del_Servidor_Click(object sender, EventArgs e)
        {

            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            //Vamos a desconectar el thread
            atender.Abort();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();

        }

        private void Realizar_Consulta_Click(object sender, EventArgs e)
        {
            if (Ganador_Partida.Checked) //Revisamos el metodo para encontrar el ganador
            {
                string mensaje = "1/" + ID.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            if (Contraseña_Usuario.Checked) //Revisamos el metodo para encontrar la contraseña
            {
                string mensaje = "2/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }

            else //Revisamos el metodo para recibir los jugadores que jugaron la partida
            {
                // Para dame jugadores
                string mensaje = "3/" + ID.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }
        /*
        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn f2 = new LogIn();
            f2.enviado+=new LogIn.enviar(iniciarsesion);
            f2.Show();  
        }
        

        public void iniciarsesion(string usu, string psw)
        {
            string contra;
            usuario = usu;
            contra = psw;
            if ((usuario != string.Empty) && (contra != string.Empty))
            {
                string mensaje = "4/" + usuario + "/" + contra;

                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else
                MessageBox.Show("Rellena todos los campos");

        }
          */
        private void AtenderServidor()
        {
            while (true)
            {
                //Operaciones para recibir el mensaje, recibimos el mensaje del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] trozo = Encoding.ASCII.GetString(msg2).Split('/'); //Partimos el mensaje por la barra "/"
                //Tenemos dos strings
                int codigo = Convert.ToInt32(trozo[0]); //El numero del mensaje 1/ , 2/, 3/ hasta 5/ que es nuestro caso
                string mensaje = mensaje = trozo[1].Split('\0')[0]; ;

                switch (codigo)
                {
                    case 1:  //Respuesta a Ganador
                        MessageBox.Show("El ganador fue: " + mensaje);
                        break;
                    case 2:  //Respuesta a Dame Contraseña
                        MessageBox.Show(mensaje);
                        break;
                    case 3:  //Respuesta a Dame Jugadores
                        MessageBox.Show(mensaje);
                        break;
                    case 4:  //Respuesta a Iniciar Sesión
                        if (mensaje == "Alguno de los datos es incorrecto")
                            MessageBox.Show("Alguno de los datos es incorrecto");
                        else
                        {
                            MessageBox.Show("Has iniciado sesión como: " + mensaje);
                            
                        }
                        break;
                    case 5:  //Respuesta a la notificacion de los usuarios conectados
                         if (mensaje != "0")
                        {
                           ConectadosBox.Clear();
                            ConectadosBox.Text = mensaje;
                        }
                        else
                        {
                            Conectados_lab.Text = "No hay nadie conectado";
                        }
                        break;
                    case 6:   //Invitar a un jugador
                        invitado_lbl.Text = mensaje + " te ha invitado a una partida";
                        break;
                    case 7:  // Respuesta a la invitacion
                        int respuesta = Convert.ToInt32(mensaje);
                        if (respuesta == 0)
                            MessageBox.Show("Han rechazado tu invitación");
                        else
                        {
                            MessageBox.Show("Han aceptado tu invitación");
                        }
                        break;
                    
                }
            }
        }


        private void Iniciar_Session_Click(object sender, EventArgs e)
        {
            if ((UsuarioBox.Text != string.Empty) && (ContraBox.Text != string.Empty))
            {
                usuario = UsuarioBox.Text;
                int Puerto1 = 50079;
                //int Puerto3 = 50080;
                //int Puerto2 = 50081;

                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos
                IPAddress direc = IPAddress.Parse("192.168.56.102");
                IPEndPoint ipep1 = new IPEndPoint(direc, 9020);
                //IPEndPoint ipep2 = new IPEndPoint(direc, Puerto2);
                //IPEndPoint ipep3 = new IPEndPoint(direc, Puerto3);
                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep1);//Intentamos conectar el socket
                    this.BackColor = Color.Green;
                    MessageBox.Show("Conectado"); 

                }
                catch (SocketException ex)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    MessageBox.Show("No he podido conectar con el servidor");
                    return;
                }

                //Vamos a poner en marcha el thread que atenderá todos los mensajes que nos envie el servidor
                ThreadStart ts = delegate { AtenderServidor(); };
                atender = new Thread(ts);
                atender.Start();


                string mensaje = "4/" + UsuarioBox.Text + "/" + ContraBox.Text;

                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                Conectados_lab.Visible = true;
                ConectadosBox.Visible = true;
                Desconectarse_Del_Servidor.Visible = true;
                label1.Visible = true;
                nombre.Visible = true;
                Contraseña_Usuario.Visible = true;
                label2.Visible = true;
                ID.Visible = true;
                Jugadores_Partidas.Visible = true;
                Ganador_Partida.Visible = true;
                Realizar_Consulta.Visible = true;
                Tablero.Visible = true;
                dado.Visible = true;
                fichas.Visible = true;
                Invitado_group.Visible = true;
                Invitacion_group.Visible = true;
                Iniciar_Session.Visible = false;
                UsuarioBox.Visible = false;
                ContraBox.Visible = false;
                Registrarse.Visible = false;
                Usuario1Box.Visible = false;
                Contra1Box.Visible = false;


            }
            else
                MessageBox.Show("Rellena todos los campos");
        }

        private void Invitar_btn_Click(object sender, EventArgs e)
        {
            string mensaje = "6/" + invitar_box.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Rechazar_btn_Click(object sender, EventArgs e)
        {
             //Cuando el cliente rechaza la invitacion enviamos un 0 al servidor
            string mensaje = "7/" + usuario + "/0";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Invitacion_groupBox.Visible = false;
        }

        private void Aceptar_btn_Click(object sender, EventArgs e)
        {
            string mensaje = "7/" + nombre + "/1";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }



       




    }
}
