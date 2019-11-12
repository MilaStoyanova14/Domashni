using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "The average temperature for the week was: ";
            button1.Text = "Temperature";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            string[] days = { "Sunday", "Monday", "TuesDay", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string day in days)
            {
                double temperatura = (double.Parse(Interaction.InputBox("The temperature in " + day + " is: ")));
                listBox1.Items.Add(temperatura + " degrees Celsius \nwas the temperature " + day);
                sum = sum + temperatura;
            }
            sum = sum / 7;
            listBox1.Sorted = true;
            label1.Text = label1.Text + string.Format("{0:0.##}", (sum)) + " degrees centigrade."
                + "\nThe minimum temperature = " + string.Format("{0:0.##}", listBox1.Items[0].ToString())
                + "\nThe maximum temperature = " + string.Format("{0:0.##}", listBox1.Items[6].ToString());
        }


    }
}
