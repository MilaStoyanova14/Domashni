using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Upr10
{
    public partial class Form1 : Form
    {
        int flag1 = 0;
        int BabyYodaX;
        int DarthVaderX;
        int BYwins = 0;
        int DVwins = 0;
        public Form1()
        {
            InitializeComponent();
            BabyYodaX = 1; DarthVaderX = 1;
            pictureBox1.Left = BabyYodaX;
            pictureBox2.Left = DarthVaderX;
            label1.Text = BYwins.ToString();
            label2.Text = DVwins.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            BabyYodaX = 1; DarthVaderX = 1;
            pictureBox1.Left = BabyYodaX;
            pictureBox2.Left = DarthVaderX;
            flag1 = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                flag1 = 1;
             
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
    
            int rand1 = r.Next(0, 8);
            int rand2 = r.Next(0, 8); 

 
      

                if (flag1 == 1)
            {
                if (pictureBox1.Location.X >= 763) {
                    flag1 = 0;
                    MessageBox.Show("Baby Yoda wins!");
                    BYwins++;
                    label1.Text = BYwins.ToString();
                    BabyYodaX = 1; DarthVaderX = 1;
                    pictureBox1.Left = BabyYodaX;
                    pictureBox2.Left = DarthVaderX;
                }

                else if (pictureBox2.Location.X >= 763)
                {
                    flag1 = 0;
                    MessageBox.Show("Darth Vader wins!");
                    DVwins++;
                    label2.Text = DVwins.ToString();
                    BabyYodaX = 1; DarthVaderX = 1;
                    pictureBox1.Left = BabyYodaX;
                    pictureBox2.Left = DarthVaderX;

                }
                else
                {

                    BabyYodaX = BabyYodaX + rand1;
                    pictureBox1.Left = BabyYodaX;
                    DarthVaderX = DarthVaderX + rand2;
                    pictureBox2.Left = DarthVaderX;
                }


           
            }

        }



   

        
    }
}
