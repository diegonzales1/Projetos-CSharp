using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics; 

namespace ClaytonFelipe_DiegoGonzales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexaoBD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("Calc");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxNomePaciente.Clear();
            textBoxNomePaciente.Focus();
            textBoxQuantidade.Clear();
            labelValor.Text = "________";
            radioButtonCanal.Checked = true;

        }

        private void conexaoBD()
        {
            try
            {
                string conexaoFixo = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projetos C-Sharp\Projetos-CSharp\ClaytonFelipe-DiegoGonzales\BD_AVALIACAO.mdf;Integrated Security=True";
                SqlConnection objConexao = new SqlConnection(conexaoFixo);
                objConexao.Open();

                string comandoInserir = "INSERT INTO Paciente (nome) VALUES ('" + textBoxNomePaciente.Text + "')";
                SqlCommand objComando = new SqlCommand(comandoInserir, objConexao);
                objComando.ExecuteNonQuery();

                MessageBox.Show("Paciente Cadastrado com Sucesso", "Conexão Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Falha na conexão, " + error.Message, "ERRORRR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string nomeFazer;

        private void analisaRadio()
        {
            double calc;

            try
            {
                if (radioButtonCanal.Checked == true)
                {
                    nomeFazer = "Canal";
                    calc = Convert.ToDouble(textBoxQuantidade.Text) * 400;
                    labelValor.Text = calc.ToString();
                }
                else
                {
                    nomeFazer = "Obturação";
                    calc = Convert.ToDouble(textBoxQuantidade.Text) * 100;
                    labelValor.Text = calc.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(" " + error.Message, "ERRORRR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emiteRecibo()
        {
            analisaRadio();
            try
            {
                StreamWriter Recibo = new StreamWriter("Recibo.doc", true);

                Recibo.WriteLine("               Recibo de Compra                   ");
                Recibo.WriteLine("Data da Compra: " + DateTime.Now);
                Recibo.WriteLine("Recebemos do sr(a) " + textBoxNomePaciente.Text);
                Recibo.WriteLine("O valor de R$" + labelValor.Text);
                Recibo.WriteLine("Referente ao tratamento de " + nomeFazer);
                Recibo.WriteLine(" ");
                Recibo.WriteLine(" ");

                MessageBox.Show("Recibo Gerado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Recibo.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Falha ao emitir o recibo, " + error.Message, "ERRORRR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxNomePaciente.Text == "" || textBoxQuantidade.Text == "")
            {
                MessageBox.Show("Campo vazio");
            }
            else
            {
                emiteRecibo();
            }
        }
    }
}
