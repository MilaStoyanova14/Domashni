using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(dateTimePicker1.Value.ToString("MM"));
            int day = int.Parse(dateTimePicker1.Value.ToString("dd"));
            string astro_sign=""; 
          

        if (month == 12){ 
              
            if (day < 22) 
            astro_sign = "Sagittarius"; 
            else
            astro_sign ="Capricorn"; 
        } 
              
        else if (month == 1){ 
            if (day < 20) 
            astro_sign = "Capricorn"; 
            else
            astro_sign = "Aquarius"; 
        } 
              
        else if (month == 2){ 
            if (day < 19) 
            astro_sign = "Aquarius"; 
            else
            astro_sign = "Pisces"; 
        } 
              
        else if(month == 3){ 
            if (day < 21)  
            astro_sign = "Pisces"; 
            else
            astro_sign = "Aries"; 
        } 
        else if (month == 4){ 
            if (day < 20) 
            astro_sign = "Aries"; 
            else
            astro_sign = "Taurus"; 
        } 
              
        else if (month == 5){ 
            if (day < 21) 
            astro_sign = "Taurus"; 
            else
            astro_sign = "Gemini"; 
        } 
              
        else if( month == 6){ 
            if (day < 21) 
            astro_sign = "Gemini"; 
            else
            astro_sign = "Cancer"; 
        } 
              
        else if (month == 7){ 
            if (day < 23) 
            astro_sign = "Cancer"; 
            else
            astro_sign = "Leo"; 
        } 
              
        else if( month == 8){ 
            if (day < 23)  
            astro_sign = "Leo"; 
            else
            astro_sign = "Virgo"; 
        } 
              
        else if (month == 9){ 
            if (day < 23) 
            astro_sign = "Virgo"; 
            else
            astro_sign = "Libra"; 
        } 
              
        else if (month == 10){ 
            if (day < 23) 
            astro_sign = "Libra"; 
            else
            astro_sign = "Scorpio"; 
        } 
              
        else if (month == 11){ 
            if (day < 22) 
            astro_sign = "Scorpio"; 
            else
            astro_sign = "Sagittarius"; 
        }
            listBox1.Items.Add(astro_sign);
        }
    }
}
