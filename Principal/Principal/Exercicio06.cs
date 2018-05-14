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
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double validarnota1 = Convert.ToDouble(tbnota1.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbnota1.Focus();
                return;
            }
            try
            {
                double validarnota2 = Convert.ToDouble(tbnota2.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido");
                tbnota2.Focus();
                return;
            }
            try
            {
                double validarnota3 = Convert.ToDouble(tbnota3.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas Números");
                tbnota3.Focus();
                return;
            }
            try
            {
                double validarnota4 = Convert.ToDouble(tbnota4.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbnota4.Focus();
                return;
            }

            double nota01 = Convert.ToDouble(tbnota1.Text);
            double nota02 = Convert.ToDouble(tbnota2.Text);
            double nota03 = Convert.ToDouble(tbnota3.Text);
            double nota04 = Convert.ToDouble(tbnota4.Text);

            double media = (nota01 + nota02 + nota03 + nota04) / 4;
            MessageBox.Show("Média: " + media);

            if (media <= 5)
            {
                MessageBox.Show("Reprovado Brou");
            }
            else if (media < 7)
            {
                MessageBox.Show("Quaseeeeeeeeee,faltou pouco Brou Exame pena Filhão");
            }
            else 
            {
                MessageBox.Show("Passouuuu Brouuu");
            }

            

        }
    }
}
