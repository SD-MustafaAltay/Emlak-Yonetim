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

namespace _18_Ocak_Emlakci_Prog_Generic.Ekranlar.IsYeri
{
    public partial class IsYeriFrm : FrmBase<IsyeriBi>
    {
        public IsYeriFrm()
        {
            InitializeComponent();
        }
        public override void EklemetFormuAc()
        {

           
            IsYeriEklemeFrm a = new IsYeriEklemeFrm();
            
            a.ShowDialog();

        }
        public override void DuzenlemeFormuAc(int index)
        {
            IsYeriEklemeFrm a = new IsYeriEklemeFrm();
            a.secili = index;
            a.ShowDialog();
        }

        private void IsYeriFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
