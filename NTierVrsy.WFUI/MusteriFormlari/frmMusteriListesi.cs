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

namespace NTierVrsy.WFUI
{
    public partial class frmMusteriListesi : Form
    {
        SqlRepositoryVeresiye<Musteri> musteriRepo = new SqlRepositoryVeresiye<Musteri>();
        public frmMusteriListesi()
        {
            InitializeComponent();
        }

        private void frmMusteriListesi_Load(object sender, EventArgs e)
        {
            
            gridMusList.DataSource = musteriRepo.Listele().Select(s => new
            {
                ID = s.ID,
                MüşteriAd = s.Ad,
                MüşteriSoyad = s.Soyad,
                GSM=s.CepTelefon,
                Adres=s.Adres

                
            }).ToList();
            
        }
    }
}
