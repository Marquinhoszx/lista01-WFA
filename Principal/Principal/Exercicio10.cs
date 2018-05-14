using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double anonascimento = Convert.ToDouble(tbano.Text);
            }
            catch
            {
                MessageBox.Show("Filhão é apenas número Brouuuu");
                tbano.Focus();
                return;
            }

            double anodenascimento = Convert.ToDouble(tbano.Text);
            double idade = 2018 - anodenascimento;

            MessageBox.Show("Brou,Sua idade é: " + idade);

            if (anodenascimento >= 2019)
            {
                MessageBox.Show("HAHA se acha o engraçadinho,você não é nem nascido brou");
            }
            else if (anodenascimento < 0)
            {
                MessageBox.Show("Você,você mexsmu se acha engraçadinho? é uma pena que não é verdade Sr Usuário");
            }




        }
    }
}
