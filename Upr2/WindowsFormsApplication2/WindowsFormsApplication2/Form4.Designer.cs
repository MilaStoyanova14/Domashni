namespace WindowsFormsApplication2
{
	partial class Form4
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.client_id = new System.Windows.Forms.Label();
			this.potreblenie = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radio34 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radio54 = new System.Windows.Forms.RadioButton();
			this.radio44 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.res = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(676, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClientToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// newClientToolStripMenuItem
			// 
			this.newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
			this.newClientToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.newClientToolStripMenuItem.Text = "New Client";
			this.newClientToolStripMenuItem.Click += new System.EventHandler(this.newClientToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.aboutToolStripMenuItem.Text = "Bill";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(197, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Клиентски номер: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(197, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(188, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Старо показване на електромера:  ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ново показване на електромера:  ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(197, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Потребление:";
			// 
			// client_id
			// 
			this.client_id.AutoSize = true;
			this.client_id.Location = new System.Drawing.Point(321, 35);
			this.client_id.Name = "client_id";
			this.client_id.Size = new System.Drawing.Size(35, 13);
			this.client_id.TabIndex = 5;
			this.client_id.Tag = "3";
			this.client_id.Text = "label5";
			this.client_id.Visible = false;
			// 
			// potreblenie
			// 
			this.potreblenie.AutoSize = true;
			this.potreblenie.Location = new System.Drawing.Point(321, 207);
			this.potreblenie.Name = "potreblenie";
			this.potreblenie.Size = new System.Drawing.Size(35, 13);
			this.potreblenie.TabIndex = 6;
			this.potreblenie.Text = "label6";
			this.potreblenie.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(391, 101);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(391, 132);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 8;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// radio34
			// 
			this.radio34.AutoSize = true;
			this.radio34.Location = new System.Drawing.Point(6, 19);
			this.radio34.Name = "radio34";
			this.radio34.Size = new System.Drawing.Size(46, 17);
			this.radio34.TabIndex = 9;
			this.radio34.TabStop = true;
			this.radio34.Text = "0.34";
			this.radio34.UseVisualStyleBackColor = true;
			this.radio34.CheckedChanged += new System.EventHandler(this.radio34_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radio54);
			this.groupBox1.Controls.Add(this.radio44);
			this.groupBox1.Controls.Add(this.radio34);
			this.groupBox1.Location = new System.Drawing.Point(200, 258);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(291, 51);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Тарифа";
			// 
			// radio54
			// 
			this.radio54.AutoSize = true;
			this.radio54.Location = new System.Drawing.Point(194, 19);
			this.radio54.Name = "radio54";
			this.radio54.Size = new System.Drawing.Size(46, 17);
			this.radio54.TabIndex = 11;
			this.radio54.TabStop = true;
			this.radio54.Text = "0.54";
			this.radio54.UseVisualStyleBackColor = true;
			this.radio54.CheckedChanged += new System.EventHandler(this.radio54_CheckedChanged);
			// 
			// radio44
			// 
			this.radio44.AutoSize = true;
			this.radio44.Location = new System.Drawing.Point(100, 19);
			this.radio44.Name = "radio44";
			this.radio44.Size = new System.Drawing.Size(46, 17);
			this.radio44.TabIndex = 10;
			this.radio44.TabStop = true;
			this.radio44.Text = "0.44";
			this.radio44.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(197, 352);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Сума за плащане:";
			// 
			// res
			// 
			this.res.AutoSize = true;
			this.res.Location = new System.Drawing.Point(321, 352);
			this.res.Name = "res";
			this.res.Size = new System.Drawing.Size(35, 13);
			this.res.TabIndex = 12;
			this.res.Text = "label6";
			this.res.Visible = false;
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 424);
			this.Controls.Add(this.res);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.potreblenie);
			this.Controls.Add(this.client_id);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form4";
			this.Text = "Form4";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newClientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label client_id;
		private System.Windows.Forms.Label potreblenie;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radio34;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radio54;
		private System.Windows.Forms.RadioButton radio44;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label res;
	}
}