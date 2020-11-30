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
            this.Conectados_lab = new System.Windows.Forms.Label();
            this.ConectadosBox = new System.Windows.Forms.TextBox();
            this.Tablero = new System.Windows.Forms.PictureBox();
            this.fichas = new System.Windows.Forms.PictureBox();
            this.dado = new System.Windows.Forms.PictureBox();
            this.Contra1Box = new System.Windows.Forms.TextBox();
            this.Usuario1Box = new System.Windows.Forms.TextBox();
            this.Registrarse = new System.Windows.Forms.Button();
            this.Invitacion_group = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invitar_box = new System.Windows.Forms.TextBox();
            this.Invitar_btn = new System.Windows.Forms.Button();
            this.Invitado_group = new System.Windows.Forms.GroupBox();
            this.Aceptar_btn = new System.Windows.Forms.Button();
            this.invitado_lbl = new System.Windows.Forms.Label();
            this.Rechazar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado)).BeginInit();
            this.Invitacion_group.SuspendLayout();
            this.Invitado_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(456, 60);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(259, 20);
            this.nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(456, 161);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(259, 20);
            this.ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion de la Partida";
            // 
            // Desconectarse_Del_Servidor
            // 
            this.Desconectarse_Del_Servidor.Location = new System.Drawing.Point(12, 380);
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
            this.Contraseña_Usuario.Location = new System.Drawing.Point(456, 86);
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
            this.Ganador_Partida.Location = new System.Drawing.Point(456, 210);
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
            this.Jugadores_Partidas.Location = new System.Drawing.Point(456, 187);
            this.Jugadores_Partidas.Name = "Jugadores_Partidas";
            this.Jugadores_Partidas.Size = new System.Drawing.Size(181, 17);
            this.Jugadores_Partidas.TabIndex = 3;
            this.Jugadores_Partidas.TabStop = true;
            this.Jugadores_Partidas.Text = "Que jugadores jugaron la partida ";
            this.Jugadores_Partidas.UseVisualStyleBackColor = true;
            // 
            // Realizar_Consulta
            // 
            this.Realizar_Consulta.Location = new System.Drawing.Point(482, 253);
            this.Realizar_Consulta.Name = "Realizar_Consulta";
            this.Realizar_Consulta.Size = new System.Drawing.Size(177, 34);
            this.Realizar_Consulta.TabIndex = 0;
            this.Realizar_Consulta.Text = "Realizar la Consulta";
            this.Realizar_Consulta.UseVisualStyleBackColor = true;
            this.Realizar_Consulta.Click += new System.EventHandler(this.Realizar_Consulta_Click);
            // 
            // Iniciar_Session
            // 
            this.Iniciar_Session.Location = new System.Drawing.Point(23, 24);
            this.Iniciar_Session.Name = "Iniciar_Session";
            this.Iniciar_Session.Size = new System.Drawing.Size(186, 69);
            this.Iniciar_Session.TabIndex = 7;
            this.Iniciar_Session.Text = "Iniciar Sesion";
            this.Iniciar_Session.UseVisualStyleBackColor = true;
            this.Iniciar_Session.Click += new System.EventHandler(this.Iniciar_Session_Click);
            // 
            // UsuarioBox
            // 
            this.UsuarioBox.Location = new System.Drawing.Point(23, 100);
            this.UsuarioBox.Name = "UsuarioBox";
            this.UsuarioBox.Size = new System.Drawing.Size(186, 20);
            this.UsuarioBox.TabIndex = 8;
            // 
            // ContraBox
            // 
            this.ContraBox.Location = new System.Drawing.Point(23, 138);
            this.ContraBox.Name = "ContraBox";
            this.ContraBox.Size = new System.Drawing.Size(186, 20);
            this.ContraBox.TabIndex = 9;
            // 
            // Conectados_lab
            // 
            this.Conectados_lab.AutoSize = true;
            this.Conectados_lab.Location = new System.Drawing.Point(12, 244);
            this.Conectados_lab.Name = "Conectados_lab";
            this.Conectados_lab.Size = new System.Drawing.Size(67, 13);
            this.Conectados_lab.TabIndex = 10;
            this.Conectados_lab.Text = "Conectados:";
            // 
            // ConectadosBox
            // 
            this.ConectadosBox.Location = new System.Drawing.Point(12, 270);
            this.ConectadosBox.Multiline = true;
            this.ConectadosBox.Name = "ConectadosBox";
            this.ConectadosBox.ReadOnly = true;
            this.ConectadosBox.Size = new System.Drawing.Size(174, 91);
            this.ConectadosBox.TabIndex = 11;
            // 
            // Tablero
            // 
            this.Tablero.Image = ((System.Drawing.Image)(resources.GetObject("Tablero.Image")));
            this.Tablero.Location = new System.Drawing.Point(721, 44);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(281, 281);
            this.Tablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tablero.TabIndex = 12;
            this.Tablero.TabStop = false;
            // 
            // fichas
            // 
            this.fichas.Image = ((System.Drawing.Image)(resources.GetObject("fichas.Image")));
            this.fichas.Location = new System.Drawing.Point(1014, 187);
            this.fichas.Name = "fichas";
            this.fichas.Size = new System.Drawing.Size(59, 50);
            this.fichas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fichas.TabIndex = 13;
            this.fichas.TabStop = false;
            // 
            // dado
            // 
            this.dado.Image = ((System.Drawing.Image)(resources.GetObject("dado.Image")));
            this.dado.Location = new System.Drawing.Point(1014, 61);
            this.dado.Name = "dado";
            this.dado.Size = new System.Drawing.Size(59, 50);
            this.dado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dado.TabIndex = 14;
            this.dado.TabStop = false;
            // 
            // Contra1Box
            // 
            this.Contra1Box.Location = new System.Drawing.Point(237, 138);
            this.Contra1Box.Name = "Contra1Box";
            this.Contra1Box.Size = new System.Drawing.Size(171, 20);
            this.Contra1Box.TabIndex = 17;
            // 
            // Usuario1Box
            // 
            this.Usuario1Box.Location = new System.Drawing.Point(237, 100);
            this.Usuario1Box.Name = "Usuario1Box";
            this.Usuario1Box.Size = new System.Drawing.Size(171, 20);
            this.Usuario1Box.TabIndex = 16;
            // 
            // Registrarse
            // 
            this.Registrarse.Location = new System.Drawing.Point(237, 24);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(171, 69);
            this.Registrarse.TabIndex = 15;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            // 
            // Invitacion_group
            // 
            this.Invitacion_group.BackColor = System.Drawing.Color.LightGreen;
            this.Invitacion_group.Controls.Add(this.invitar_box);
            this.Invitacion_group.Controls.Add(this.Invitar_btn);
            this.Invitacion_group.Controls.Add(this.label3);
            this.Invitacion_group.Location = new System.Drawing.Point(224, 300);
            this.Invitacion_group.Name = "Invitacion_group";
            this.Invitacion_group.Size = new System.Drawing.Size(180, 103);
            this.Invitacion_group.TabIndex = 18;
            this.Invitacion_group.TabStop = false;
            this.Invitacion_group.Text = "¡Juega con alguien!";
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
            // invitar_box
            // 
            this.invitar_box.Location = new System.Drawing.Point(36, 46);
            this.invitar_box.Name = "invitar_box";
            this.invitar_box.Size = new System.Drawing.Size(100, 20);
            this.invitar_box.TabIndex = 19;
            // 
            // Invitar_btn
            // 
            this.Invitar_btn.Location = new System.Drawing.Point(46, 72);
            this.Invitar_btn.Name = "Invitar_btn";
            this.Invitar_btn.Size = new System.Drawing.Size(75, 23);
            this.Invitar_btn.TabIndex = 20;
            this.Invitar_btn.Text = "Invitar";
            this.Invitar_btn.UseVisualStyleBackColor = true;
            this.Invitar_btn.Click += new System.EventHandler(this.Invitar_btn_Click);
            // 
            // Invitado_group
            // 
            this.Invitado_group.BackColor = System.Drawing.Color.LightGreen;
            this.Invitado_group.Controls.Add(this.Rechazar_btn);
            this.Invitado_group.Controls.Add(this.Aceptar_btn);
            this.Invitado_group.Controls.Add(this.invitado_lbl);
            this.Invitado_group.Location = new System.Drawing.Point(228, 177);
            this.Invitado_group.Name = "Invitado_group";
            this.Invitado_group.Size = new System.Drawing.Size(180, 101);
            this.Invitado_group.TabIndex = 19;
            this.Invitado_group.TabStop = false;
            this.Invitado_group.Text = "¡Te han invitado a jugar!";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 415);
            this.Controls.Add(this.Invitado_group);
            this.Controls.Add(this.Invitacion_group);
            this.Controls.Add(this.Contra1Box);
            this.Controls.Add(this.Usuario1Box);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.dado);
            this.Controls.Add(this.fichas);
            this.Controls.Add(this.Tablero);
            this.Controls.Add(this.ConectadosBox);
            this.Controls.Add(this.Conectados_lab);
            this.Controls.Add(this.ContraBox);
            this.Controls.Add(this.UsuarioBox);
            this.Controls.Add(this.Iniciar_Session);
            this.Controls.Add(this.Jugadores_Partidas);
            this.Controls.Add(this.Ganador_Partida);
            this.Controls.Add(this.Contraseña_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.Desconectarse_Del_Servidor);
            this.Controls.Add(this.Realizar_Consulta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado)).EndInit();
            this.Invitacion_group.ResumeLayout(false);
            this.Invitacion_group.PerformLayout();
            this.Invitado_group.ResumeLayout(false);
            this.Invitado_group.PerformLayout();
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
        private System.Windows.Forms.Label Conectados_lab;
        private System.Windows.Forms.TextBox ConectadosBox;
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
    }
}

