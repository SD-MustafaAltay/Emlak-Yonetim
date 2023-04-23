using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_Ocak_Emlakci_Prog_Generic.Ekranlar.IsYeri
{
    public partial class IsYeriEklemeFrm : Form
    {
        public IsYeriEklemeFrm()
        {
            InitializeComponent();
        }
        public int secili = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            IsyeriBi a = new IsyeriBi();
            a.BinaYasi = txtbinayas.Text;
            a.Fiyati = txtfiyat.Text;
            a.BulunduguKat=txtkat.Text;
            a.Durumu=txtdurumu.Text;
            a.BolumSayisi=txtbolumsayisi.Text;
            a.Durumu = txtdurumu.Text;
            a.BrutM2 = txtbrut.Text;
            a.NetM2=txtnet.Text;
            a.Esyalimi=txtesyali.Text;
            a.Il = cmbil.Text;
            a.Ilce = cmbilce.Text;
            a.Isitma=txtisitma.Text;
            a.MulkSahibiAdi = txtSahibi.Text;
            a.MulkSahibiIletisim = txtIletisim.Text;

            if (secili < 0)
            {
                islem<IsyeriBi>.Ekle(a);
            }
            else
            {
                islem<IsyeriBi>.Duzenle(secili, a);
            }

            this.Close();



        }

        private void IsYeriEklemeFrm_Load(object sender, EventArgs e)
        {
            
            if (secili >= 0)
            {
                var c = islem<IsyeriBi>.GetDataWithIndex(secili);

                txtbinayas.Text = c.BinaYasi;
                txtfiyat.Text = c.Fiyati;
                txtkat.Text = c.BulunduguKat;
                txtdurumu.Text = c.Durumu;
                txtbolumsayisi.Text = c.BolumSayisi;
                txtdurumu.Text = c.Durumu;
                txtbrut.Text = c.BrutM2;
                txtnet.Text = c.NetM2;
                txtesyali.Text = c.Esyalimi;
                cmbil.Text = c.Il;
                cmbilce.Text = c.Ilce;
                txtisitma.Text = c.Isitma;
                txtSahibi.Text = c.MulkSahibiAdi;
                txtIletisim.Text = c.MulkSahibiIletisim;
                islem<IsyeriBi>.GetDataWithIndex(secili);

            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
