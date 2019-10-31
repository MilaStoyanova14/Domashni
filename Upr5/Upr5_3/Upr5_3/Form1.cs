using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int invalidInput1 = 0;
        static int invalidInput2 = 0;
        static int invalidInput3 = 0;
        static int invalidInput4 = 0;
        static int invalidInput5 = 0;
        static string error_name_msg = "You must enter a first, middle and last name in cyrillic.";
        static string error_egn_msg = "Your EGN must be at least 10 digits.";
        static string error_addr_msg = "Your address must be in cyrillic.";

        private void button1_Click(object sender, EventArgs e)
        {
            validateFields();

            if ((invalidInput1 == 1) && (invalidInput2 == 1) && (invalidInput3 == 1) && (invalidInput4 == 1) && (invalidInput5 == 1))
            {
                Scolarship form = new Scolarship();
                form.Show();
            }
            else {
                if (invalidInput1 == 0 || invalidInput2 == 0 || invalidInput3 == 0) {
                    MessageBox.Show(error_name_msg);
                }

                if (invalidInput4 == 0)
                {
                    MessageBox.Show(error_egn_msg);
                }

                if (invalidInput5 == 0)
                {
                    MessageBox.Show(error_addr_msg);
                }
            }
               


        }

        public void textBox1_Validating()
        {
            if (textBox1.Text == "" || Regex.IsMatch(textBox1.Text, @"\P{IsCyrillic}"))
            {

                errorProvider1.SetError(textBox1, error_name_msg);
                invalidInput1 = 0;

            }
            else
            {
                errorProvider1.SetError(textBox1, ""); invalidInput1 = 1;
            }
        }

        public void textBox2_Validating()
        {
            if (textBox2.Text == "" || Regex.IsMatch(textBox2.Text, @"\P{IsCyrillic}")) //&& 
            {

                errorProvider1.SetError(textBox2, error_name_msg);
                invalidInput2 = 0;

            }
            else
            {
                errorProvider1.SetError(textBox2, ""); invalidInput2 = 1;
            }
        }

        public void textBox3_Validating()
        {
            if (textBox3.Text == "" || Regex.IsMatch(textBox3.Text, @"\P{IsCyrillic}")) //&& 
            {
                errorProvider1.SetError(textBox3, error_name_msg);
                invalidInput3 = 0;

            }
            else
            {
                errorProvider1.SetError(textBox3, ""); invalidInput3 = 1;
            }
        }

        public void textBox4_Validating()
        {

            if (textBox4.Text == "" || !IsNumeric(textBox4.Text) || textBox4.Text.Length!=10)
            {
                errorProvider1.SetError(textBox4, error_egn_msg);
                invalidInput4 = 0;

            }
            else
            {
                errorProvider1.SetError(textBox4, ""); invalidInput4 = 1;
            }
        }

        public void textBox5_Validating()
        {

            if (richTextBox1.Text == "" || Regex.IsMatch(richTextBox1.Text, @"\P{IsCyrillic}")) //&& 
            {
                errorProvider1.SetError(textBox4, error_addr_msg);
                invalidInput5 = 0;

            }
            else
            {
                errorProvider1.SetError(textBox4, ""); invalidInput5 = 1;
            }
        }

        private void textBox4_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public static Boolean IsNumeric(string stringToTest)
        {
            int result;
            if (int.TryParse(stringToTest, out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void validateFields() {
            textBox1_Validating();
            textBox2_Validating();
            textBox3_Validating();
            textBox4_Validating();
            textBox5_Validating();
        }

    }
}
