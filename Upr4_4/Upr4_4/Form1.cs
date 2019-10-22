using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr4_4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        { InitializeComponent(); }
        private void button2_Click(object sender, EventArgs e)
        { }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = e.Url.ToString();
        }
    }
}
