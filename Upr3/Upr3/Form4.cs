using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textA.Clear();
            textB.Clear();
            textC.Clear();
            textD.Clear();
            textX1.Clear();
            textX2.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0, b = 0, c = 0, d = 0;
                double x1 = 0, x2 = 0;
                
                a = Double.Parse(textA.Text);
                b = Double.Parse(textB.Text);
                c = Double.Parse(textC.Text);

                if (a == 0)
                {
                    MessageBox.Show("Напишете стойност за А различна от 0!");
                    return;
                }

                d = (b * b) - (4 * a * c);

                if (d > 0)
                {
                    x1 = (((-1) * b) + (Math.Sqrt(d))) / (2 * a);
                    x2 = (((-1) * b) - (Math.Sqrt(d))) / (2 * a);


                }
                else if (d == 0)
                {
                    x1 = x2 = ((-1) * b) / (2 * a);
                }
                else
                {

                    MessageBox.Show("Дискриминантата е орицателно число!");
                }

                textX1.Text = x1.ToString();
                textX2.Text = x2.ToString();
                textD.Text = d.ToString();
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
              
            }
        }
    }
}
