using _18_Ocak_Emlakci_Prog_Generic.Ekranlar.Konutlar;
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
    public partial class ArsaLstFrm : FrmBase<ArsaBi>
    {
        public ArsaLstFrm()
        {
            InitializeComponent();
        }
        public override void EklemetFormuAc()
        {
            new ArsaEklemeFrm().ShowDialog();
        }
        public override void DuzenlemeFormuAc(int index)
        {

            ArsaEklemeFrm a = new ArsaEklemeFrm();
            a.secili = index;
            a.ShowDialog();
        }

        private void ArsaLstFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
