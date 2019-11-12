using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "ЕГН";
            label2.Text = "Име";
            label3.Text = "Презиме";
            label4.Text = "Фамилия";
            label5.Text = "Възраст";
            label6.Text = "Дата на раждане";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            groupBox1.Text = "Пол";
            radioButton1.Text = "мъж";
            radioButton2.Text = "жена";
            radioButton1.Checked = true;
            button1.Text = "Изход";
            button2.Text = "Запис";
            button3.Text = "Проверка";
            button4.Text = "Изтриване";

        }
        private void TextBoxEGN_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateEGN();
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
                s = "Невалидно ЕГН! Броят на символите е <> от 10 " + Convert.ToString(l);
                MessageBox.Show(s, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }
        private bool IsEgnValid(string aText)
        {
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

            if ((Convert.ToInt32(rd.Substring(2, 2)) >= (41)) && (Convert.ToInt32(rd.Substring(2, 2)) <= (52)))
            {
                s = rd.Substring(4, 2) + "." + Convert.ToString(Convert.ToInt32(rd.Substring(2, 2)) - 40) + "." + "20" + rd.Substring(0, 2);
                try
                {
                    dateTimePicker1.Text = s;
                    int s1 = Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32("20" + rd.Substring(0, 2));
                    textBox5.Text = Convert.ToString(s1);
                }
                catch
                {
                    MessageBox.Show("Грешно зададен месец!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else if ((Convert.ToInt32(rd.Substring(2, 2)) >= (1)) && (Convert.ToInt32(rd.Substring(2, 2)) <= (12)))
            {
                try
                {
                    s = rd.Substring(4, 2) + "." + Convert.ToString(Convert.ToInt32(rd.Substring(2, 2))) + "." + "19" + rd.Substring(0, 2);
                    dateTimePicker1.Text = s;
                    int s1 = Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32("19" + rd.Substring(0, 2));
                    textBox5.Text = Convert.ToString(s1);
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
                    textBox5.Text = Convert.ToString(s1);
                }
                catch
                {
                    MessageBox.Show("Грешно зададен месец!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
                MessageBox.Show("Грешно зададена дата!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                    }
                    else
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = true;
                    }
                }
                else if (Convert.ToInt32(rd.Substring(9, 1)) != ControlDigit)
                    MessageBox.Show("Вярната последна цифра е: " + ControlDigit, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Грешна контролна сума. Вярната е: " + ControlDigit, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изход без запис!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TextWriter f = File.AppendText("..\\..\\test.txt");
            string s = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + "," + dateTimePicker1.Text + "," + radioButton1.Checked + ',' + radioButton2.Checked;
            f.WriteLine(s);
            f.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ValidateEGN();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.Refresh();
            radioButton1.Checked = true;
        }
    }
}
