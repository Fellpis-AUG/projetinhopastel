using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projetinho
{
    public partial class Formlogin : Form
    {
        private int Id;

        public Formlogin()
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
                    ListViewItem lv = new ListViewItem(usuar.ToString());
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


        private void Formlogin_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(txt_nome.Text,
                    tex_email.Text,
                    txt_numero.Text,
                    
                     Convert.ToDateTime(DataDeNacimento.Value),
                     Criptografia.CriptografarSenha(txtSenha.Text));

                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.UpdateUser(usuario);
                MessageBox.Show("cadastro feito");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
           
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            //Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txt_nome.Text = listView1.Items[index].SubItems[1].Text;
            tex_email.Text = listView1.Items[index].SubItems[2].Text;
            txt_numero.Text = listView1.Items[index].SubItems[3].Text;
            txtSenha.Text = listView1.Items[index].SubItems[4].Text;


        }

        private void TextDataDeNacimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TextDataDeNacimentoo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deletar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.DeleteUser(Id);

            UpdateListView();

            txt_nome.Clear();
            tex_email.Clear();
            txt_numero.Clear();
           
            txtSenha.Clear();


        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_numero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tex_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
