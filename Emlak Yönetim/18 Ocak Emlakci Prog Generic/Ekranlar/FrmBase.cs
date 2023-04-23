using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_Ocak_Emlakci_Prog_Generic.Ekranlar
{
    public partial class FrmBase<T> : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }
        

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }
            int i = dataGridView1.SelectedRows[0].Index;
            DialogResult s = MessageBox.Show("Silmek Istediginize Emin Misiniz ?","Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (s == DialogResult.Yes)
            {
                
                islem<T>.Sil(i);
                MessageBox.Show("Kayit Silindi");
                FillData();
            }
            
            

        }

        private void FillData()
        {
            dataGridView1.DataSource = islem<T>.Yukle();
        }

        private  void btnDuzelt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }

            int i = dataGridView1.SelectedRows[0].Index;
            

            DuzenlemeFormuAc(i);
           
            FillData();

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            EklemetFormuAc();
            FillData();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = islem<T>.Yukle();
        }
        public virtual void DuzenlemeFormuAc(int index)
        {
            MessageBox.Show("Duzenleme Formu Tanimlanmadi");

        }
        public virtual void EklemetFormuAc()
        {
            MessageBox.Show("Ekleme Formu Tanimlanmadi");

        }
    }
}
