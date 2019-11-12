using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Setstr = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Setstr = textBox1.Text;
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show(); 


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Copy text" + "\n" + "from Form1.TextBox1" + "\n" + "to Form2.Lable1"; 
        }
    }
}
