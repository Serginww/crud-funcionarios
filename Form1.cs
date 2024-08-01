using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
                {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCpf.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastrofuncionarios cadfuncionarios = new cadastrofuncionarios();
                    cadfuncionarios.Nome = txtNome.Text;
                    cadfuncionarios.Email = txtEmail.Text;
                    cadfuncionarios.Cpf = txtCpf.Text;
                    cadfuncionarios.Endereco = txtEndereco.Text;


                    if (cadfuncionarios.CadastrarFuncionarios()) 
                    {
                        MessageBox.Show($"O funcionario{cadfuncionarios.Nome} foi cadastrado com sucesso!");
                         txtNome.Clear();
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                    }
                    else
                        {
                        MessageBox.Show("Nao foi possivel cadastrar funcionario!");
                    }
                }
                else
                {
                    MessageBox.Show("favor preencher todos os campos");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();


                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionario:" + ex.Message);
                
            }
        }
    }
}
