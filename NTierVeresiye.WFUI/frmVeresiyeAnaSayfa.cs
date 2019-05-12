using NTierVeresiye.WFUI.Musteri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierVeresiye.WFUI
{
    public partial class frmVeresiyeAnaSayfa : Form
    {
        public frmVeresiyeAnaSayfa()
        {
            InitializeComponent();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frmMusEkle = new frmMusteriEkle();
            frmMusEkle.MdiParent = this;
            frmMusEkle.ShowDialog();
        }

        private void frmVeresiyeAnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
