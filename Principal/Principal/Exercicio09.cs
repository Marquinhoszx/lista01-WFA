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
    public partial class Exercicio09 : Form
    {
        public Exercicio09()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numero01 = Convert.ToDouble(tbnumero1.Text);
            }
            catch
            {
                MessageBox.Show("Apenas números brouuu");
                tbnumero1.Focus();
                return;
            }
            try
            {
                double numero02 = Convert.ToDouble(tbnumero2.Text);
            }
            catch
            {
                MessageBox.Show("Apenas números brouuu");
                tbnumero2.Focus();
                return;
            }

            MessageBox.Show(string.Format("Número 1:{0} \r  Número 2: {1}", Convert.ToDouble(tbnumero2.Text), Convert.ToDouble(tbnumero1.Text)));

            
            

            
        }
    }
}
