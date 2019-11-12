using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr3_6
{
    public partial class Form1 : Form
    {

        static public int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) <= 100)
            {

                int guess = Int32.Parse(textBox1.Text);
                if (guess < n)
                {
                    MessageBox.Show("Числото е по-голямо от:  " + guess);
                }
                else if (guess > n)
                {
                    MessageBox.Show("Числото е по-малко от:  " + guess);
                }
                else {
                    MessageBox.Show("Познахте! Числото е: " + n);
                    generateRndNum();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateRndNum();


        }

        void generateRndNum() {
            Random random = new Random();
            n = random.Next(1, 100);
        }
    }
}
