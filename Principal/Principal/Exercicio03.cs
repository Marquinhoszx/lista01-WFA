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
    public partial class Exercicio03 : Form
    {
      
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void btncGo_Click(object sender, EventArgs e)
        {
            double numero01 = Convert.ToDouble(tbnumero1.Text);
            double numero02 = Convert.ToDouble(tbnumero2.Text);
            double subtracao = numero01 - numero02;
            double dividir = numero01 / numero02;
            double multiplicar = numero01 * numero02;
            

            double soma = numero01 + numero02;
            MessageBox.Show("A soma dos numeros é: " + soma + "\n" +
                            "A diferenca entre os números é: " + subtracao + "\n" + 
                            "A divisão entre os número é: " + dividir + "\n" + 
                            "A multiplicação entreo os números é: " + multiplicar);
        }

       
        

       
    }
}
