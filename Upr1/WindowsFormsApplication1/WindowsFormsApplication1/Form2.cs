using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private double doMath(double val1, double val2, string method)
		{
			double z = 0;
			string err_msg = "Въведете коректни данни, преди да натиснете бутона!";
			try
			{
				switch (method)
				{
					case "add":
						z = val1 + val2;
						break;

					case "minus":
						z = val1 - val2;
						break;

					case "umnj":
						z = val1 * val2;
						break;

					case "sub":
						if (val2 != 0)
						{
							z = val1 / val2;
						}
						else {
							MessageBox.Show(err_msg);
							textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
						}
						break;

					default:
						z = val1 + val2;
						break;

				}
				
			}
			catch
			{
				MessageBox.Show(err_msg);
				textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
			}

			return z;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double val1, val2; //Декларираме 2 променливи от тип double type
			val1 = Double.Parse(textBox1.Text);
			val2 = Double.Parse(textBox2.Text);

			double z = doMath(val1, val2, "add");

			textBox3.Text = z.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double val1, val2; //Декларираме 2 променливи от тип double type
			val1 = Double.Parse(textBox1.Text);
			val2 = Double.Parse(textBox2.Text);

			double z = doMath(val1, val2, "minus");

			textBox3.Text = z.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			double val1, val2; //Декларираме 2 променливи от тип double type
			val1 = Double.Parse(textBox1.Text);
			val2 = Double.Parse(textBox2.Text);

			double z = doMath(val1, val2, "umnj");

			textBox3.Text = z.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			double val1, val2; //Декларираме 2 променливи от тип double type
			val1 = Double.Parse(textBox1.Text);
			val2 = Double.Parse(textBox2.Text);

			double z = doMath(val1, val2, "sub");

			textBox3.Text = z.ToString();
		}
	}
}
