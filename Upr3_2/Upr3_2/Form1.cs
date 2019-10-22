using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calc()
        {
            double doo = 0, dzpo = 0, zdravni = 0, zaplata = 0;

            try
            {
                zaplata = Double.Parse(textBox1.Text);
            }
            catch
            {
                if (!(string.IsNullOrWhiteSpace(textBox1.Text)))
                {
                    MessageBox.Show("Vuvedete danni v pole \"zaplata:\"");
                    textBox1.Clear();
                }
            }

            if (radioButton1.Checked)
            {
                doo = 0.089 * zaplata;
                dzpo = 0;
                zdravni = 0.032 * zaplata;
            }
            else if (radioButton2.Checked)
            {
                doo = 0.067 * zaplata;
                dzpo = 0.022 * zaplata;
                zdravni = 0.032 * zaplata;
            }

            label7.Text = doo.ToString("0.00");
            label8.Text = dzpo.ToString("0.00");
            label9.Text = zdravni.ToString("0.00");
            label10.Text = (doo + dzpo + zdravni).ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }
    }
}
