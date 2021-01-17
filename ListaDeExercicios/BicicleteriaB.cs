using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace ListaDeExercicios
{
    public partial class ConcessionariaB : Form
    {
        public ConcessionariaB()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja fechar?", "Desejar sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }//FIM COD SAIR

        private void buttonPagamento_Click(object sender, EventArgs e)
        {
            doTheMath();
        }//FIM DO COD PAGAMENTO

        private void buttonCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start("Calc");
        }//FIM DO COD QUE ABRE CALCULADORA

        private void textBoxValorUnitario_TextChanged(object sender, EventArgs e)
        {
            groupBoxFormaPagamento.Visible = true;
        }//FIM DO COD QUE ATIVA GROUPBOX

        private void checkText()
        {
            if (textBoxCode.Text == "" && textBoxQuantity.Text == "" && textBoxUnitaryValue.Text == "")
            {
                MessageBox.Show("Caixas vazias", "ERROR");
                textBoxCode.Focus();
            }
            else
            {
                if (textBoxCode.Text == "")
                {
                    MessageBox.Show("Caixa de código vazia", "ERRO");
                    textBoxCode.Focus();
                }
                else if (textBoxQuantity.Text == "")
                {
                    MessageBox.Show("Caixa de quantidade vazia", "ERRO");
                    textBoxQuantity.Focus();
                }
                else if (textBoxUnitaryValue.Text == "")
                {
                    MessageBox.Show("Caixa de valor unitário vazia", "ERRO");
                    textBoxUnitaryValue.Focus();
                }
            }//fim do else
        }//fim da função conferetexto

        private void doTheMath()
        {
            try
            {
                byte quant = byte.Parse(textBoxQuantity.Text);
                float unitaryValue = float.Parse(textBoxUnitaryValue.Text);

                if (radioButtonInCash.Checked == true)
                {
                  float totalInCash = (quant * unitaryValue) * 0.95f;
                   textBoxTotalCash.Text = totalInCash.ToString();

                }
                else if (radioButtonCard.Checked == true)
                {
                  float totalCard = (quant * unitaryValue) * 1.30f;
                   textBoxTotalCard.Text = totalCard.ToString();

                } 
            }
            catch
            {
                checkText();
            }
        }
    }
}
