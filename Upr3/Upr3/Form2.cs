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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            textA.Clear();
            textN.Clear();
            textRes.Clear();

        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(textA.Text);
                double n = Double.Parse(textN.Text);
                double z = Math.Pow(a, n);

                textRes.Text = z.ToString();
            }
            catch {
                MessageBox.Show("Моля въведете данни за А и N!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
