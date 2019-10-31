using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr5_3
{
    public partial class Scolarship : Form
    {
        static int invalidInput1 = 0;
        static int invalidInput2 = 0;
        static int invalidInput3 = 0;
        static string error_msg = "Your Fields must be at least 1 digit and greater than 0.";

        public Scolarship()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textBox3_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validateFields();

            if ((invalidInput1 == 1) && (invalidInput2 == 1) && (invalidInput3 == 1) )
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                double c = Double.Parse(textBox3.Text);
                double res = (a + b) - c;

                textBox4.Text = res.ToString();
            }
            else
            {
                if (invalidInput1 == 0 || invalidInput2 == 0 || invalidInput3 == 0)
                {
                    MessageBox.Show(error_msg);
                }
            }
        }

        public void textBox1_Validating()
        {

            if (textBox1.Text == "" || !IsNumeric(textBox1.Text) || Double.Parse(textBox1.Text) < 0)
            {
                errorProvider1.SetError(textBox1, error_msg);
                invalidInput1 = 0;

            }
            else
            {
                errorProvider1.SetError(textBox1, ""); invalidInput1 = 1;
            }
        }

        public void textBox2_Validating()
        {

            if (textBox2.Text == "" || !IsNumeric(textBox2.Text) || Double.Parse(textBox2.Text) < 0)
            {
                errorProvider1.SetError(textBox2, error_msg);
                invalidInput2 = 0;

            }
            else
            {
                errorProvider1.SetError(textBox2, ""); invalidInput2 = 1;
            }
        }

        public void textBox3_Validating()
        {

            if (textBox3.Text == "" || !IsNumeric(textBox3.Text) || Double.Parse(textBox3.Text) < 0)
            {
                errorProvider1.SetError(textBox3, error_msg);
                invalidInput3 = 0;

            }
            else
            {
                errorProvider1.SetError(textBox3, ""); invalidInput3 = 1;
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

        void validateFields()
        {
            textBox1_Validating();
            textBox2_Validating();
            textBox3_Validating();
        }
    }
}
