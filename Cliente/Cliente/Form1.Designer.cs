namespace Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Desconectarse_Del_Servidor = new System.Windows.Forms.Button();
            this.Contraseña_Usuario = new System.Windows.Forms.RadioButton();
            this.Ganador_Partida = new System.Windows.Forms.RadioButton();
            this.Jugadores_Partidas = new System.Windows.Forms.RadioButton();
            this.Realizar_Consulta = new System.Windows.Forms.Button();
            this.Iniciar_Session = new System.Windows.Forms.Button();
            this.UsuarioBox = new System.Windows.Forms.TextBox();
            this.ContraBox = new System.Windows.Forms.TextBox();
            this.Tablero = new System.Windows.Forms.PictureBox();
            this.fichas = new System.Windows.Forms.PictureBox();
            this.dado = new System.Windows.Forms.PictureBox();
            this.Contra1Box = new System.Windows.Forms.TextBox();
            this.Usuario1Box = new System.Windows.Forms.TextBox();
            this.Registrarse = new System.Windows.Forms.Button();
            this.Invitacion_group = new System.Windows.Forms.GroupBox();
            this.invitar_box = new System.Windows.Forms.TextBox();
            this.Invitar_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Invitado_group = new System.Windows.Forms.GroupBox();
            this.Rechazar_btn = new System.Windows.Forms.Button();
            this.Aceptar_btn = new System.Windows.Forms.Button();
            this.invitado_lbl = new System.Windows.Forms.Label();
            this.Conectados_box = new System.Windows.Forms.GroupBox();
            this.Conectados_data = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado)).BeginInit();
            this.Invitacion_group.SuspendLayout();
            this.Invitado_group.SuspendLayout();
            this.Conectados_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Conectados_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(16, 39);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(259, 20);
            this.nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(16, 140);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(259, 20);
            this.ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion de la Partida";
            // 
            // Desconectarse_Del_Servidor
            // 
            this.Desconectarse_Del_Servidor.Location = new System.Drawing.Point(1314, 576);
            this.Desconectarse_Del_Servidor.Name = "Desconectarse_Del_Servidor";
            this.Desconectarse_Del_Servidor.Size = new System.Drawing.Size(177, 34);
            this.Desconectarse_Del_Servidor.TabIndex = 0;
            this.Desconectarse_Del_Servidor.Text = "Desconectarse del Servidor";
            this.Desconectarse_Del_Servidor.UseVisualStyleBackColor = true;
            this.Desconectarse_Del_Servidor.Click += new System.EventHandler(this.Desconectarse_Del_Servidor_Click);
            // 
            // Contraseña_Usuario
            // 
            this.Contraseña_Usuario.AutoSize = true;
            this.Contraseña_Usuario.Location = new System.Drawing.Point(16, 65);
            this.Contraseña_Usuario.Name = "Contraseña_Usuario";
            this.Contraseña_Usuario.Size = new System.Drawing.Size(203, 17);
            this.Contraseña_Usuario.TabIndex = 3;
            this.Contraseña_Usuario.TabStop = true;
            this.Contraseña_Usuario.Text = "He olvidado la contraseña de Usuario";
            this.Contraseña_Usuario.UseVisualStyleBackColor = true;
            // 
            // Ganador_Partida
            // 
            this.Ganador_Partida.AutoSize = true;
            this.Ganador_Partida.Location = new System.Drawing.Point(16, 189);
            this.Ganador_Partida.Name = "Ganador_Partida";
            this.Ganador_Partida.Size = new System.Drawing.Size(218, 17);
            this.Ganador_Partida.TabIndex = 3;
            this.Ganador_Partida.TabStop = true;
            this.Ganador_Partida.Text = "Quiero consultar el Ganador de la partida";
            this.Ganador_Partida.UseVisualStyleBackColor = true;
            // 
            // Jugadores_Partidas
            // 
            this.Jugadores_Partidas.AutoSize = true;
            this.Jugadores_Partidas.Location = new System.Drawing.Point(16, 166);
            this.Jugadores_Partidas.Name = "Jugadores_Partidas";
            this.Jugadores_Partidas.Size = new System.Drawing.Size(181, 17);
            this.Jugadores_Partidas.TabIndex = 3;
            this.Jugadores_Partidas.TabStop = true;
            this.Jugadores_Partidas.Text = "Que jugadores jugaron la partida ";
            this.Jugadores_Partidas.UseVisualStyleBackColor = true;
            // 
            // Realizar_Consulta
            // 
            this.Realizar_Consulta.Location = new System.Drawing.Point(42, 232);
            this.Realizar_Consulta.Name = "Realizar_Consulta";
            this.Realizar_Consulta.Size = new System.Drawing.Size(177, 34);
            this.Realizar_Consulta.TabIndex = 0;
            this.Realizar_Consulta.Text = "Realizar la Consulta";
            this.Realizar_Consulta.UseVisualStyleBackColor = true;
            this.Realizar_Consulta.Click += new System.EventHandler(this.Realizar_Consulta_Click);
            // 
            // Iniciar_Session
            // 
            this.Iniciar_Session.Location = new System.Drawing.Point(32, 250);
            this.Iniciar_Session.Name = "Iniciar_Session";
            this.Iniciar_Session.Size = new System.Drawing.Size(171, 66);
            this.Iniciar_Session.TabIndex = 7;
            this.Iniciar_Session.Text = "Iniciar Sesion";
            this.Iniciar_Session.UseVisualStyleBackColor = true;
            this.Iniciar_Session.Click += new System.EventHandler(this.Iniciar_Session_Click);
            // 
            // UsuarioBox
            // 
            this.UsuarioBox.Location = new System.Drawing.Point(38, 128);
            this.UsuarioBox.Name = "UsuarioBox";
            this.UsuarioBox.Size = new System.Drawing.Size(160, 20);
            this.UsuarioBox.TabIndex = 8;
            // 
            // ContraBox
            // 
            this.ContraBox.Location = new System.Drawing.Point(38, 190);
            this.ContraBox.Name = "ContraBox";
            this.ContraBox.Size = new System.Drawing.Size(160, 20);
            this.ContraBox.TabIndex = 9;
            // 
            // Tablero
            // 
            this.Tablero.Image = ((System.Drawing.Image)(resources.GetObject("Tablero.Image")));
            this.Tablero.Location = new System.Drawing.Point(1144, 74);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(281, 281);
            this.Tablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tablero.TabIndex = 12;
            this.Tablero.TabStop = false;
            // 
            // fichas
            // 
            this.fichas.Image = ((System.Drawing.Image)(resources.GetObject("fichas.Image")));
            this.fichas.Location = new System.Drawing.Point(1366, 368);
            this.fichas.Name = "fichas";
            this.fichas.Size = new System.Drawing.Size(59, 50);
            this.fichas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fichas.TabIndex = 13;
            this.fichas.TabStop = false;
            // 
            // dado
            // 
            this.dado.Image = ((System.Drawing.Image)(resources.GetObject("dado.Image")));
            this.dado.Location = new System.Drawing.Point(1144, 368);
            this.dado.Name = "dado";
            this.dado.Size = new System.Drawing.Size(59, 50);
            this.dado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dado.TabIndex = 14;
            this.dado.TabStop = false;
            // 
            // Contra1Box
            // 
            this.Contra1Box.Location = new System.Drawing.Point(444, 190);
            this.Contra1Box.Name = "Contra1Box";
            this.Contra1Box.Size = new System.Drawing.Size(171, 20);
            this.Contra1Box.TabIndex = 17;
            // 
            // Usuario1Box
            // 
            this.Usuario1Box.Location = new System.Drawing.Point(444, 128);
            this.Usuario1Box.Name = "Usuario1Box";
            this.Usuario1Box.Size = new System.Drawing.Size(171, 20);
            this.Usuario1Box.TabIndex = 16;
            // 
            // Registrarse
            // 
            this.Registrarse.Location = new System.Drawing.Point(444, 249);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(171, 69);
            this.Registrarse.TabIndex = 15;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // Invitacion_group
            // 
            this.Invitacion_group.BackColor = System.Drawing.Color.LightGreen;
            this.Invitacion_group.Controls.Add(this.invitar_box);
            this.Invitacion_group.Controls.Add(this.Invitar_btn);
            this.Invitacion_group.Controls.Add(this.label3);
            this.Invitacion_group.Location = new System.Drawing.Point(39, 56);
            this.Invitacion_group.Name = "Invitacion_group";
            this.Invitacion_group.Size = new System.Drawing.Size(180, 103);
            this.Invitacion_group.TabIndex = 18;
            this.Invitacion_group.TabStop = false;
            this.Invitacion_group.Text = "¡Juega con alguien!";
            // 
            // invitar_box
            // 
            this.invitar_box.Location = new System.Drawing.Point(36, 46);
            this.invitar_box.Name = "invitar_box";
            this.invitar_box.Size = new System.Drawing.Size(100, 20);
            this.invitar_box.TabIndex = 19;
            // 
            // Invitar_btn
            // 
            this.Invitar_btn.Location = new System.Drawing.Point(49, 72);
            this.Invitar_btn.Name = "Invitar_btn";
            this.Invitar_btn.Size = new System.Drawing.Size(75, 23);
            this.Invitar_btn.TabIndex = 20;
            this.Invitar_btn.Text = "Invitar";
            this.Invitar_btn.UseVisualStyleBackColor = true;
            this.Invitar_btn.Click += new System.EventHandler(this.Invitar_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "¿Quieres invitar a alguien?";
            // 
            // Invitado_group
            // 
            this.Invitado_group.BackColor = System.Drawing.Color.LightGreen;
            this.Invitado_group.Controls.Add(this.Rechazar_btn);
            this.Invitado_group.Controls.Add(this.Aceptar_btn);
            this.Invitado_group.Controls.Add(this.invitado_lbl);
            this.Invitado_group.Location = new System.Drawing.Point(327, 58);
            this.Invitado_group.Name = "Invitado_group";
            this.Invitado_group.Size = new System.Drawing.Size(180, 101);
            this.Invitado_group.TabIndex = 19;
            this.Invitado_group.TabStop = false;
            this.Invitado_group.Text = "¡Te han invitado a jugar!";
            // 
            // Rechazar_btn
            // 
            this.Rechazar_btn.Location = new System.Drawing.Point(98, 72);
            this.Rechazar_btn.Name = "Rechazar_btn";
            this.Rechazar_btn.Size = new System.Drawing.Size(75, 23);
            this.Rechazar_btn.TabIndex = 21;
            this.Rechazar_btn.Text = "Rechazar";
            this.Rechazar_btn.UseVisualStyleBackColor = true;
            this.Rechazar_btn.Click += new System.EventHandler(this.Rechazar_btn_Click);
            // 
            // Aceptar_btn
            // 
            this.Aceptar_btn.Location = new System.Drawing.Point(9, 72);
            this.Aceptar_btn.Name = "Aceptar_btn";
            this.Aceptar_btn.Size = new System.Drawing.Size(75, 23);
            this.Aceptar_btn.TabIndex = 20;
            this.Aceptar_btn.Text = "Aceptar";
            this.Aceptar_btn.UseVisualStyleBackColor = true;
            this.Aceptar_btn.Click += new System.EventHandler(this.Aceptar_btn_Click);
            // 
            // invitado_lbl
            // 
            this.invitado_lbl.AutoSize = true;
            this.invitado_lbl.Location = new System.Drawing.Point(31, 37);
            this.invitado_lbl.Name = "invitado_lbl";
            this.invitado_lbl.Size = new System.Drawing.Size(115, 13);
            this.invitado_lbl.TabIndex = 0;
            this.invitado_lbl.Text = "No te han invitado aún";
            // 
            // Conectados_box
            // 
            this.Conectados_box.Controls.Add(this.Conectados_data);
            this.Conectados_box.Location = new System.Drawing.Point(32, 339);
            this.Conectados_box.Name = "Conectados_box";
            this.Conectados_box.Size = new System.Drawing.Size(199, 271);
            this.Conectados_box.TabIndex = 20;
            this.Conectados_box.TabStop = false;
            this.Conectados_box.Text = "Lista conectados:";
            // 
            // Conectados_data
            // 
            this.Conectados_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Conectados_data.Location = new System.Drawing.Point(11, 19);
            this.Conectados_data.Name = "Conectados_data";
            this.Conectados_data.Size = new System.Drawing.Size(170, 227);
            this.Conectados_data.TabIndex = 0;
            this.Conectados_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Conectados_data_CellContentClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Bienvenido a Parchis ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Jugadores_Partidas);
            this.groupBox1.Controls.Add(this.Ganador_Partida);
            this.groupBox1.Controls.Add(this.Contraseña_Usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.Realizar_Consulta);
            this.groupBox1.Location = new System.Drawing.Point(758, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 291);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas a realizar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Si ya está registrado, inicie sesión:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Si aún no tiene cuenta, puede resgistrarse a continuación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Contraseña:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Contraseña:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Invitado_group);
            this.groupBox2.Controls.Add(this.Invitacion_group);
            this.groupBox2.Location = new System.Drawing.Point(298, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 183);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amigos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1166, 587);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "¿Cansado de jugar?  -----> ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 622);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Conectados_box);
            this.Controls.Add(this.Contra1Box);
            this.Controls.Add(this.Usuario1Box);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.dado);
            this.Controls.Add(this.fichas);
            this.Controls.Add(this.Tablero);
            this.Controls.Add(this.ContraBox);
            this.Controls.Add(this.UsuarioBox);
            this.Controls.Add(this.Iniciar_Session);
            this.Controls.Add(this.Desconectarse_Del_Servidor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado)).EndInit();
            this.Invitacion_group.ResumeLayout(false);
            this.Invitacion_group.PerformLayout();
            this.Invitado_group.ResumeLayout(false);
            this.Invitado_group.PerformLayout();
            this.Conectados_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Conectados_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Desconectarse_Del_Servidor;
        private System.Windows.Forms.RadioButton Contraseña_Usuario;
        private System.Windows.Forms.RadioButton Ganador_Partida;
        private System.Windows.Forms.RadioButton Jugadores_Partidas;
        private System.Windows.Forms.Button Realizar_Consulta;
        private System.Windows.Forms.Button Iniciar_Session;
        private System.Windows.Forms.TextBox UsuarioBox;
        private System.Windows.Forms.TextBox ContraBox;
        private System.Windows.Forms.PictureBox Tablero;
        private System.Windows.Forms.PictureBox fichas;
        private System.Windows.Forms.PictureBox dado;
        private System.Windows.Forms.TextBox Contra1Box;
        private System.Windows.Forms.TextBox Usuario1Box;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.GroupBox Invitacion_group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox invitar_box;
        private System.Windows.Forms.Button Invitar_btn;
        private System.Windows.Forms.GroupBox Invitado_group;
        private System.Windows.Forms.Button Rechazar_btn;
        private System.Windows.Forms.Button Aceptar_btn;
        private System.Windows.Forms.Label invitado_lbl;
        private System.Windows.Forms.GroupBox Conectados_box;
        private System.Windows.Forms.DataGridView Conectados_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
    }
}

