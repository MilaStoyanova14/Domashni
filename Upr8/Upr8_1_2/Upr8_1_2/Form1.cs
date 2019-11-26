using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr8_1_2
{
    public partial class Form1 : Form
    {
        public bool inputstatus;
        public string no1, constfun;
       

        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true; 
            textBox1.RightToLeft = RightToLeft.Yes;
            radioButton1.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button1.Text;
            }
            else
            {
                textBox1.Text = button1.Text;
                inputstatus = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button2.Text;
            }
            else
            {
                textBox1.Text = button2.Text;
                inputstatus = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button3.Text;
            }
            else
            {
                textBox1.Text = button3.Text;
                inputstatus = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button4.Text;
            }
            else
            {
                textBox1.Text = button4.Text;
                inputstatus = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button5.Text;
            }
            else
            {
                textBox1.Text = button5.Text;
                inputstatus = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button6.Text;
            }
            else
            {
                textBox1.Text = button6.Text;
                inputstatus = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button7.Text;
            }
            else
            {
                textBox1.Text = button7.Text;
                inputstatus = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button8.Text;
            }
            else
            {
                textBox1.Text = button8.Text;
                inputstatus = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button9.Text;
            }
            else
            {
                textBox1.Text = button9.Text;
                inputstatus = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button10.Text;
            }
            else
            {
                textBox1.Text = button10.Text;
                inputstatus = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            inputstatus = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            no1 = "";
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "+"; 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "-"; 
        }

        private void button14_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "*"; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "/";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(-Convert.ToInt32(textBox1.Text));
            inputstatus = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {

            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "x^y";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button9.Text;
            }
            else
            {
                textBox1.Text = "0" + button9.Text;
                inputstatus = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "mod"; 
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int var1 = 1;
            for (int i = 1; i <= Convert.ToInt16(textBox1.Text); i++)
            {
                var1 = var1 * i;
            }
            textBox1.Text = Convert.ToString(var1);
            inputstatus = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            inputstatus = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text));
            inputstatus = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text));
            inputstatus = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            funcal(); 
            inputstatus = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            textBox1.Text = (no1.Substring(0, n - 1)); 
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(textBox1.Text)));
            inputstatus = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text)));
            inputstatus = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "nPr";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "nCr";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Atan(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Atan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Acos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
{
                textBox1.Text = Convert.ToString(System.Math.Asin(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
{
                textBox1.Text = Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
           
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
          
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
      
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592654";
        }

        private void funcal()
        {
            switch (constfun)
            {
                case "+":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) + Convert.ToInt32(textBox1.Text)); 
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) - Convert.ToInt32(textBox1.Text));

                    break;
                case "*":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) * Convert.ToInt32(textBox1.Text));
                    break;
                case "/":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "infinity";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToInt32(no1) / Convert.ToInt32(textBox1.Text));
                    }
                    break;
                case "x^y":
                    textBox1.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(no1), Convert.ToDouble(textBox1.Text)));
                    break;
                case "mod":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(no1) % Convert.ToDouble(textBox1.Text));
                    break;
                case "nPr":
                    int varn, var2, var3; 
                    varn = factorial(Convert.ToInt32(no1)); 
                    var2 = factorial(Convert.ToInt32(no1) - Convert.ToInt32(textBox1.Text));
                    textBox1.Text = Convert.ToString(varn / var2); 
                    break;
                case "nCr":
                    varn = factorial(Convert.ToInt32(no1));
                    var2 = factorial(Convert.ToInt32(no1) - Convert.ToInt32(textBox1.Text));
                    var3 = factorial(Convert.ToInt32(textBox1.Text));
                    textBox1.Text = Convert.ToString(varn / (var3 * var2));
                    break;



            }
            int factorial(int x)
            {
                int i = 1; 
                for (int s = 1; s <= x; s++)
                {
                    i = i * s;
                }
                return i;
            }
        }
    }


}
