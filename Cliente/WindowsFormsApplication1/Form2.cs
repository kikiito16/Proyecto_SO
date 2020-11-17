using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public delegate void enviar(string usuario, string psw);
        public event enviar enviado;

        public Form2()
        {
            InitializeComponent();
        }

        public void iniciarbtn_Click(object sender, EventArgs e)
        {
            
            enviado(usuBox2.Text, pswBox1.Text);
            this.Close();
           

        }
    }
}
