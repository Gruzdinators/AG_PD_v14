using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AG_PD_v14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void poga_Click(object sender, EventArgs e)
        {
            int t_nauda = Convert.ToInt32(Math.Round(tnauda.Value, 0));
            int t_cena = Convert.ToInt32(Math.Round(cena.Value, 0));
            int t_cena2 = Convert.ToInt32(Math.Round(cena2.Value, 0));
            int t_cena3 = Convert.ToInt32(Math.Round(cena3.Value, 0));
            int t_daudz = Convert.ToInt32(Math.Round(daudzums.Value, 0));
            int t_daudz2 = Convert.ToInt32(Math.Round(daudzums2.Value, 0));
            int t_daudz3 = Convert.ToInt32(Math.Round(daudzums3.Value, 0));

            int maks = t_nauda;
            

            string message = "Tavā makā tukšums skan";
            string title = "Maks dzied:";
            
            int KopSumma = (t_daudz * t_cena) + (t_daudz2 * t_cena2) + (t_daudz3 * t_cena3);
            if (KopSumma > t_nauda)
            {
                MessageBox.Show("Jums naudas par maz! Ejiet griezt aparātus!");
            }
            else
            {

             

                tsumma.Text = KopSumma.ToString();


                while (KopSumma < 0)
                {
                    MessageBox.Show(message, title);
                }


            }

        }        
    }
}
