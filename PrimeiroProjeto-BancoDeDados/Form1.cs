using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Para encontrar as classes de conexão do banco de dados

namespace PrimeiroProjeto_BancoDeDados
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            conexaoBD();
        }

        private void conexaoBD()
        {
            //para pegar a string automaticamente

            string stringConexao = PrimeiroProjeto_BancoDeDados.Properties.Settings.Default.stringConexao;

            try
            {
                //pera pegar a string de conexão com endereço fixo

                string conexaoFixo = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projetos C-Sharp\PrimeiroProjeto-BancoDeDados\BancoEscola.mdf;Integrated Security=True";
                SqlConnection objConexao = new SqlConnection(conexaoFixo);
                objConexao.Open();

                string comandoInserir = "insert into Alunos(Nome, Email) values ('" + textBoxNome.Text + "', '" + textBoxEmail.Text + "')";
                SqlCommand objComando = new SqlCommand(comandoInserir, objConexao);
                objComando.ExecuteNonQuery(); //usado para inserir, alterar, excluir

                MessageBox.Show("Cadastrado com Sucesso!","Conexão com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.alunosTableAdapter.Fill(this.bancoEscolaDataSet.Alunos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Falha ao conectar com o Banco de Dados " + error.Message, "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //PRECISAMOS NOS CONECTAR A UM BANCO - para qualquer ação com banco
            try
            {
                listBoxConsulta.Items.Clear();
                comboBoxConsulta.Items.Clear();

                string conexaBD = PrimeiroProjeto_BancoDeDados.Properties.Settings.Default.stringConexao;
                SqlConnection objConexaoBD = new SqlConnection(conexaBD);
                objConexaoBD.Open();

                string consultar = "select * from Alunos ";
                SqlCommand objConsultar = new SqlCommand(consultar, objConexaoBD);
                SqlDataReader objMostrarConsulta = objConsultar.ExecuteReader(); //Serve para guardar o conteudo

                //objMostrarConsulta.Read(); //lê uma linha- um registro por vez

                while (objMostrarConsulta.Read() == true)
                {
                    string registro = objMostrarConsulta["RA"].ToString() + " " + objMostrarConsulta["Nome"].ToString() + " " + objMostrarConsulta["Email"].ToString();
                    listBoxConsulta.Items.Add(registro);
                    comboBoxConsulta.Items.Add(registro);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Falha ao conectar com o Banco de Dados " + error.Message, "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoEscolaDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.bancoEscolaDataSet.Alunos);

        }
    }
}
 