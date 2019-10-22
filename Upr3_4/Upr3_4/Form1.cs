using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentM = DateTime.Today.Month;
            int currentY = DateTime.Today.Year;

            int month = Int32.Parse(textBox2.Text);
            int day = Int32.Parse(textBox3.Text);
            int year = Int32.Parse(textBox4.Text);

            int diffM = currentM - month;
            int diffY = currentY - year;

            if (diffM < 0)
            {
                diffY--;
                diffM = 12 + diffM;
            }

            MessageBox.Show("" + diffY + " years and " + diffM + " months");
        }
    }
}
