using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0, b = 0, c = 0, d = 0;
                double x1 = 0, x2 = 0;
                a = Double.Parse(A.Text);
                b = Double.Parse(B.Text);
                c = Double.Parse(C.Text);

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

                X1.Text = x1.ToString();
                X2.Text = x2.ToString();
            }
            catch {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                A.Clear(); B.Clear(); C.Clear();
                X1.Clear(); X2.Clear();

            }

          
        }

        private void tempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void metricStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

		private void electricBillToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form4 frm = new Form4();
			frm.Show();
		}


    }
}
