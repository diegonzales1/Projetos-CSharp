using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeiroProjeto_BancoDeDados
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexaoFixo = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projetos C-Sharp\PrimeiroProjeto-BancoDeDados\BancoEscola.mdf;Integrated Security=True";
                SqlConnection objConexao = new SqlConnection(conexaoFixo);
                objConexao.Open();

                string consulta = "select count(*) from professores where nomeProfessor = '" +textBoxLoginNome.Text + "' and senha = '" + textBoxLoginSenha.Text +"'";
                SqlCommand objCon = new SqlCommand(consulta, objConexao);

                int retorno = (int) objCon.ExecuteScalar();

                if (retorno == 1)
                {
                    Form1 objForm = new Form1();
                    this.Hide(); // fecha o formulario de login
                    objForm.ShowDialog();
                }
                else
                    MessageBox.Show("USUARIO NAO RECONHECIDO");
            }
            catch (Exception error)
            {
                MessageBox.Show("Falha ao conectar com o Banco de Dados " + error.Message, "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
