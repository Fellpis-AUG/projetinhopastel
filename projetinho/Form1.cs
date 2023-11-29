using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


    
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginS loginS = new loginS();
            loginS.ShowDialog();
            //Formlogin formslogin = new Formlogin();
            //formslogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardapio cardapio = new cardapio();
            cardapio.Show();
        }
    }
}
