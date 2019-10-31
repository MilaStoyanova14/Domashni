using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr5_2

{


    public partial class Form1 : Form
    {
        public static bool sub = false;
        public static bool add = false;
        public static bool mul = false;
        public static bool div = true;
        public static int counter = 60;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    

            try
            {
                Timer timer1 = new Timer
                {
                    Interval = 1000
                };
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timer1_Tick);
               
               Random rand = new Random();
                int p;
                var labels = new List<Label> { num1, num2, num3, num4, num5, num6, num7, num8 };

                foreach (var label in labels)
                {
                    p = rand.Next(50) + 1;
                    label.Text = p.ToString();
                }

            }
            catch {
                MessageBox.Show("Ne uspqhte!");
            }

        }

        public static void OnTimerEvent()
        {
            if (add && sub && mul && div )//
            {
                MessageBox.Show("Uspqhte!");
            }

            else {

                MessageBox.Show("Ne uspqhte!");
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                int a = Int32.Parse(num1.Text);
                int b = Int32.Parse(num2.Text);

                int c = Int32.Parse(num3.Text);
                int d = Int32.Parse(num4.Text);

                int f = Int32.Parse(num5.Text);
                int g = Int32.Parse(num6.Text);

                double h = Double.Parse(num7.Text);
                double i = Double.Parse(num8.Text);

                int ans1 = Int32.Parse(a1.Text);
                int ans2 = Int32.Parse(a2.Text);
                int ans3 = Int32.Parse(a3.Text);
                double ans4 = Double.Parse(a4.Text);

                if (a + b == ans1)
                {
                    add = true;
                }

                if (c - d == ans2)
                {
                    sub = true;
                }

                if (f * g == ans3)
                {
                    mul = true;
                }

                double ans4_comp = h / i;
                if (Math.Round(ans4_comp, 2) == Math.Round(ans4, 2))
                {
                    div = true;
                }
              

                timer1.Enabled = false;
                OnTimerEvent();
            }

            if (counter>=0) {
                label_timer.Text = counter.ToString();
            }
            

        }


    }
}
