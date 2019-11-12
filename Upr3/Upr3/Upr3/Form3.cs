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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textA.Clear();
            textB.Clear();
            textRes.Clear();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            try{
               double a = Double.Parse(textA.Text);
                double b = Double.Parse(textB.Text);
                double z = a * a + 2 * a * b + b * b;
                
                if (radioButton2.Checked)
                {
                    z = a * a - 2 * a * b + b * b;
                }
                else if (radioButton3.Checked)
                {
                    z = a * a - b * b;
                }
                else if (radioButton4.Checked)
                {
                    z = Math.Pow(a, 3) + 3 * a * a * b + 3 * a * b * b + Math.Pow(b, 3);
                }
                else if (radioButton5.Checked)
                {
                    z = Math.Pow(a, 3) - 3 * a * a * b + 3 * a * b * b - Math.Pow(b, 3);
                }
                else if (radioButton6.Checked)
                {
                    z = (a+b)*(a*a-a*b+b*b);
                }
                else if (radioButton7.Checked)
                {
                    z = (a - b) * (a * a + a * b + b * b);
                }
                
                textRes.Text = z.ToString();
            }
            catch{
                 MessageBox.Show("Моля въведете данни за А и B!");
            }
            
        }
    }
}
