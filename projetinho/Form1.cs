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

        

        private void Btnstore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bem vindo ao china");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnpastel_Click(object sender, EventArgs e)
        {
            string size = txbsize.Text;
            string Flavor = txbFlavor.Text;

            string menssage = "tamanho:" + size + "sabor:" + Flavor;

            MessageBox.Show(menssage,
                "escolha seu pastel",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnPronto_Click(object sender, EventArgs e)
        {

        }
    }
}
