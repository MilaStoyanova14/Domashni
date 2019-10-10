namespace WindowsFormsApplication2
{
    partial class Form3
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
			this.conv = new System.Windows.Forms.Label();
			this.num = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.res = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Close = new System.Windows.Forms.Button();
			this.Refresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// conv
			// 
			this.conv.AutoSize = true;
			this.conv.Location = new System.Drawing.Point(13, 13);
			this.conv.Name = "conv";
			this.conv.Size = new System.Drawing.Size(44, 13);
			this.conv.TabIndex = 0;
			this.conv.Text = "Convert";
			// 
			// num
			// 
			this.num.Location = new System.Drawing.Point(63, 13);
			this.num.Name = "num";
			this.num.Size = new System.Drawing.Size(100, 20);
			this.num.TabIndex = 1;
			this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "feet",
            "yards",
            "inches",
            "miles"});
			this.comboBox1.Location = new System.Drawing.Point(388, 28);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(388, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "from";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(388, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "to";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "feet",
            "yards",
            "inches",
            "miles"});
			this.comboBox2.Location = new System.Drawing.Point(388, 99);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 5;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
			// 
			// res
			// 
			this.res.Location = new System.Drawing.Point(190, 211);
			this.res.Name = "res";
			this.res.ReadOnly = true;
			this.res.Size = new System.Drawing.Size(100, 20);
			this.res.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(187, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Result";
			// 
			// Close
			// 
			this.Close.Location = new System.Drawing.Point(73, 282);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(75, 23);
			this.Close.TabIndex = 8;
			this.Close.Text = "Close";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// Refresh
			// 
			this.Refresh.Location = new System.Drawing.Point(318, 282);
			this.Refresh.Name = "Refresh";
			this.Refresh.Size = new System.Drawing.Size(75, 23);
			this.Refresh.TabIndex = 9;
			this.Refresh.Text = "Refresh";
			this.Refresh.UseVisualStyleBackColor = true;
			this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 336);
			this.Controls.Add(this.Refresh);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.res);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.num);
			this.Controls.Add(this.conv);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label conv;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Refresh;
    }
}