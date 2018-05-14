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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            try
            {
                int dia = Convert.ToInt32(tbdia.Text);
            }
            catch
            {
                MessageBox.Show("Brouuuuuuu,Apenas números meu bom");
                tbdia.Focus();
                return;
            }
            try
            {
                int mes = Convert.ToInt32(tbmes.Text);
            }
            catch
            {
                MessageBox.Show("Brouuuuuuu,Apenas números meu bom");
                tbmes.Focus();
                return;
            }
            try
            {
                int ano = Convert.ToInt32(tbano.Text);
            }
            catch
            {
                MessageBox.Show("Brouuuuuuu,Apenas números meu bom");
                tbano.Focus();
                return;
            }

            int diadenascimento = Convert.ToInt32(tbdia.Text);
            int mesdenascimento = Convert.ToInt32(tbmes.Text);
            int anodenascimento = Convert.ToInt32(tbano.Text);



            int idade = 2018 - anodenascimento;

            int diasvivos = idade * 365;
            int mesesvivios = idade * 12;
            int horasvivos = idade * 8760;
            int minutosvivos = idade * 525600;
            int segundosvivos = idade * 31557600;
            MessageBox.Show("Dias vivos: " + diasvivos + "\r" +
                            "Meses vivos: " + mesesvivios + "\r" +
                            "Horas vivos: " + horasvivos + "\r" +
                            "Minutos vivos: " + minutosvivos + "\r" +
                            "Segundos vivos: " + segundosvivos + "\r" +
                            "Anos vivos: " + idade);   


            if (diadenascimento < 0)
            {
                MessageBox.Show("HAha se acha o engraçadinho?,pois não é xD");
            }
            else if (diadenascimento > 32)
            {
                MessageBox.Show("Brou,não tem dia" + diadenascimento + " no nosso calendário");
            }


            if (mesdenascimento < 0)
            {
                MessageBox.Show("HAha se acha o engraçadinho?,pois não é xD");
            }
            else if (mesdenascimento > 32)
            {
                MessageBox.Show("Brou,não tem mês " + mesdenascimento + " no nosso calendário");
            }


            if (anodenascimento < 0)
            {
                MessageBox.Show("HAha se acha o engraçadinho?,pois não é xD");
            }
            else if (diadenascimento >= 2019)
            {
                MessageBox.Show("Você não é nem nascido brou");
            }
        }
    }
}
