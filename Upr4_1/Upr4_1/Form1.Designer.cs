namespace Upr4_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_pal = new System.Windows.Forms.Button();
            this.button_ascii = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_pal
            // 
            this.button_pal.Location = new System.Drawing.Point(45, 12);
            this.button_pal.Name = "button_pal";
            this.button_pal.Size = new System.Drawing.Size(85, 27);
            this.button_pal.TabIndex = 0;
            this.button_pal.Text = "Палиндром";
            this.button_pal.UseVisualStyleBackColor = true;
            this.button_pal.Click += new System.EventHandler(this.button_pal_Click);
            // 
            // button_ascii
            // 
            this.button_ascii.Location = new System.Drawing.Point(45, 160);
            this.button_ascii.Name = "button_ascii";
            this.button_ascii.Size = new System.Drawing.Size(78, 30);
            this.button_ascii.TabIndex = 1;
            this.button_ascii.Text = "ASCII код";
            this.button_ascii.UseVisualStyleBackColor = true;
            this.button_ascii.Click += new System.EventHandler(this.button_ascii_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 212);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_ascii);
            this.Controls.Add(this.button_pal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pal;
        private System.Windows.Forms.Button button_ascii;
        private System.Windows.Forms.TextBox textBox1;
    }
}

