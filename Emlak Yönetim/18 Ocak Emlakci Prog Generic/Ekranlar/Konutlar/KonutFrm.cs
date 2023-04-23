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
    public partial class KonutFrm : FrmBase<KonutBi>
    {
        public KonutFrm()
        {
            InitializeComponent();
        }
        public override void EklemetFormuAc()
        {
            new KonutEklemeFrm().ShowDialog();
        }
        public override void DuzenlemeFormuAc(int index)
        {
            KonutEklemeFrm a = new KonutEklemeFrm();
            a.secili = index;
            a.ShowDialog();
        }

        private void KonutFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
