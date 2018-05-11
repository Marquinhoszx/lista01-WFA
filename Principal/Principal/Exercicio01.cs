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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numero01 = Convert.ToDouble(tbnumero.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Comando invalido,tente com um número");
                tbnumero.Focus();
                return;

                
            }
            
            
            
            
            int numero = Convert.ToInt32(tbnumero.Text);
            int sucessor = numero + 1;
            int antecessor = numero - 1;

            MessageBox.Show("sucessor: " + sucessor + "\n"+
                            "Antecessor: " + antecessor);
            
        }
    }
}
