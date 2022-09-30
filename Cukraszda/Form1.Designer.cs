namespace Cukraszda
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
            this.fáljToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fáljBeolvasásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süteményekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fáljToolStripMenuItem,
            this.süteményekToolStripMenuItem,
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fáljToolStripMenuItem
            // 
            this.fáljToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fáljBeolvasásToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fáljToolStripMenuItem.Name = "fáljToolStripMenuItem";
            this.fáljToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fáljToolStripMenuItem.Text = "Fálj";
            // 
            // fáljBeolvasásToolStripMenuItem
            // 
            this.fáljBeolvasásToolStripMenuItem.Name = "fáljBeolvasásToolStripMenuItem";
            this.fáljBeolvasásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fáljBeolvasásToolStripMenuItem.Text = "Fálj beolvasás";
            this.fáljBeolvasásToolStripMenuItem.Click += new System.EventHandler(this.fáljBeolvasásToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // süteményekToolStripMenuItem
            // 
            this.süteményekToolStripMenuItem.Enabled = false;
            this.süteményekToolStripMenuItem.Name = "süteményekToolStripMenuItem";
            this.süteményekToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.süteményekToolStripMenuItem.Text = "Sütemények";
            this.süteményekToolStripMenuItem.Click += new System.EventHandler(this.süteményekToolStripMenuItem_Click);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cukrászda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fáljToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fáljBeolvasásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süteményekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
    }
}

