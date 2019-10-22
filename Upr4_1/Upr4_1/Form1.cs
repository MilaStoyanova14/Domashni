using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  

        private void button_pal_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            if (s != "")
            {
                
                s = s.ToUpper();
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                string new_s = new string(arr);
                int i = s.CompareTo(new_s);
                if (i == 0)
                {
                    MessageBox.Show("Палиндром е!");
                }
                else MessageBox.Show("НЕ е Палиндром!");
            }
            else {
                    MessageBox.Show("Моля въведете нещо в полето!");
                }
            
        }

        private void button_ascii_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            if (s != "")
            {

                String msg = "";
                foreach (char val in s)
                {
                    msg += val.ToString() + " = " + ((int)val).ToString() + " \n";

                }

                MessageBox.Show(msg);
            }
            else {
                MessageBox.Show("Моля въведете нещо в полето!");
            }

        }
    }
}
