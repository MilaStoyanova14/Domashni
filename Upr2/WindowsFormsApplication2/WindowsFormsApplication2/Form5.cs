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
	public partial class Form5 : Form
	{
		static public int cl_id = 0;
		static public double sp = 0;
		static public double np = 0;
		static public double p = 0;
		static public double sum = 0;
		static public int radio_checked = 1;

		public Form5(int clientt_id = 0, double staro_p = 0, double novo_p = 0, double potrebl = 0, double result = 0, int radio_ch = 1)
		{
			cl_id = clientt_id;
			sp = staro_p;
			np = novo_p;
			p = potrebl;
			sum = result;
			radio_checked = radio_ch;

			InitializeComponent();

		}

		private void Form5_Load(object sender, EventArgs e)
		{
			try
			{
				client_id.Text = cl_id.ToString();
				textBox1.Text = sp.ToString();
				textBox2.Text = np.ToString();
				potreblenie.Text = p.ToString();
				res.Text = sum.ToString();

				switch (radio_checked)
				{
					case 2:
						radio44.Checked = true;
						break;
					case 3:
						radio54.Checked = true;
						break;
					default:
						radio34.Checked = true;
						break;
				}

			}
			catch {
				MessageBox.Show("Въведете коректни данни!");
			}
		}
	}
}
