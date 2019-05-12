using NTierVrsy.WFUI.MusteriFormlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierVrsy.WFUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteri frmMus = new frmMusteri();
            //frmMus.MdiParent = this;
            frmMus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMusteriListesi frmMusList = new frmMusteriListesi();
            //frmMusList.MdiParent = this;
            frmMusList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriDuzeltSil frmDz = new frmMusteriDuzeltSil();
            frmDz.ShowDialog();
            

        }

        private void btnTedEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
