using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetinho
{
    public partial class endereco : Form
    {
        private int Id;
        public endereco()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView2.Items.Clear();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuario = usuarioDAO.selectUser1();


            try
            {
                foreach (Usuario usuar in usuario)
                {
                    ListViewItem lv = new ListViewItem(usuar.ToString());
                    lv.SubItems.Add(usuar.Bairro);
                    lv.SubItems.Add(usuar.Rua);
                    lv.SubItems.Add(usuar.Numero_casa);
                    listView2.Items.Add(lv);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(textBox1.Text,
                    textBox2.Text,
                    textBox3.Text);

                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.InsertUser1(usuario);
                MessageBox.Show("cadastro feito");
                UpdateListView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void endereco_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(textBox1.Text,
                    textBox2.Text,
                    textBox3.Text,
                    int.Parse (textBox4.Text)
                   );

                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.UpdateUser1(usuario);
                MessageBox.Show("edição feito");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.DeleteUser1(Id);

            UpdateListView();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            

        }
    }
}
