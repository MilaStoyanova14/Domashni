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
    public partial class Form3 : Form
    {
		double[,] arr = new double[4, 4];
        public Form3()
        {
            InitializeComponent();
        }

		private void Form3_Load(object sender, EventArgs e)
		{
			refresh();

			arr[0, 0] = 1;
			arr[0, 1] = 0.3333;
			arr[0, 2] = 1.1989;
			arr[0, 3] = 0.0001893;
			arr[1, 0] = 3;
			arr[1, 1] = 1;
			arr[1, 2] = 3.5966;
			arr[1, 3] = 0.0005682;
			arr[2, 0] = 0.8341;
			arr[2, 1] = 0.278;
			arr[2, 2] = 1;
			arr[2, 3] = 0.0001579;
			arr[3, 0] = 5280;
			arr[3, 1] = 1760;
			arr[3, 2] = 6330;
			arr[3, 3] = 1;
		}

		void calc() {
			try
			{
				string combo1 = comboBox1.Text;
				string combo2 = comboBox2.Text;
				double number = Double.Parse(num.Text);

				double result = number * arr[comboBox1.SelectedIndex, comboBox2.SelectedIndex];

				res.Text = result.ToString();
			}
			catch
			{
				MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
				refresh();


			}
		
		}

		private void num_TextChanged(object sender, EventArgs e)
		{
			if (num.Text != "" && Int32.Parse(num.Text) != 0)
			{
				calc();
			}

		}

		private void Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Refresh_Click(object sender, EventArgs e)
		{
			refresh();
		}

		void refresh() {
			num.Text = 0.ToString(); 
			res.Clear();
			comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 0;
		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (num.Text != "" && Int32.Parse(num.Text) != 0)
			{
				calc();
			}
		}

		private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (num.Text != "" && Int32.Parse(num.Text) != 0)
			{
				calc();
			}
		}



    }
}
