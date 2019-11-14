using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr7_1
{
    public partial class Form1 : Form
    {
        static int curr_question = 0;

        static string[] questions = new string[]{
            "What is 9 cubed?",
            "What is 6+3?",
            "What type of animal is tuna sandwiches made from?",
            "What is 18 backwards?"
        };

        static string[] answers = new string[] {
             "9", "81", "729", "2",
             "4", "2", "9", "1",
             "zebra", "aardvark", "fish", "gnu",
             "31", "81", "91", "88"
        };

        static string[] quizAnswers = new string[] { "729", "9", "fish", "81" };

        static int[] user_answ = new int[4] { 0,0,0,0};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Next";
            button2.Text = "Finish";
            groupBox1.Text = "Questions";
            changeQuestion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                user_answ[curr_question] = curr_question * 4;
            }
            else if (radioButton2.Checked == true)
            {
                user_answ[curr_question] = curr_question * 4 + 1;
            }
            else if (radioButton3.Checked == true)
            {
                user_answ[curr_question] = curr_question * 4 + 2;
            }
            else if (radioButton4.Checked == true)
            {
                user_answ[curr_question] = curr_question * 4 + 3;
            }

             changeQuestion();

        }

        void changeQuestion() {
           
            label1.Text = questions[curr_question];
            radioButton1.Text = answers[curr_question * 4];
            radioButton2.Text = answers[curr_question * 4 + 1];
            radioButton3.Text = answers[curr_question * 4 + 2];
            radioButton4.Text = answers[curr_question * 4 + 3];
            radioButton1.Checked = true;
            curr_question++;

            if (curr_question==4) {
                button1.Visible = false;
                button2.Visible = true;
            }

        }

        void Results()
        {

            int RightAnswers = 0;
            for(int i = 0;i < 4;i++)
            {
                if(String.Compare(answers[user_answ[i]],quizAnswers[i]) == 0)
                {
                    RightAnswers++;
                }
            }
            textBox1.Text = RightAnswers.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Results();
        }
    }
}
