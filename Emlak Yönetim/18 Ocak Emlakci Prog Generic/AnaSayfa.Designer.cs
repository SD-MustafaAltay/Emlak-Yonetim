namespace _18_Ocak_Emlakci_Prog_Generic
{
    partial class AnaSayfa
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
            this.emlakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konutlariGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isYeriGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arsaGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emlakToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // emlakToolStripMenuItem
            // 
            this.emlakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konutlariGoruntuleToolStripMenuItem,
            this.isYeriGoruntuleToolStripMenuItem,
            this.arsaGoruntuleToolStripMenuItem});
            this.emlakToolStripMenuItem.Name = "emlakToolStripMenuItem";
            this.emlakToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.emlakToolStripMenuItem.Text = "Emlak";
            // 
            // konutlariGoruntuleToolStripMenuItem
            // 
            this.konutlariGoruntuleToolStripMenuItem.Name = "konutlariGoruntuleToolStripMenuItem";
            this.konutlariGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konutlariGoruntuleToolStripMenuItem.Text = "Konutlari Goruntule";
            this.konutlariGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.konutlariGoruntuleToolStripMenuItem_Click);
            // 
            // isYeriGoruntuleToolStripMenuItem
            // 
            this.isYeriGoruntuleToolStripMenuItem.Name = "isYeriGoruntuleToolStripMenuItem";
            this.isYeriGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.isYeriGoruntuleToolStripMenuItem.Text = "Is Yeri Goruntule";
            this.isYeriGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.isYeriGoruntuleToolStripMenuItem_Click);
            // 
            // arsaGoruntuleToolStripMenuItem
            // 
            this.arsaGoruntuleToolStripMenuItem.Name = "arsaGoruntuleToolStripMenuItem";
            this.arsaGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arsaGoruntuleToolStripMenuItem.Text = "Arsa Goruntule";
            this.arsaGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.arsaGoruntuleToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.cikisToolStripMenuItem.Text = "Cikis";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImage = global::_18_Ocak_Emlakci_Prog_Generic.Properties.Resources.Adsiz2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 394);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaSayfa";
            this.Text = "Emlak Yönetim";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem emlakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konutlariGoruntuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isYeriGoruntuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arsaGoruntuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
    }
}

