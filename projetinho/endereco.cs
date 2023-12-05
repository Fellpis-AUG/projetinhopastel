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
    public partial class endereco : Form
    {
        public endereco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void endereco_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(textBox1.Text,
                    textBox2.Text,
                    textBox3.Text
                   );

                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.UpdateUser1(usuario);
                MessageBox.Show("cadastro feito");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
