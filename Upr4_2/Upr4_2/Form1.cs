using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Upr4_2
{
    public partial class Form1 : Form
    {
        ListBox listBox1 = new ListBox();
        ListBox listBox2 = new ListBox();
        Button button1 = new Button();
        Button button2 = new Button();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButton();
        }

        private void CreateButton()
        {

            //Определяме размера, локацията на button1 върху формата и надписа върху button1  
            button1.Size = new System.Drawing.Size(120, 30);
            button1.Location = new System.Drawing.Point(250, 10);

            
            button1.Text = "Create ListBox1";
            // Добавяме button1 към формата
            this.Controls.Add(button1);
            // и събитието Click за button1
            button1.Click += new EventHandler(this.button1_Click);
            //Определяме размера, локацията на button2 върху формата и надписа върху button2

            // Добавяме button2 към формата
            // и събитието Click за button2
            //Определяме размера, локацията на button1 върху формата и надписа върху button1  
            button2.Size = new System.Drawing.Size(120, 30);
            button2.Location = new System.Drawing.Point(350, 110);


            button2.Text = "Create ListBox2";
            // Добавяме button1 към формата
            this.Controls.Add(button2);
            // и събитието Click за button1
            button2.Click += new EventHandler(this.button2_Click);
        }


        //метод button1_Click(), който ще обработва събитието Click за button1
        protected void button1_Click(object sender, EventArgs e)
        {
            CreateListBox(); //извиква метода за създаване на  listBox1 и ListBox2
                             //и извежда съдържанието на names.txt в listBox1
                             //string[] lines = System.IO.File.ReadAllLines("D:\\names.txt");
            string[] lines = System.IO.File.ReadAllLines("..\\..\\test.txt");
            foreach (string str in lines)
            {
                listBox1.Items.Add(str);
            }
        }


        //метод button2_Click(), който ще обработва събитието Click за button2
        protected void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double salary = Double.Parse(Interaction.InputBox("Въведете заплата: "));
                listBox2.Items.Add(salary);
            }
            catch {
                MessageBox.Show("Въведете коректни данни!");
            }
   
        }

        private void CreateListBox()
        {  
            
            //Определяме размера и локацията ListBox1.
            listBox1.Size = new System.Drawing.Size(100, 100);
            listBox1.Location = new System.Drawing.Point(10, 10);
            // Добавяме ListBox1 към формата 
            this.Controls.Add(listBox1);
            // Указва, че ListBox ще разпечатва в multiple columns.
            listBox1.MultiColumn = true;
            // Установява SelectionMode: multiple и extended.
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            //Аналогично и за ListBox2

            listBox2.Size = new System.Drawing.Size(100, 100);
            listBox2.Location = new System.Drawing.Point(110, 110);
            // Добавяме ListBox1 към формата 
            this.Controls.Add(listBox2);
            // Указва, че ListBox ще разпечатва в multiple columns.
            listBox2.MultiColumn = true;
            // Установява SelectionMode: multiple и extended.
            listBox2.SelectionMode = SelectionMode.MultiExtended;

        }

    }
}
