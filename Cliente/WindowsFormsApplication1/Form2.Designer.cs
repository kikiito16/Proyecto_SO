namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.iniciarbtn = new System.Windows.Forms.Button();
            this.pswBox1 = new System.Windows.Forms.TextBox();
            this.usuBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iniciarbtn
            // 
            this.iniciarbtn.Location = new System.Drawing.Point(71, 188);
            this.iniciarbtn.Name = "iniciarbtn";
            this.iniciarbtn.Size = new System.Drawing.Size(100, 23);
            this.iniciarbtn.TabIndex = 0;
            this.iniciarbtn.Text = "Iniciar sesión";
            this.iniciarbtn.UseVisualStyleBackColor = true;
            this.iniciarbtn.Click += new System.EventHandler(this.iniciarbtn_Click);
            // 
            // pswBox1
            // 
            this.pswBox1.Location = new System.Drawing.Point(71, 137);
            this.pswBox1.Name = "pswBox1";
            this.pswBox1.Size = new System.Drawing.Size(100, 20);
            this.pswBox1.TabIndex = 1;
            this.pswBox1.Text = "Contraseña";
            // 
            // usuBox2
            // 
            this.usuBox2.Location = new System.Drawing.Point(71, 76);
            this.usuBox2.Name = "usuBox2";
            this.usuBox2.Size = new System.Drawing.Size(100, 20);
            this.usuBox2.TabIndex = 2;
            this.usuBox2.Text = "Usuario";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.usuBox2);
            this.Controls.Add(this.pswBox1);
            this.Controls.Add(this.iniciarbtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciarbtn;
        public System.Windows.Forms.TextBox usuBox2;
        public System.Windows.Forms.TextBox pswBox1;
    }
}