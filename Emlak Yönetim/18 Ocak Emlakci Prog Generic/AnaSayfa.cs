using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_Ocak_Emlakci_Prog_Generic
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void emlaklariGoruntulaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tumEmlaklariGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekranlar.TumEmlaklar.TumEmlaklarFrm eml = new  Ekranlar.TumEmlaklar.TumEmlaklarFrm();
            eml.ShowDialog();
        }

        private void konutlariGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekranlar.Konutlar.KonutFrm knt = new Ekranlar.Konutlar.KonutFrm();
            knt.ShowDialog();
        }

        private void isYeriGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekranlar.IsYeri.IsYeriFrm kk = new Ekranlar.IsYeri.IsYeriFrm();
            kk.ShowDialog();

        }

        private void arsaGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Ekranlar.Arsalar.ArsaLstFrm ars = new Ekranlar.Arsalar.ArsaLstFrm();
             ars.ShowDialog();
            
            
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
