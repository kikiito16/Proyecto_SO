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
            this.Conectar_Servidor = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Desconectarse_Del_Servidor = new System.Windows.Forms.Button();
            this.Contraseña_Usuario = new System.Windows.Forms.RadioButton();
            this.Ganador_Partida = new System.Windows.Forms.RadioButton();
            this.Jugadores_Partidas = new System.Windows.Forms.RadioButton();
            this.Realizar_Consulta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaConectadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.UsuarioBox = new System.Windows.Forms.TextBox();
            this.ContraBox = new System.Windows.Forms.TextBox();
            this.Conectados_lab = new System.Windows.Forms.Label();
            this.ConectadosBox = new System.Windows.Forms.TextBox();
            this.Fichas = new System.Windows.Forms.PictureBox();
            this.Dado = new System.Windows.Forms.PictureBox();
            this.Tablero = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fichas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            this.SuspendLayout();
            // 
            // Conectar_Servidor
            // 
            this.Conectar_Servidor.Location = new System.Drawing.Point(12, 54);
            this.Conectar_Servidor.Name = "Conectar_Servidor";
            this.Conectar_Servidor.Size = new System.Drawing.Size(177, 34);
            this.Conectar_Servidor.TabIndex = 0;
            this.Conectar_Servidor.Text = "Conectar al Servidor";
            this.Conectar_Servidor.UseVisualStyleBackColor = true;
            this.Conectar_Servidor.Click += new System.EventHandler(this.Conectar_Servidor_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(433, 37);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(259, 20);
            this.nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(433, 138);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(259, 20);
            this.ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion de la Partida";
            // 
            // Desconectarse_Del_Servidor
            // 
            this.Desconectarse_Del_Servidor.Location = new System.Drawing.Point(12, 230);
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
            this.Contraseña_Usuario.Location = new System.Drawing.Point(433, 63);
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
            this.Ganador_Partida.Location = new System.Drawing.Point(433, 187);
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
            this.Jugadores_Partidas.Location = new System.Drawing.Point(433, 164);
            this.Jugadores_Partidas.Name = "Jugadores_Partidas";
            this.Jugadores_Partidas.Size = new System.Drawing.Size(181, 17);
            this.Jugadores_Partidas.TabIndex = 3;
            this.Jugadores_Partidas.TabStop = true;
            this.Jugadores_Partidas.Text = "Que jugadores jugaron la partida ";
            this.Jugadores_Partidas.UseVisualStyleBackColor = true;
            // 
            // Realizar_Consulta
            // 
            this.Realizar_Consulta.Location = new System.Drawing.Point(459, 230);
            this.Realizar_Consulta.Name = "Realizar_Consulta";
            this.Realizar_Consulta.Size = new System.Drawing.Size(177, 34);
            this.Realizar_Consulta.TabIndex = 0;
            this.Realizar_Consulta.Text = "Realizar la Consulta";
            this.Realizar_Consulta.UseVisualStyleBackColor = true;
            this.Realizar_Consulta.Click += new System.EventHandler(this.Realizar_Consulta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1522, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarseToolStripMenuItem,
            this.iniciarSesionToolStripMenuItem,
            this.listaConectadosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.registrarseToolStripMenuItem.Text = "Registrarse";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            // 
            // listaConectadosToolStripMenuItem
            // 
            this.listaConectadosToolStripMenuItem.Name = "listaConectadosToolStripMenuItem";
            this.listaConectadosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listaConectadosToolStripMenuItem.Text = "Lista Conectados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsuarioBox
            // 
            this.UsuarioBox.Location = new System.Drawing.Point(271, 91);
            this.UsuarioBox.Name = "UsuarioBox";
            this.UsuarioBox.Size = new System.Drawing.Size(100, 20);
            this.UsuarioBox.TabIndex = 8;
            // 
            // ContraBox
            // 
            this.ContraBox.Location = new System.Drawing.Point(271, 129);
            this.ContraBox.Name = "ContraBox";
            this.ContraBox.Size = new System.Drawing.Size(100, 20);
            this.ContraBox.TabIndex = 9;
            // 
            // Conectados_lab
            // 
            this.Conectados_lab.AutoSize = true;
            this.Conectados_lab.Location = new System.Drawing.Point(12, 98);
            this.Conectados_lab.Name = "Conectados_lab";
            this.Conectados_lab.Size = new System.Drawing.Size(67, 13);
            this.Conectados_lab.TabIndex = 10;
            this.Conectados_lab.Text = "Conectados:";
            // 
            // ConectadosBox
            // 
            this.ConectadosBox.Location = new System.Drawing.Point(15, 122);
            this.ConectadosBox.Multiline = true;
            this.ConectadosBox.Name = "ConectadosBox";
            this.ConectadosBox.ReadOnly = true;
            this.ConectadosBox.Size = new System.Drawing.Size(174, 91);
            this.ConectadosBox.TabIndex = 11;
            // 
            // Fichas
            // 
            this.Fichas.Image = global::Cliente.Properties.Resources.ficha_parchis_o16_mm;
            this.Fichas.Location = new System.Drawing.Point(1272, 287);
            this.Fichas.Name = "Fichas";
            this.Fichas.Size = new System.Drawing.Size(114, 128);
            this.Fichas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fichas.TabIndex = 14;
            this.Fichas.TabStop = false;
            this.Fichas.Click += new System.EventHandler(this.Fichas_Click);
            // 
            // Dado
            // 
            this.Dado.Image = global::Cliente.Properties.Resources.Dado;
            this.Dado.Location = new System.Drawing.Point(1272, 63);
            this.Dado.Name = "Dado";
            this.Dado.Size = new System.Drawing.Size(114, 104);
            this.Dado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dado.TabIndex = 13;
            this.Dado.TabStop = false;
            // 
            // Tablero
            // 
            this.Tablero.Image = global::Cliente.Properties.Resources.Tablero_parchis;
            this.Tablero.Location = new System.Drawing.Point(795, 37);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(444, 451);
            this.Tablero.TabIndex = 12;
            this.Tablero.TabStop = false;
            this.Tablero.Click += new System.EventHandler(this.Tablero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 523);
            this.Controls.Add(this.Fichas);
            this.Controls.Add(this.Dado);
            this.Controls.Add(this.Tablero);
            this.Controls.Add(this.ConectadosBox);
            this.Controls.Add(this.Conectados_lab);
            this.Controls.Add(this.ContraBox);
            this.Controls.Add(this.UsuarioBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Jugadores_Partidas);
            this.Controls.Add(this.Ganador_Partida);
            this.Controls.Add(this.Contraseña_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.Desconectarse_Del_Servidor);
            this.Controls.Add(this.Realizar_Consulta);
            this.Controls.Add(this.Conectar_Servidor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fichas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conectar_Servidor;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Desconectarse_Del_Servidor;
        private System.Windows.Forms.RadioButton Contraseña_Usuario;
        private System.Windows.Forms.RadioButton Ganador_Partida;
        private System.Windows.Forms.RadioButton Jugadores_Partidas;
        private System.Windows.Forms.Button Realizar_Consulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaConectadosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UsuarioBox;
        private System.Windows.Forms.TextBox ContraBox;
        private System.Windows.Forms.Label Conectados_lab;
        private System.Windows.Forms.TextBox ConectadosBox;
        private System.Windows.Forms.PictureBox Tablero;
        private System.Windows.Forms.PictureBox Dado;
        private System.Windows.Forms.PictureBox Fichas;
    }
}

