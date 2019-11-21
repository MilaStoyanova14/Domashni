using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime myDT = new DateTime(dateTimePicker1.Value.Date.Year, dateTimePicker1.Value.Date.Month, dateTimePicker1.Value.Date.Day, new GregorianCalendar());
            JulianCalendar myCal = new JulianCalendar();
            textBox1.Text = "Day: " + myCal.GetDayOfYear(myDT);
        }
    }
}
