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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			MessageBox.Show("\t  Hello students! \n \n \t \t THIS is your FIRST C# PROGRAM ... \n \n \t \t \t Be Happy! :))))))))))");
        
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackColor = Color.Black;
			// this.BackColor = Color.FromArgb(0, 0, 0);
			label1.Text = "Click one of the buttons bellow \n to see the magic working...";
			label1.Font = new Font("Arial", 14);
			label1.ForeColor = Color.White;

		}

		private void ChangeFormColor(object sender, EventArgs e)
		{
			if (sender is Button)
			{
				this.BackColor = (sender as Button).BackColor;
				this.Text = sender.ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Red;
			//this.BackColor = Color.FromArgb(204, 0, 0);
			ChangeFormColor(sender, e); 

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Blue;
			//this.BackColor = Color.FromArgb(0, 102, 204);
			ChangeFormColor(sender, e); 

		}

		private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Show();
		}



	}
}
