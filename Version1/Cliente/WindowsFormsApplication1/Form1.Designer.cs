﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ganador = new System.Windows.Forms.RadioButton();
            this.altura = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.iniciarses = new System.Windows.Forms.Button();
            this.usuBox = new System.Windows.Forms.TextBox();
            this.contraBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(116, 31);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Conectar al servidor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Ganador);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.Contra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(23, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Ganador
            // 
            this.Ganador.AutoSize = true;
            this.Ganador.Location = new System.Drawing.Point(116, 91);
            this.Ganador.Name = "Ganador";
            this.Ganador.Size = new System.Drawing.Size(119, 17);
            this.Ganador.TabIndex = 7;
            this.Ganador.TabStop = true;
            this.Ganador.Text = "Consulta el ganador";
            this.Ganador.UseVisualStyleBackColor = true;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(116, 119);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(142, 17);
            this.altura.TabIndex = 7;
            this.altura.TabStop = true;
            this.altura.Text = "¿Quien jugó la partida x?";
            this.altura.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID de partida";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(15, 110);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(62, 20);
            this.IDBox.TabIndex = 9;
            // 
            // Contra
            // 
            this.Contra.AutoSize = true;
            this.Contra.Location = new System.Drawing.Point(116, 68);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(224, 17);
            this.Contra.TabIndex = 8;
            this.Contra.TabStop = true;
            this.Contra.Text = "He olvidado la contraseña de este usuario";
            this.Contra.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(25, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "Log out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iniciarses
            // 
            this.iniciarses.Location = new System.Drawing.Point(510, 53);
            this.iniciarses.Name = "iniciarses";
            this.iniciarses.Size = new System.Drawing.Size(99, 23);
            this.iniciarses.TabIndex = 11;
            this.iniciarses.Text = "Iniciar sesión";
            this.iniciarses.UseVisualStyleBackColor = true;
            this.iniciarses.Click += new System.EventHandler(this.iniciarses_Click);
            // 
            // usuBox
            // 
            this.usuBox.Location = new System.Drawing.Point(510, 104);
            this.usuBox.Name = "usuBox";
            this.usuBox.Size = new System.Drawing.Size(100, 20);
            this.usuBox.TabIndex = 12;
            this.usuBox.Visible = false;
            // 
            // contraBox
            // 
            this.contraBox.Location = new System.Drawing.Point(510, 171);
            this.contraBox.Name = "contraBox";
            this.contraBox.Size = new System.Drawing.Size(100, 20);
            this.contraBox.TabIndex = 13;
            this.contraBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(507, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(507, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contraseña";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraBox);
            this.Controls.Add(this.usuBox);
            this.Controls.Add(this.iniciarses);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ganador;
        private System.Windows.Forms.RadioButton Contra;
        private System.Windows.Forms.RadioButton altura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button iniciarses;
        private System.Windows.Forms.TextBox usuBox;
        private System.Windows.Forms.TextBox contraBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

