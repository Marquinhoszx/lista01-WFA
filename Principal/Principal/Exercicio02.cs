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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void btnprosseguir_Click(object sender, EventArgs e)
        {
            try
            {
                double validarquantidadepordia = Convert.ToDouble(tbquantidadedelitrospordia.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Comando inválido,apenas números");
                tbquantidadedelitrospordia.Focus();
                return;
               
            }
            
            
            
            
            
            int quantidadelitros = Convert.ToInt32(tbquantidadedelitrospordia.Text);
            int quantidadeanos = Convert.ToInt32(tbquatidadedeanos.Text);
            double precoporlitro = Convert.ToDouble(tbvalorpolitro.Text);

            double quantidadedelitrosconsumidos = quantidadeanos * quantidadelitros * 365;
            double valorpago = quantidadedelitrosconsumidos * precoporlitro;
            MessageBox.Show("Quantidade de litros consumidos: " + quantidadedelitrosconsumidos + "\n" +
                            "Valor total: " + valorpago);
        }
    }
}
