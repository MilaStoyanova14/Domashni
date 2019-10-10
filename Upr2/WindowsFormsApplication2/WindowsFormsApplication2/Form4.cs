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
	public partial class Form4 : Form
	{
		static public int cl_id = 0;
		static public double staro_p = 0;
		static public double novo_p = 0;
		static public double potrebl = 0;
		static public double result = 0;
		static public int radio_checked = 1;

		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			addClient();
		}

		void calc()
		{
			try
			{
				if (textBox1.Text != "" && textBox2.Text != "")
				{
					string radio_btn;
					staro_p = Double.Parse(textBox1.Text);
					novo_p = Double.Parse(textBox2.Text);
					//if(sp != 0 && np != 0){
					potrebl = novo_p - staro_p;
					potreblenie.Text = potrebl.ToString();

						radio_btn = radio34.Text;
						radio_checked = 1;

						if (radio44.Checked)
						{
							radio_btn = radio44.Text;
							radio_checked = 2;
						}

						if (radio54.Checked)
						{
							radio_btn = radio54.Text;
							radio_checked = 3;
						}

						result = potrebl * Double.Parse(radio_btn);

						res.Text = result.ToString();

						res.Show();
						potreblenie.Show();
					//}

				}

			}
			catch
			{
				MessageBox.Show("Въведете коректни данни!");
				//refresh();


			}

		}
		
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form5 frm = new Form5(cl_id,staro_p,novo_p,potrebl,result,radio_checked);
			frm.Show();
		}

		private void radio34_CheckedChanged(object sender, EventArgs e)
		{
			calc();
		}

		private void radio44_CheckedChanged(object sender, EventArgs e)
		{
			calc();
		}

		private void radio54_CheckedChanged(object sender, EventArgs e)
		{
			calc();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			calc();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			calc();
		}

		private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addClient();
		}

		void addClient() {
			cl_id++;
			client_id.Text = cl_id.ToString();
			client_id.Show();
			refresh();
		}

		void refresh() {
			radio34.Checked = true;
			textBox1.Clear();
			textBox2.Clear();
			potreblenie.Hide();
			res.Hide();
		}




	}
}
