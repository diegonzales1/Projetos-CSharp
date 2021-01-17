using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeExercicios
{
    public partial class BicicleteriaA : Form
    {
        public BicicleteriaA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Commission() //Calcula comissão e o lucro da loja
        {
            try
            {
                textBoxName.Focus();
                float priceProduct = float.Parse(textBoxPriceProduct.Text);
                double profit = (0.10 * priceProduct) + priceProduct;
                int quantity = int.Parse(textBoxQuantity.Text);
                double commission = quantity * (priceProduct * 0.015);
                float salary = float.Parse(textBoxMinimumWage.Text);
                double commissionSalary = (salary + salary) + commission;
                double netProfit = (profit * quantity) - commissionSalary;
                
                labelSalary.Text = commissionSalary.ToString();
                labelProfit.Text = netProfit.ToString();
            }
            catch
            {
                MessageBox.Show("ERRO", "ERROR");
            }
        }

        private void buttonFinalizaSale_Click(object sender, EventArgs e)
        {
            labelSalary.Text = "__________________";
            labelProfit.Text = "__________________";

            textBoxName.Clear();
            textBoxMinimumWage.Clear();
            textBoxPriceProduct.Clear();
            textBoxQuantity.Clear();
            textBoxName.Focus();
        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            Commission();
        }

        private void Bicicleteria1_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
        }
    }
}
