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
    public partial class Exercicio04 : Form
    {
        
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            try
            {
                 double numero = Convert.ToDouble(tbnumero.Text);
            }
            catch (Exception )
            {

                MessageBox.Show("Comando invalido,tente com um número");
                tbnumero.Focus();
                return;
            }
            
            
            int numero01 = Convert.ToInt32(tbnumero.Text);

            for (int i = 0; i <= 10; i++)
            {
                double multiplicacao = numero01 * i;
                MessageBox.Show(numero01 + " X " + i + " = " + multiplicacao);
            }
        }
    }
}
