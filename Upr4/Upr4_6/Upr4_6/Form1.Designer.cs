namespace Upr4_6
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            largeRadioButton = new System.Windows.Forms.RadioButton();
            mediumRadioButton = new System.Windows.Forms.RadioButton();
            smallRadioButton = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            thickRadioButton = new System.Windows.Forms.RadioButton();
            thinRadioButton = new System.Windows.Forms.RadioButton();
            calculateButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            infoRichTextBox = new System.Windows.Forms.RichTextBox();
            toppingCheckedListBox = new System.Windows.Forms.CheckedListBox();
            extraCheeseCheckBox = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(largeRadioButton);
            groupBox1.Controls.Add(mediumRadioButton);
            groupBox1.Controls.Add(smallRadioButton);
            groupBox1.Location = new System.Drawing.Point(12, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(150, 81);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Size";
            // 
            // largeRadioButton
            // 
            largeRadioButton.AutoSize = true;
            largeRadioButton.Location = new System.Drawing.Point(5, 58);
            largeRadioButton.Margin = new System.Windows.Forms.Padding(2);
            largeRadioButton.Name = "largeRadioButton";
            largeRadioButton.Size = new System.Drawing.Size(82, 17);
            largeRadioButton.TabIndex = 2;
            largeRadioButton.TabStop = true;
            largeRadioButton.Text = "Large 13.75";
            largeRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            mediumRadioButton.AutoSize = true;
            mediumRadioButton.Location = new System.Drawing.Point(5, 38);
            mediumRadioButton.Margin = new System.Windows.Forms.Padding(2);
            mediumRadioButton.Name = "mediumRadioButton";
            mediumRadioButton.Size = new System.Drawing.Size(92, 17);
            mediumRadioButton.TabIndex = 1;
            mediumRadioButton.TabStop = true;
            mediumRadioButton.Text = "Medium 11.50";
            mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallRadioButton
            // 
            smallRadioButton.AutoSize = true;
            smallRadioButton.Location = new System.Drawing.Point(5, 18);
            smallRadioButton.Margin = new System.Windows.Forms.Padding(2);
            smallRadioButton.Name = "smallRadioButton";
            smallRadioButton.Size = new System.Drawing.Size(74, 17);
            smallRadioButton.TabIndex = 0;
            smallRadioButton.TabStop = true;
            smallRadioButton.Text = "Small 9.25";
            smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(thickRadioButton);
            groupBox2.Controls.Add(thinRadioButton);
            groupBox2.Location = new System.Drawing.Point(12, 101);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(150, 67);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crust";
            // 
            // thickRadioButton
            // 
            thickRadioButton.AutoSize = true;
            thickRadioButton.Location = new System.Drawing.Point(5, 41);
            thickRadioButton.Margin = new System.Windows.Forms.Padding(2);
            thickRadioButton.Name = "thickRadioButton";
            thickRadioButton.Size = new System.Drawing.Size(52, 17);
            thickRadioButton.TabIndex = 1;
            thickRadioButton.TabStop = true;
            thickRadioButton.Text = "Thick";
            thickRadioButton.UseVisualStyleBackColor = true;
            // 
            // thinRadioButton
            // 
            thinRadioButton.AutoSize = true;
            thinRadioButton.Location = new System.Drawing.Point(5, 18);
            thinRadioButton.Margin = new System.Windows.Forms.Padding(2);
            thinRadioButton.Name = "thinRadioButton";
            thinRadioButton.Size = new System.Drawing.Size(46, 17);
            thinRadioButton.TabIndex = 0;
            thinRadioButton.TabStop = true;
            thinRadioButton.Text = "Thin";
            thinRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            calculateButton.Location = new System.Drawing.Point(182, 173);
            calculateButton.Margin = new System.Windows.Forms.Padding(2);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new System.Drawing.Size(132, 19);
            calculateButton.TabIndex = 13;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += new System.EventHandler(calculateButton_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(180, 14);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 13);
            label1.TabIndex = 12;
            label1.Text = "Toppings- a dollar for each";
            // 
            // infoRichTextBox
            // 
            infoRichTextBox.Location = new System.Drawing.Point(11, 206);
            infoRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            infoRichTextBox.Name = "infoRichTextBox";
            infoRichTextBox.ReadOnly = true;
            infoRichTextBox.Size = new System.Drawing.Size(304, 154);
            infoRichTextBox.TabIndex = 11;
            infoRichTextBox.Text = "";
            // 
            // toppingCheckedListBox
            // 
            toppingCheckedListBox.FormattingEnabled = true;
            toppingCheckedListBox.Location = new System.Drawing.Point(182, 40);
            toppingCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            toppingCheckedListBox.Name = "toppingCheckedListBox";
            toppingCheckedListBox.Size = new System.Drawing.Size(133, 124);
            toppingCheckedListBox.TabIndex = 10;
            // 
            // extraCheeseCheckBox
            // 
            extraCheeseCheckBox.AutoSize = true;
            extraCheeseCheckBox.Location = new System.Drawing.Point(17, 173);
            extraCheeseCheckBox.Margin = new System.Windows.Forms.Padding(2);
            extraCheeseCheckBox.Name = "extraCheeseCheckBox";
            extraCheeseCheckBox.Size = new System.Drawing.Size(112, 17);
            extraCheeseCheckBox.TabIndex = 9;
            extraCheeseCheckBox.Text = "Extra cheese 1.50";
            extraCheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(331, 379);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(calculateButton);
            Controls.Add(label1);
            Controls.Add(infoRichTextBox);
            Controls.Add(toppingCheckedListBox);
            Controls.Add(extraCheeseCheckBox);
            Name = "Form1";
            Text = "Form1";
            Load += new System.EventHandler(Form1_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton thickRadioButton;
        private System.Windows.Forms.RadioButton thinRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.CheckedListBox toppingCheckedListBox;
        private System.Windows.Forms.CheckBox extraCheeseCheckBox;
    }
}

