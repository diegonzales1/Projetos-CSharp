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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BicicleteriaA objFormMenu = new BicicleteriaA();
            objFormMenu.ShowDialog();
        }//Entra no Formulario da Bicicleta1

        private void button2_Click(object sender, EventArgs e)
        {
            ConcessionariaB objFormMenu = new ConcessionariaB();
            objFormMenu.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
