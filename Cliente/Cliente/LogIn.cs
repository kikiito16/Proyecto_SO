using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente
{
    public partial class LogIn : Form
    {
        public delegate void enviar(string usuario, string psw);
        public event enviar enviado;
        public LogIn()
        {
            InitializeComponent();
        }

        private void Iniciar_Sesion_Click(object sender, EventArgs e)
        {
            enviado(nombre.Text, contra.Text);
            this.Close();

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
