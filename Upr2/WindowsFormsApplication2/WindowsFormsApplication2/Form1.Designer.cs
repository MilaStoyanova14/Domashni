namespace WindowsFormsApplication2
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
			this.A = new System.Windows.Forms.TextBox();
			this.B = new System.Windows.Forms.TextBox();
			this.C = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.X1 = new System.Windows.Forms.TextBox();
			this.X2 = new System.Windows.Forms.TextBox();
			this.Calc = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.metricStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.electricBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// A
			// 
			this.A.Location = new System.Drawing.Point(84, 69);
			this.A.Name = "A";
			this.A.Size = new System.Drawing.Size(100, 20);
			this.A.TabIndex = 0;
			// 
			// B
			// 
			this.B.Location = new System.Drawing.Point(84, 125);
			this.B.Name = "B";
			this.B.Size = new System.Drawing.Size(100, 20);
			this.B.TabIndex = 1;
			// 
			// C
			// 
			this.C.Location = new System.Drawing.Point(84, 192);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(100, 20);
			this.C.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "A";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "B";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "C";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(56, 264);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "X1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(56, 314);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "X2";
			// 
			// X1
			// 
			this.X1.Location = new System.Drawing.Point(132, 264);
			this.X1.Name = "X1";
			this.X1.ReadOnly = true;
			this.X1.Size = new System.Drawing.Size(100, 20);
			this.X1.TabIndex = 8;
			// 
			// X2
			// 
			this.X2.Location = new System.Drawing.Point(132, 314);
			this.X2.Name = "X2";
			this.X2.ReadOnly = true;
			this.X2.Size = new System.Drawing.Size(100, 20);
			this.X2.TabIndex = 9;
			// 
			// Calc
			// 
			this.Calc.Location = new System.Drawing.Point(299, 199);
			this.Calc.Name = "Calc";
			this.Calc.Size = new System.Drawing.Size(90, 42);
			this.Calc.TabIndex = 10;
			this.Calc.Text = "CALC";
			this.Calc.UseVisualStyleBackColor = true;
			this.Calc.Click += new System.EventHandler(this.Calc_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(438, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempToolStripMenuItem,
            this.metricStuffToolStripMenuItem,
            this.electricBillToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// tempToolStripMenuItem
			// 
			this.tempToolStripMenuItem.Name = "tempToolStripMenuItem";
			this.tempToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.tempToolStripMenuItem.Text = "Temp";
			this.tempToolStripMenuItem.Click += new System.EventHandler(this.tempToolStripMenuItem_Click);
			// 
			// metricStuffToolStripMenuItem
			// 
			this.metricStuffToolStripMenuItem.Name = "metricStuffToolStripMenuItem";
			this.metricStuffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.metricStuffToolStripMenuItem.Text = "Metric stuff";
			this.metricStuffToolStripMenuItem.Click += new System.EventHandler(this.metricStuffToolStripMenuItem_Click);
			// 
			// electricBillToolStripMenuItem
			// 
			this.electricBillToolStripMenuItem.Name = "electricBillToolStripMenuItem";
			this.electricBillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.electricBillToolStripMenuItem.Text = "Electric bill";
			this.electricBillToolStripMenuItem.Click += new System.EventHandler(this.electricBillToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 426);
			this.Controls.Add(this.Calc);
			this.Controls.Add(this.X2);
			this.Controls.Add(this.X1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.C);
			this.Controls.Add(this.B);
			this.Controls.Add(this.A);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metricStuffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem electricBillToolStripMenuItem;
    }
}

