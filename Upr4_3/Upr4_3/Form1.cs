using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr4_3
{
    public partial class Form1 : Form
    {
        Button button1 = new Button();
        Button button2 = new Button();
        TextBox textBox1 = new TextBox();
        TextBox textBox2 = new TextBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButton();
        }

        private void CreateButton()
        {
            button1.Size = new System.Drawing.Size(120, 30);
            button1.Location = new System.Drawing.Point(250, 10);


            button1.Text = "Create TextBox";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(this.button1_Click);
 
            button2.Size = new System.Drawing.Size(120, 30);
            button2.Location = new System.Drawing.Point(550, 10);


            button2.Text = "Calculate";
            this.Controls.Add(button2);
            button2.Click += new EventHandler(this.button2_Click);
        }
        
        protected void button1_Click(object sender, EventArgs e)
        {
            CreateTextBox();
        }

        
        protected void button2_Click(object sender, EventArgs e)
        {
            calcSin();
            calcRad();
        }


        private void CreateTextBox()
        {
            textBox1.Size = new System.Drawing.Size(120, 30);
            textBox1.Location = new System.Drawing.Point(250, 50);
      
            this.Controls.Add(textBox1);

            textBox2.Size = new System.Drawing.Size(120, 30);
            textBox2.Location = new System.Drawing.Point(550, 50);

         
            this.Controls.Add(textBox2);
        }

        void calcSin() {
            try
            {
                double num = Double.Parse(textBox1.Text);
                if (num <= 360 && num >= -360)
                {
                    string msg = "Тригонометрични функции: \n";
                    msg += "sin " + num + ": " + Math.Round(Math.Sin(num),3).ToString() + "\n";
                    msg += "cos " + num + ": " + Math.Round(Math.Cos(num),3).ToString() + "\n";
                    msg += "tan " + num + ": " + Math.Round(Math.Tan(num),3).ToString() + "\n";

                    MessageBox.Show(msg);
                }
                else {
                    MessageBox.Show("Въведете коректни данни за първото поле! [-360:360]");
                }
            }
            catch {
                MessageBox.Show("Въведете коректни данни за първото поле! [-360:360]");
            }
        }

        void calcRad() {
            double num = Double.Parse(textBox2.Text);
            try
            {
                if (num > 0 && num < 11)
                {
                    string msg = "S и P на окръжност: \n";
                    msg += "S: " + Math.Round(num*num*Math.PI, 2).ToString() + "\n";
                    msg += "P: " + Math.Round(2* Math.PI * num, 2).ToString() + "\n";

                    MessageBox.Show(msg);
                }
                else {
                    MessageBox.Show("Въведете коректни данни за второто поле![1-10]");
                }
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни за второто поле![1-10]");
            }
        }
    }
}
