namespace Upr3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.klasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.klasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.stepenuvaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sukratenoUmnojenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kvUravnenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algebraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algebraToolStripMenuItem
            // 
            this.algebraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klasToolStripMenuItem});
            this.algebraToolStripMenuItem.Name = "algebraToolStripMenuItem";
            this.algebraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.algebraToolStripMenuItem.Text = "Mat formuli";
            this.algebraToolStripMenuItem.Click += new System.EventHandler(this.algebraToolStripMenuItem_Click);
            // 
            // klasToolStripMenuItem
            // 
            this.klasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klasToolStripMenuItem1,
            this.klasToolStripMenuItem2,
            this.klasToolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.klasToolStripMenuItem.Name = "klasToolStripMenuItem";
            this.klasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.klasToolStripMenuItem.Text = "Algebra";
            // 
            // klasToolStripMenuItem1
            // 
            this.klasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepenuvaneToolStripMenuItem});
            this.klasToolStripMenuItem1.Name = "klasToolStripMenuItem1";
            this.klasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.klasToolStripMenuItem1.Text = "6 klas";
            // 
            // klasToolStripMenuItem2
            // 
            this.klasToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sukratenoUmnojenieToolStripMenuItem});
            this.klasToolStripMenuItem2.Name = "klasToolStripMenuItem2";
            this.klasToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.klasToolStripMenuItem2.Text = "7 klas";
            // 
            // klasToolStripMenuItem3
            // 
            this.klasToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kvUravnenieToolStripMenuItem});
            this.klasToolStripMenuItem3.Name = "klasToolStripMenuItem3";
            this.klasToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.klasToolStripMenuItem3.Text = "8 klas";
            // 
            // stepenuvaneToolStripMenuItem
            // 
            this.stepenuvaneToolStripMenuItem.Name = "stepenuvaneToolStripMenuItem";
            this.stepenuvaneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stepenuvaneToolStripMenuItem.Text = "Stepenuvane";
            this.stepenuvaneToolStripMenuItem.Click += new System.EventHandler(this.stepenuvaneToolStripMenuItem_Click);
            // 
            // sukratenoUmnojenieToolStripMenuItem
            // 
            this.sukratenoUmnojenieToolStripMenuItem.Name = "sukratenoUmnojenieToolStripMenuItem";
            this.sukratenoUmnojenieToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sukratenoUmnojenieToolStripMenuItem.Text = "Sukrateno umnojenie";
            this.sukratenoUmnojenieToolStripMenuItem.Click += new System.EventHandler(this.sukratenoUmnojenieToolStripMenuItem_Click);
            // 
            // kvUravnenieToolStripMenuItem
            // 
            this.kvUravnenieToolStripMenuItem.Name = "kvUravnenieToolStripMenuItem";
            this.kvUravnenieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kvUravnenieToolStripMenuItem.Text = "Kv. uravnenie";
            this.kvUravnenieToolStripMenuItem.Click += new System.EventHandler(this.kvUravnenieToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stepenuvaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sukratenoUmnojenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem kvUravnenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

