using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr3_5
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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int p;
            var labels = new List<Label> { label1, label2, label3, label4, label5, label6 };

            foreach (var label in labels)
            {
                p = rand.Next(49) + 1;
                label.Text = p.ToString();
            }
        }
    }
}
