using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projetinho
{
    internal class UsuarioDAO
    {
       
        public void DeleteUser(int Id)
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
                MessageBox.Show("Usuario deletado");

            }
        }
        public void InsertUser(Usuario usuario)
        {
            string email = usuario.E_mail;

            ClassConexao connection = new ClassConexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO usuario VALUES ( @nome, @email, @numero, @endereco, @data_de_nacimento, @senha)";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@email", usuario.E_mail);
            sqlCommand.Parameters.AddWithValue("@numero", usuario.Numero);
            sqlCommand.Parameters.AddWithValue("@endereco", usuario.Enderco);
            sqlCommand.Parameters.AddWithValue("@data_de_nacimento", usuario.Data_De_Nacimento);
            sqlCommand.Parameters.AddWithValue("@senha", usuario.Senha);

            if (IsValidEmail(email) == true)
            {
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("email invalido");
            }
                
        }
        public Usuario LoginUser(string email, string senha)
        {
            ClassConexao connection = new ClassConexao();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM usuario WHERE email = @email AND senha = @senha";

            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@senha", senha);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario usuario = new Usuario("nome",int.Parse("id"),"email","numero","endereco",DateTime.Parse("data_de_nascimento"),"senha");
                    usuario.Nome = reader.GetString(0);
                    usuario.E_mail = reader.GetString(1);
                    usuario.Numero = reader.GetString(2);
                    usuario.Enderco = reader.GetString(3);
                    usuario.Data_De_Nacimento = reader.GetDateTime(4);
                    usuario.Senha = reader.GetString(5);
                    return usuario;
                }
            }

            return null;
        }
        public bool IsValidEmail(string email)
        {
            // Define a expressão regular para validar um endereço de e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Cria um objeto Regex com a expressão regular
            Regex regex = new Regex(pattern);

            // Usa o método Match para verificar se o email corresponde ao padrão
            return regex.IsMatch(email);
        }



        public List<Usuario> selectUser()
        {


            ClassConexao conn = new ClassConexao();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT Id, nome, email, numero, endereco FROM usuario";

            List<Usuario> lista = new List<Usuario>();

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Usuario objeto = new Usuario(
                     (string)dr["nome"],
                     (int)dr["Id"],
                    (string)dr["email"],
                    (string)dr["numero"],
                    (string)dr["endereco"]



                                               );
                    lista.Add(objeto);
                }
                dr.Close();

            }
            catch (Exception error)
            {
                throw new Exception("Erro" + error.Message);


            }
            finally
            {
                conn.CloseConnection();
            }
            return lista;

        }
    }

}

