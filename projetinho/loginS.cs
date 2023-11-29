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
    public partial class loginS : Form
    {
        public loginS()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string email = textBox1.Text;
            string senha = textBox2.Text;

            
            UsuarioDAO usuarioDAO = new UsuarioDAO();

           
            Usuario usuario = usuarioDAO.LoginUser(email, senha);

            if (usuario != null)
            {
                MessageBox.Show("Login bem-sucedido! Bem-vindo, " + usuario.Nome + "!");
            }
            else
            {
             
                MessageBox.Show("Falha no login. Por favor, verifique seu e-mail e senha e tente novamente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            criar criar = new criar();
            criar.Show();

        }
    }
}
