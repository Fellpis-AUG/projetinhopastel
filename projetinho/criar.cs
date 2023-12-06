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
    public partial class criar : Form
    {
        public criar()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuario = usuarioDAO.selectUser();


            try
            {
                foreach (Usuario usuar in usuario)
                {
                    ListViewItem lv = new ListViewItem(usuar.Id.ToString());
                    lv.SubItems.Add(usuar.Nome);
                    lv.SubItems.Add(usuar.E_mail);
                    lv.SubItems.Add(usuar.Numero);
                    listView1.Items.Add(lv);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(txt_nome.Text,
                    tex_email.Text,
                    txt_numero.Text,
                     Convert.ToDateTime(DataDeNacimento.Value),
                     Criptografia.CriptografarSenha(txtSenha.Text));

                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.InsertUser(usuario);
               
                UpdateListView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlogin formlogin = new Formlogin();
            formlogin.Show();
        }

        private void criar_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            endereco endereco = new endereco();
            endereco.Show();
            
        }
    }
}
