using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr6_3
{
    public partial class Form1 : Form
    {
        static public int ControlSum;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            groupBox1.Text = "";
            radioButton1.Font.Bold.ToString();
            radioButton1.Text = "ЕГН";
            radioButton2.Font.Bold.ToString();
            radioButton2.Text = "ЛНЧ";
            radioButton3.Font.Bold.ToString();
            radioButton3.Text = "БУЛСТАТ";
            label1.Text = "Въведете";
            label2.Text = "или";
            label3.Text = "или";
            button1.Text = "Продължи";
            radioButton1.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ValidateEGN();
            }
            if (radioButton2.Checked)
            {
                ValidateLNCh();
            }
            if (radioButton3.Checked)
            {
                ValidateBultat_9();
            }

        }
        private bool ValidateBultat_9()
        {
            int l = Convert.ToInt32(textBox1.Text.Length);
            string s;
            if (IsBulstatValid_9(textBox1.Text))
            {
                return true;
            }
            else
            {
                s = "Невалиден Булстат <> от 9 ! Въвели сте " + Convert.ToString(l) + " символа!";
                MessageBox.Show(s, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }
       
        private bool IsBulstatValid_9(string aText)
        {
            if (aText.Length != 9)
            {
                return false;
            }

            for (int i = 0; i < aText.Length; i++)
            {
                if (!Char.IsDigit(aText[i]))
                {
                    return false;
                }
            }
            string rd = textBox1.Text;
            // Контролна сума на 9 знаков Булстат

            int ControlSum = Convert.ToInt32(rd.Substring(0, 1)) * 1;

            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(1, 1)) * 2;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(2, 1)) * 3;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(3, 1)) * 4;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(4, 1)) * 5;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(5, 1)) * 6;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(6, 1)) * 7;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(7, 1)) * 8;
         

            /*Аналогично за всяка следваща позиция
            .......................... (za control sum + convert: ot 1 do 9)*/
            
            int ControlDigit = Convert.ToInt32(ControlSum) % 11;

            if (aText.Length == 9)
            {
                if (ControlDigit == 10) //Проверяваме дали контролната сума е = 10
                {
                    
                    
                    ControlSum = Convert.ToInt32(rd.Substring(0, 1)) * 3;
                    ControlSum = ControlSum + Convert.ToInt32(rd.Substring(1, 1)) * 4;
                    ControlSum = ControlSum + Convert.ToInt32(rd.Substring(2, 1)) * 5;
                    ControlSum = ControlSum + Convert.ToInt32(rd.Substring(3, 1)) * 6;
                    ControlSum = ControlSum + Convert.ToInt32(rd.Substring(4, 1)) * 7;
                    ControlSum = ControlSum + Convert.ToInt32(rd.Substring(5, 1)) * 8;
                    ControlSum = ControlSum + Convert.ToInt32(rd.Substring(6, 1)) * 9;
                    ControlSum = ControlSum + Convert.ToInt32(rd.Substring(7, 1)) * 10;
                    ControlDigit = Convert.ToInt32(ControlSum) % 11;
                    {
                        if (ControlDigit == 10)
                            ControlDigit = 0;
                        else
                            MessageBox.Show("ControlDigit" + ControlDigit);
                    }

                }
                if (Convert.ToInt32(rd.Substring(8, 1)) != ControlDigit)
                    MessageBox.Show("Грешна контролна сума. Вярната е: " + ControlDigit, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            return true;
        }

        private bool ValidateEGN()
        {
            int l = Convert.ToInt32(textBox1.Text.Length);
            string s;
            if (IsEgnValid(textBox1.Text))
            {
                return true;
            }
            else
            {
                s = "Невалидно ЕГН! Броят на символите е различен от 10! Въвели сте " + Convert.ToString(l) + " символа!";
                MessageBox.Show(s, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }
        private bool IsEgnValid(string aText)
        {
            // Брой символи
            if (aText.Length != 10)
            {
                return false;
            }

            for (int i = 0; i < aText.Length; i++)
            {
                if (!Char.IsDigit(aText[i]))
                {
                    return false;
                }
            }
            string rd = textBox1.Text;
            string s;

            // Рождена дата 
            if ((Convert.ToInt32(rd.Substring(2, 2)) >= (1)) && (Convert.ToInt32(rd.Substring(2, 2)) <= (12)))
            {
                try
                {
                    s = rd.Substring(4, 2) + "." + Convert.ToString(Convert.ToInt32(rd.Substring(2, 2))) + "." + "19" + rd.Substring(0, 2);
                    dateTimePicker1.Text = s;
                    int s1 = Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32("19" + rd.Substring(0, 2));
                }
                catch
                {
                    MessageBox.Show("Грешно зададен месец!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else if ((Convert.ToInt32(rd.Substring(2, 2)) >= (21)) && (Convert.ToInt32(rd.Substring(2, 2)) <= (32)))
            {
                try
                {
                    s = rd.Substring(4, 2) + "." + Convert.ToString(Convert.ToInt32(rd.Substring(2, 2)) - 20) + "." + "18" + rd.Substring(0, 2);
                    dateTimePicker1.Text = s;
                    int s1 = Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32("18" + rd.Substring(0, 2));
                }
                catch
                {
                    MessageBox.Show("Грешно зададен месец!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else if ((Convert.ToInt32(rd.Substring(2, 2)) >= (41)) && (Convert.ToInt32(rd.Substring(2, 2)) <= (52)))
            {
                s = rd.Substring(4, 2) + "." + Convert.ToString(Convert.ToInt32(rd.Substring(2, 2)) - 40) + "." + "20" + rd.Substring(0, 2);
                try
                {
                    dateTimePicker1.Text = s;
                    int s1 = Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32("20" + rd.Substring(0, 2));
                }
                catch
                {
                    MessageBox.Show("Грешно зададен месец!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            else
                MessageBox.Show("Грешно зададена дата!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            // Контролна сума
            int ControlSum = Convert.ToInt32(rd.Substring(0, 1)) * 2;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(1, 1)) * 4;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(2, 1)) * 8;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(3, 1)) * 5;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(4, 1)) * 10;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(5, 1)) * 9;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(6, 1)) * 7;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(7, 1)) * 3;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(8, 1)) * 6;
       

            
            int ControlDigit = Convert.ToInt32(ControlSum) % 11;

            if (ControlDigit == 10)
            { ControlDigit = 0; }

            if (aText.Length == 10)
            {
                if (Convert.ToInt32(rd.Substring(9, 1)) == ControlDigit)
                {
                    if ((Convert.ToInt32(rd.Substring(8, 1)) % 2) == 0)
                    {
                        MessageBox.Show("ЕГН на мъж");
                    }
                    else
                    {
                        MessageBox.Show("ЕГН на жена");
                    }
                }
                else if (Convert.ToInt32(rd.Substring(9, 1)) != ControlDigit)
                    MessageBox.Show("Вярната последна цифра е: " + ControlDigit, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Грешна контролна сума. Вярната е: " + ControlDigit, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return true;
        }

        private bool ValidateLNCh()
        {
            int l = Convert.ToInt32(textBox1.Text.Length);
            string s;
            if (IsLNChValid(textBox1.Text))
            {
                return true;
            }
            else
            {
                s = "Невалидно ЛНЧ! Броят на символите е различен от 10! Въвели сте " + Convert.ToString(l) + " символа!";
                MessageBox.Show(s, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }
        private bool IsLNChValid(string aText)
        {
            // Брой символи
            if (aText.Length != 10)
            {
                return false;
            }

            for (int i = 0; i < aText.Length; i++)
            {
                if (!Char.IsDigit(aText[i]))
                {
                    return false;
                }
            }
            string rd = textBox1.Text;
            // Контролна сума

            int ControlSum = Convert.ToInt32(rd.Substring(0, 1)) * 21;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(1, 1)) * 19;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(2, 1)) * 17;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(3, 1)) * 13;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(4, 1)) * 11;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(5, 1)) * 9;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(6, 1)) * 7;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(7, 1)) * 3;
            ControlSum = ControlSum + Convert.ToInt32(rd.Substring(8, 1)) * 1;
            
            int ControlDigit = Convert.ToInt32(ControlSum) % 10;
            if (aText.Length == 10)
            {
                if (Convert.ToInt32(rd.Substring(9, 1)) != ControlDigit)
                    MessageBox.Show("Грешна контролна сума. Вярната е: " + ControlDigit, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            return true;
        }
    }
}


    

