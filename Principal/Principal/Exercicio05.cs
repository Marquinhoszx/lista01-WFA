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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                string nomecarro = tbnomecarro.Text;
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas palavras");
                tbnomecarro.Focus();
                return;
            }
            try
            {
                double valorcarro = Convert.ToDouble(tbvalorcarro.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas palavras");
                tbvalorcarro.Focus();
                return;
            }
            try
            {
                int valorparcela = Convert.ToInt32(tbvalorparcela.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas palavras");
                tbvalorparcela.Focus();
                return;
            }
            try
            {
                double financiadocarro = Convert.ToDouble(tbquantidadedevezesqueocarrofoifinanciado.Text);
            }
            catch
            {
                MessageBox.Show("Comando inválido,apenas palavras");
                tbquantidadedevezesqueocarrofoifinanciado.Focus();
                return;
            }
            string nomedocarro = tbnomecarro.Text;
            double valordocarro = Convert.ToDouble(tbvalorcarro.Text);
            int valordecadaparcela = Convert.ToInt32(tbvalorparcela.Text);
            double financiado = Convert.ToDouble(tbquantidadedevezesqueocarrofoifinanciado.Text);

            double valortotalfinanciamento = valordecadaparcela * financiado;
            double diferenca = valordocarro - valortotalfinanciamento;
            
            
            MessageBox.Show("Nome do carro: " + nomedocarro + "\r" +
                            "Valor do carro: " + valordocarro + "\r" +
                            "Valor de cada parcela: " + valordecadaparcela + "\r" +
                            "Quantidade das parcelas: " + financiado + "\r" +
                            "Valor total do financiado: " + valortotalfinanciamento + "\r" +
                            "Difrença entre valor total e valor do carro: " + diferenca);
            if (diferenca < 0)
            {
                MessageBox.Show("OBS:Valor do carro é mais barato");
            }
            else if (diferenca == 0)
            {
                MessageBox.Show("OBS:Valor do carro é igual");
            }
            else
            {
                MessageBox.Show("OBS:Valor do carro é mais caro");
            }
        }
    }
}
