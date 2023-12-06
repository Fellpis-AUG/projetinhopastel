using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace projetinho
{
    public class Usuario
    {
        internal readonly SerializationInfo ID;
        private string _nome;
        private int _id;
        private string _e_mail;
        private string _numero;
        private DateTime _data_De_Ncimento;
        private string _senha;
        private string _bairro;
        private string _rua;
        private string _numero_casa;

        public Usuario(string nome, string e_mail, string numero, DateTime data_de_nacimento, string senha)
        {
            Nome = nome;
            E_mail = e_mail;
            Numero = numero;
            Senha = senha;
            Data_De_Nacimento = data_de_nacimento;
        }
        public Usuario(string bairro, string rua, string numero_casa, int id)
        {
            Bairro = bairro;
            Rua = rua;
            Numero_casa = numero_casa;
            Id = id;
        }
        public Usuario(string bairro, string rua, string numero_casa)
        {
            Bairro = bairro;
            Rua = rua;
            Numero_casa = numero_casa;

        }
        public Usuario(string nome, int id, string e_mail, string numero)
        {
            Nome = nome;
            E_mail = e_mail;
            Numero = numero;
            Id = id;

        }

        public Usuario(string nome, int id, string e_mail, string numero, DateTime data_de_nacimento, string senha): 
            this(nome, e_mail, numero, data_de_nacimento, senha)
        {
          
            Id = id;
           
        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("digita seu nome calabreso");
                _nome = value;
            }
            get { return _nome; }
        }
        public string E_mail
        {
            set { _e_mail = value; }
            get { return _e_mail; }
        }
        public string Numero
        {
            set { _numero = value; }
            get { return _numero; }
        }
        public string Senha
        {
            set { _senha = value; }
            get { return _senha; }
        }
        public DateTime Data_De_Nacimento
        {
            set { _data_De_Ncimento = value; }
            get { return _data_De_Ncimento; }
        }
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Rua
        {
            set { _rua = value; }
            get { return _rua; }
        }
        public string Bairro
        {
            set { _bairro = value; }
            get { return _bairro; }
        }
        public string Numero_casa
        {
            set { _numero_casa = value; }
            get { return _numero_casa; }
        }
    }
}
