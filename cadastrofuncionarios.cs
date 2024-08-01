using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcionario
{
    internal class cadastrofuncionarios
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }



        public bool CadastrarFuncionarios()
        {




            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.BancoServidor);
                MysqlConexaoBanco.Open();

                string insert = "INSERT INTO funcionarios (nome, email, cpf, endereco) VALUES (@Nome, @Email, @Cpf, @Endereco)";

                MySqlCommand comandoSql = new MySqlCommand(insert, MysqlConexaoBanco);

                comandoSql.Parameters.AddWithValue("@Nome", Nome);
                comandoSql.Parameters.AddWithValue("@Email", Email);
                comandoSql.Parameters.AddWithValue("@Cpf", Cpf);
                comandoSql.Parameters.AddWithValue("@Endereco", Endereco);

                comandoSql.ExecuteNonQuery();

                

                return true;
            }
            
            
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado - método cadastrar funcionário: " + ex.Message);
                return false;
            }
        }
    }
}
