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
        string usuario, invitado;
        string psw;
        Thread atender;
        int conectado = 0;
        int num_conectados = 0;
        string[] conectados;
        List<string> lista_conectados = new List<string>();

        delegate void DelegadoParaEscribir(string mensaje);
        delegate void DelegadoParaActualizar(string mensaje);



        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //Necesario para que los elementos de los formularios puedan ser
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
            Conectados_box.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            label11.Visible = false;
        }

        private void Actualiza_Grid(string mensaje)
        // actualiza la lista de conectados cada vez que se conecte un usuario
        {
            Conectados_data.ColumnCount = 1;
            Conectados_data.RowCount = num_conectados;

            conectados = mensaje.Split(',');

            for (int i = 0; i < num_conectados; i++)
                Conectados_data.Rows[i].Cells[0].Value = conectados[i];
        }

        private void Invitacion_lbl(string mensaje)
        {
            invitado_lbl.Text = mensaje + " te ha invitado a una partida";
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
            IPEndPoint ipep1 = new IPEndPoint(direc, 9019);
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
            conectado = 0;
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
            Conectados_box.Visible = false;
            Iniciar_Session.Visible = true;
            UsuarioBox.Visible = true;
            ContraBox.Visible = true;
            Registrarse.Visible = true;
            Usuario1Box.Visible = true;
            Contra1Box.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = false;
            label11.Visible = false;
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

        private void AtenderServidor()
        {
            try
            {
                while (true)
                {
                    //Operaciones para recibir el mensaje, recibimos el mensaje del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    string recibido = Encoding.ASCII.GetString(msg2).TrimEnd('\0');
                    string[] trozo = recibido.Split('/'); //Partimos el mensaje por la barra "/"
                    //Tenemos dos strings
                    string mensaje;
                    int codigo = Convert.ToInt32(trozo[0]); //El numero del mensaje 1/ , 2/, 3/ hasta 7/ que es nuestro caso
                    if (codigo == 5)
                        //Recibiremos un mensaje del estilo: 5/num_conectados/conectados
                    {
                        num_conectados = Convert.ToInt32(trozo[1]);
                        mensaje = trozo[2].Split('\0')[0];
                    }
                    else
                        mensaje = trozo[1].Split('\0')[0];

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
                            Conectados_data.Invoke(new DelegadoParaActualizar(Actualiza_Grid), new object[] { mensaje });
                            break;
                        case 6:   //Invitar a un jugador
                            mensaje = trozo[1].Split('\0')[0];
                            //invitado_lbl.Invoke(new DelegadoParaEscribir(Actualiza_Grid), new object[] { mensaje });
                            DialogResult result;
                            result = MessageBox.Show(mensaje, " Te ha invitado a una partida el jugador:", MessageBoxButtons.YesNo);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                string men = "7/" + mensaje + "/SI";
                                byte[] msg = System.Text.Encoding.ASCII.GetBytes(men);
                                server.Send(msg);
                            }
                            else
                            {
                                string men = "7/"+mensaje+"/NO"+mensaje;
                                byte[] msg = System.Text.Encoding.ASCII.GetBytes(men);
                                server.Send(msg);
                            }
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
            catch
            {
                return;
            }
        }


        private void Iniciar_Session_Click(object sender, EventArgs e)
        {
            if ((UsuarioBox.Text != string.Empty) && (ContraBox.Text != string.Empty) && (conectado==0))
            {
                usuario = UsuarioBox.Text;
                int Puerto1 = 50079;
                //int Puerto3 = 50080;
                //int Puerto2 = 50081;

                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos
                IPAddress direc = IPAddress.Parse("192.168.56.102");
                IPEndPoint ipep1 = new IPEndPoint(direc, 9019);
                //IPEndPoint ipep2 = new IPEndPoint(direc, Puerto2);
                //IPEndPoint ipep3 = new IPEndPoint(direc, Puerto3);
                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep1);//Intentamos conectar el socket
                    this.BackColor = Color.Green;
                    conectado = 1;
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
                Conectados_box.Visible = true;
                Iniciar_Session.Visible = false;
                UsuarioBox.Visible = false;
                ContraBox.Visible = false;
                Registrarse.Visible = false;
                Usuario1Box.Visible = false;
                Contra1Box.Visible = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = true;
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
             //Cuando el cliente rechaza la invitacion enviamos un NO al servidor
            string mensaje = "7/" + usuario + "/NO";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Invitacion_groupBox.Visible = false;
        }

        private void Aceptar_btn_Click(object sender, EventArgs e)
        {
            string mensaje = "7/" + nombre + "/SI";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "5/" + Usuario1Box.Text + "/" + Contra1Box.Text;
                // Enviamos al servidor el nombre
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            catch
            {
               MessageBox.Show("Error al registrar");
            }
        }

        private void Conectados_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            invitado = conectados[fila];
        }




       




    }
}
