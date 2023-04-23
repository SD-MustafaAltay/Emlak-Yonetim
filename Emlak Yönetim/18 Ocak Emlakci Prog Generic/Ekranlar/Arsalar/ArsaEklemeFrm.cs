using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_Ocak_Emlakci_Prog_Generic.Ekranlar.Arsalar
{
    public partial class ArsaEklemeFrm : Form
    {
        public int secili  = -1;
        public ArsaEklemeFrm()
        {
            InitializeComponent();
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            ArsaBi cc = new ArsaBi();

            cc.Ada = txtada.Text;
            cc.Durumu = cmbdurum.Text;
            cc.Parsel = txtparsel.Text;
            cc.Ilce = cmbilce.Text;
            cc.Fiyati=txtfiyat.Text;
            cc.Il=cmbil.Text;
            cc.M2=txtdonum.Text;
            cc.MulkSahibiAdi=txtSahibi.Text;
            cc.MulkSahibiIletisim = txtIletisim.Text;

            if (secili <0)
            {
                islem<ArsaBi>.Ekle(cc);
            }
            else
            {
                islem<ArsaBi>.Duzenle(secili, cc);
            }
         
            
            this.Close();
          
        }

        private void ArsaEklemeFrm_Load(object sender, EventArgs e)
        {
            if(secili>=0)
            {
                var c = islem<ArsaBi>.GetDataWithIndex(secili);
                
                cmbdurum.Text = c.Durumu;
                txtparsel.Text = c.Parsel;
                cmbilce.Text = c.Ilce;
                txtfiyat.Text = c.Fiyati;
                cmbil.Text = c.Il;
                txtdonum.Text = c.M2;
                txtada.Text = c.Ada;
                txtIletisim.Text = c.MulkSahibiIletisim;
                txtSahibi.Text = c.MulkSahibiAdi;
                islem<ArsaBi>.GetDataWithIndex(secili);

            }

           
            

        }

        private void cmbdurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSahibi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
