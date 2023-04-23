using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_Ocak_Emlakci_Prog_Generic.Ekranlar.Konutlar
{
    public partial class KonutEklemeFrm : Form
    {
        public KonutEklemeFrm()
        {
            InitializeComponent();
        }
        public int secili = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            KonutBi a = new KonutBi();
            a.Balkon=txtbalkon.Text;

            a.BinaYasi = txtbinayas.Text;
            a.BulunduguKat=txtkat.Text;
            a.Durumu = txtdurumu.Text;
            a.BrutM2 = txtbrut.Text;
            a.NetM2 = txtnet.Text;
            a.Esyalimi = txtesyali.Text;
            a.Fiyati = txtfiyat.Text;
            a.Il = cmbil.Text;
            a.Ilce = cmbilce.Text;
            a.OdaSayisi = txtodasayisi.Text;
            a.Isitma=txtisitma.Text;
            a.MulkSahibiAdi = txtSahibi.Text;
            a.MulkSahibiIletisim = txtIletisim.Text;

            if (secili < 0)
            {
                islem<KonutBi>.Ekle(a);
            }
            else
            {
                islem<KonutBi>.Duzenle(secili, a);
            }
            

            this.Close();
        }

        private void KonutEklemeFrm_Load(object sender, EventArgs e)
        {
            if (secili < 0)
            {
                return;

            }

            var c = islem<KonutBi>.GetDataWithIndex(secili);

            c.Balkon = txtbalkon.Text;

            txtbinayas.Text=c.BinaYasi;
            txtkat.Text = c.BulunduguKat;
            txtdurumu.Text=c.Durumu ;
            txtbrut.Text=c.BrutM2 ;
            txtnet.Text=c.NetM2 ;
            txtesyali.Text=c.Esyalimi;
            txtfiyat.Text=c.Fiyati ;
            cmbil.Text=c.Il;
            cmbilce.Text=c.Ilce ;
            txtodasayisi.Text=c.OdaSayisi ;
            txtisitma.Text = c.Isitma;
            txtIletisim.Text = c.MulkSahibiIletisim;
            txtSahibi.Text = c.MulkSahibiAdi;
        }

        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
