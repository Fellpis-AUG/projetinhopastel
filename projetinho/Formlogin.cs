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

            ClassConexao conn = new ClassConexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT Id, nome, email, numero, endereco FROM usuario";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["Id"];
                    string nome = (string)dr["nome"];
                    string email = (string)dr["email"];
                    string numero = (string)dr["numero"];
                    string endereço = (string)dr["endereco"];
                   

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(nome);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(numero);
                    lv.SubItems.Add(endereço);
                    listView1.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }


        private void Formlogin_Load(object sender, EventArgs e)
        {
            
                UpdateListView();
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassConexao connection = new ClassConexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO usuario VALUES ( @nome, @email, @numero, @endereco, @data_de_nacimento,@senha)";

            sqlCommand.Parameters.AddWithValue("@nome", txt_nome.Text);
            sqlCommand.Parameters.AddWithValue("@email", tex_email.Text);
            sqlCommand.Parameters.AddWithValue("@numero", txt_numero.Text);
            sqlCommand.Parameters.AddWithValue("@endereco", textEndereco.Text);
            sqlCommand.Parameters.AddWithValue("@data_de_nacimento", DataDeNacimento.Value);
            //sqlCommand.Parameters.AddWithValue("@data_de_nacimento", Convert.ToDateTime(DataDeNacimento));
            sqlCommand.Parameters.AddWithValue("@senha", txtSenha.Text);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastro com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            txt_nome.Clear();
            tex_email.Clear();
            txt_numero.Clear();
            textEndereco.Clear();
            //TextDataDeNacimento.Clear();
            txtSenha.Clear();

            //ClassConexao connection = new ClassConexao();
            //SqlCommand sqlCommand = new SqlCommand();

            //sqlCommand.Connection = connection.ReturnConnection();
            //sqlCommand.CommandText = @"UPDATE usuario SET 
            // nome = @nome,
            // email = @email,
            // numero = @numero,
            // endereco = @endereco,
            // data_de_nacimento = @data_de_nacimento,
            // senha = @senha
            // WHERE id = @id";

            //sqlCommand.Parameters.AddWithValue("@nome", txt_nome.Text);
            //sqlCommand.Parameters.AddWithValue("@email", tex_email.Text);
            //sqlCommand.Parameters.AddWithValue("@numero", txt_numero.Text);
            //sqlCommand.Parameters.AddWithValue("@endereco", textEndereco.Text);
            //sqlCommand.Parameters.AddWithValue("@data_de_nacimento", TextDataDeNacimento.Text);
            //sqlCommand.Parameters.AddWithValue("@senha", txtSenha.Text);


            //sqlCommand.ExecuteNonQuery();

            //MessageBox.Show("Atuelizado com sucesso",
            //    "AVISO",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
            //txt_nome.Clear();
            //tex_email.Clear();
            //txt_numero.Clear();
            //textEndereco.Clear();
            //TextDataDeNacimento.Clear();
            //txtSenha.Clear();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            string email = tex_email.Text;

            ClassConexao connection = new ClassConexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO usuario VALUES ( @nome, @email, @numero, @endereco, @data_de_nacimento, @senha)";

            sqlCommand.Parameters.AddWithValue("@nome", txt_nome.Text);
            sqlCommand.Parameters.AddWithValue("@email", tex_email.Text);
            sqlCommand.Parameters.AddWithValue("@numero", txt_numero.Text);
            sqlCommand.Parameters.AddWithValue("@endereco", textEndereco.Text);
            //sqlCommand.Parameters.AddWithValue("@endereco", TextDataDeNacimento.Text);
            sqlCommand.Parameters.AddWithValue("@data_de_nacimento", DataDeNacimento.Value);
            sqlCommand.Parameters.AddWithValue("@senha", txtSenha.Text);

            sqlCommand.ExecuteNonQuery();
            if (IsValidEmail(email))
            {
                sqlCommand.ExecuteNonQuery();


                txt_nome.Clear();
                tex_email.Clear();
                txt_numero.Clear();
                textEndereco.Clear();
                //TextDataDeNacimento.Clear();
                txtSenha.Clear();

                Close();
            }
            else
            {
                MessageBox.Show("O endereço de e - mail é inválido");

            }

            }

            private bool IsValidEmail(string email)
            {
                // Define a expressão regular para validar um endereço de e-mail
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                // Cria um objeto Regex com a expressão regular
                Regex regex = new Regex(pattern);

                // Usa o método Match para verificar se o email corresponde ao padrão
                return regex.IsMatch(email);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txt_nome.Text = listView1.Items[index].SubItems[1].Text;
            tex_email.Text = listView1.Items[index].SubItems[2].Text;
            txt_numero.Text = listView1.Items[index].SubItems[3].Text;
            textEndereco.Text = listView1.Items[index].SubItems[4].Text;

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
            ClassConexao connection = new ClassConexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Usuarios WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

        }
    }
}
