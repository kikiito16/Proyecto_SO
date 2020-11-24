namespace Cliente
{
    partial class LogIn
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
            this.Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.contra = new System.Windows.Forms.TextBox();
            this.Iniciar_Sesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(12, 50);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(12, 66);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(139, 20);
            this.nombre.TabIndex = 1;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // contra
            // 
            this.contra.Location = new System.Drawing.Point(12, 139);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(139, 20);
            this.contra.TabIndex = 1;
            this.contra.TextChanged += new System.EventHandler(this.contra_TextChanged);
            // 
            // Iniciar_Sesion
            // 
            this.Iniciar_Sesion.Location = new System.Drawing.Point(78, 191);
            this.Iniciar_Sesion.Name = "Iniciar_Sesion";
            this.Iniciar_Sesion.Size = new System.Drawing.Size(117, 23);
            this.Iniciar_Sesion.TabIndex = 2;
            this.Iniciar_Sesion.Text = "Iniciar Sesion";
            this.Iniciar_Sesion.UseVisualStyleBackColor = true;
            this.Iniciar_Sesion.Click += new System.EventHandler(this.Iniciar_Sesion_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Iniciar_Sesion);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuario);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.Button Iniciar_Sesion;
    }
}