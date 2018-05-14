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
    public partial class Exercicio08 : Form
    {
        public Exercicio08()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valorcontadaluz = Convert.ToDouble(tbcontadeluz.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbcontadeluz.Focus();
                return;
            }
            try
            {
                double valorcontadeagua = Convert.ToDouble(tbcontadaagua.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbcontadaagua.Focus();
                return;
            }
            try
            {
                double valordanet = Convert.ToDouble(tbvalornet.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbvalornet.Focus();
                return;
            }
            try
            {
                double valordavivo = Convert.ToDouble(tbvalorvivo.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbvalorvivo.Focus();
                return;
            }
            try
            {
                double valordaOI = Convert.ToDouble(tbvaloroi.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbvaloroi.Focus();
                return;
            }
            try
            {
                double ValordoIPTU = Convert.ToDouble(tbvalorIPTU.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbvalorIPTU.Focus();
                return;
            }
            try
            {
                double valordoIPVA = Convert.ToDouble(tbvalorIPVA.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbvalorIPVA.Focus();
                return;
            }
            try
            {
                double valorsegurodocarro = Convert.ToDouble(tbvalorsegurocarro.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbvalorsegurocarro.Focus();
                return;

            }

            double luz = Convert.ToDouble(tbcontadeluz.Text);
            double agua = Convert.ToDouble(tbcontadaagua.Text);
            double valornet = Convert.ToDouble(tbvalornet.Text);
            double valorvivo = Convert.ToDouble(tbvalorvivo.Text);
            double valorOi = Convert.ToDouble(tbvaloroi.Text);
            double valorIPTU = Convert.ToDouble(tbvalorIPTU.Text);
            double valorIPVA = Convert.ToDouble(tbvalorIPVA.Text);
            double valorsegurocarro = Convert.ToDouble(tbvalorsegurocarro.Text);

            double contasdetelefone = valorOi + valorvivo;
            double contasdosimpostos = valorIPVA + valorIPTU;
            double resto = valornet + luz + agua + valornet + valorsegurocarro;
            double total = contasdetelefone + contasdosimpostos + resto;

            MessageBox.Show("Conta do telefone: " + contasdetelefone + "\r" +
                            "Conta dos impostos: " + contasdosimpostos + "\r" +
                            "Valor do resto: " + resto + "\r" +
                            "Valor total: " + total);



        }




    }
}
