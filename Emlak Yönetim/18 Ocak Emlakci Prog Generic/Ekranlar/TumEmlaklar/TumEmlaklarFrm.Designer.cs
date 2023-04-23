namespace _18_Ocak_Emlakci_Prog_Generic.Ekranlar.TumEmlaklar
{
    partial class TumEmlaklarFrm
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
            this.dgtumemlaklar = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cIKISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgtumemlaklar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgtumemlaklar
            // 
            this.dgtumemlaklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtumemlaklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgtumemlaklar.Location = new System.Drawing.Point(0, 40);
            this.dgtumemlaklar.Name = "dgtumemlaklar";
            this.dgtumemlaklar.RowHeadersWidth = 82;
            this.dgtumemlaklar.RowTemplate.Height = 33;
            this.dgtumemlaklar.Size = new System.Drawing.Size(952, 549);
            this.dgtumemlaklar.TabIndex = 0;
            this.dgtumemlaklar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtumemlaklar_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cIKISToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cIKISToolStripMenuItem
            // 
            this.cIKISToolStripMenuItem.Name = "cIKISToolStripMenuItem";
            this.cIKISToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.cIKISToolStripMenuItem.Text = "CIKIS";
            // 
            // TumEmlaklarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 589);
            this.Controls.Add(this.dgtumemlaklar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TumEmlaklarFrm";
            this.Text = "TumEmlaklarFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgtumemlaklar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtumemlaklar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cIKISToolStripMenuItem;
    }
}