using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr9
{
    public partial class Form1 : Form
    {
        String currentFile;
        ArrayList undoList;
      
        


        public Form1()
        {
            InitializeComponent();
            currentFile = null;
            undoList = new ArrayList();
           
            undoList.Add("");
            undo.Enabled = false;
            undo.Enabled = false;


            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void saeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile != null)
                saveFile();
            else
                saveFileAs();


        }

        private void saveFile()
        {
            System.IO.StreamWriter wr = new System.IO.StreamWriter(currentFile);

            wr.Write(textBox1.Text);
            wr.Close();
        }

        private void saveFileAs()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFile = saveFileDialog1.FileName;
                this.Text = currentFile + " Notepad";
                saveFile();
            }
            sae.Enabled = true;
            sae.Enabled = true;
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void newFile()
        {
            DialogResult result = MessageBox.Show("Do you want to save changes to the current file?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (currentFile != null)
                    saveFile();
               
            }
            else if (result == DialogResult.Cancel)
            {
                
                return;
            }
            textBox1.Text = "";
            sae.Enabled = false;
            sae.Enabled = false;
         
            currentFile = null;
        }


        private void openFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFileDialog1.FileName;
                System.IO.StreamReader sr = new System.IO.StreamReader(currentFile);

                textBox1.Text = sr.ReadToEnd();
                //enable save and print option
                sae.Enabled = true;
                sae.Enabled = true;
        
                this.Text = currentFile + " Notepad";
                sr.Close();
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            myUndo();

        }

        private void myUndo()
        {
            
            
            textBox1.Text = (String)undoList[undoList.Count - 2];
            undoList.RemoveAt(undoList.Count - 1);

            undoList.RemoveAt(undoList.Count - 1);

            if (undoList.Count == 1)
            {
                undo.Enabled = false;
                undo.Enabled = false;
            }


        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?\n All the current changes will be lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                
                return;
            }
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font myfont = new Font("Times New Roman", 12.0f);
            textBox1.Font = myfont;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void textAlighToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RedBackground_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void BlackBackground_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Black;
        }

        private void GreenBackground_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void YellowBackground_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void consolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font myfont = new Font("Consolas", 12.0f);
            textBox1.Font = myfont;
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            saveFileAs();
        }

        private void cambriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font myfont = new Font("Cambria", 12.0f);
            textBox1.Font = myfont;
        }
    }
}
