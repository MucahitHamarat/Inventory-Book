using NTierVeresiye.BLL.Repositories;
using NTierVeresiye.BOL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierVrsy.WFUI.UrunFormlari
{
    public partial class frmUrun : Form
    {
        SqlRepositoryVeresiye<Urun> urunRepo = new SqlRepositoryVeresiye<Urun>();
        public frmUrun()
        {
            InitializeComponent();
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            yukle();
        }
        void yukle()
        {
            gridUrunEkle.DataSource = urunRepo.Listele().ToList();
        }
    }
}
