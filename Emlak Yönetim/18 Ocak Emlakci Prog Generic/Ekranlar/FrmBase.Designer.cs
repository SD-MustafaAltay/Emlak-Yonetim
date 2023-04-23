namespace _18_Ocak_Emlakci_Prog_Generic.Ekranlar
{
    partial class FrmBase<T>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncikis);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnDuzelt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnYeniKayit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 78);
            this.panel1.TabIndex = 0;
            // 
            // btncikis
            // 
            this.btncikis.Dock = System.Windows.Forms.DockStyle.Left;
            this.btncikis.Location = new System.Drawing.Point(0, 0);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(116, 78);
            this.btncikis.TabIndex = 6;
            this.btncikis.Text = "CIKIS";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(585, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(58, 78);
            this.panel4.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSil.Location = new System.Drawing.Point(643, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 78);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SIL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(758, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(58, 78);
            this.panel3.TabIndex = 3;
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDuzelt.Location = new System.Drawing.Point(816, 0);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(116, 78);
            this.btnDuzelt.TabIndex = 2;
            this.btnDuzelt.Text = "DUZELT";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(932, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 78);
            this.panel2.TabIndex = 1;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYeniKayit.Location = new System.Drawing.Point(990, 0);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(137, 78);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "YENI KAYIT";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 553);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 631);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBase";
            this.Text = "FrmBase";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}