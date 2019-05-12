using NTierVeresiye.BLL.Repositories;
using NTierVeresiye.BOL.Entities;
using NTierVeresiye.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierVrsy.WFUI.MusteriFormlari
{
    public partial class frmMusteriDuzeltSil : Form
    {
        public frmMusteriBul frm2;
        SqlRepositoryVeresiye<Musteri> musteriRepo = new SqlRepositoryVeresiye<Musteri>();
        SqlVeresiyeContext db = new SqlVeresiyeContext();
        public frmMusteriDuzeltSil()
        {
            InitializeComponent();
            frm2 = new frmMusteriBul();
            frm2.frm1 = this;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            frmMusteriBul frmDz = new frmMusteriBul();
            
            frmDz.ShowDialog();
            //Environment.Exit(0);
            //Application.Exit();
            this.Close();
        }
        
        private void btnMusGuncelle_Click(object sender, EventArgs e)
        {
          
           
            db.Database.ExecuteSqlCommand("update Müşteri set " +
                "Ad=@p0," +
                "Soyad=@p1," +
                "Unvan=@p2," +
                "SabitTelefon=@p3," +
                "CepTelefon=@p4," +
                "FaxTelefon=@p5," +
                "email=@p6," +
                "TC=@p7," +
                "Aciklama=@p8," +
                "Adres=@p9," +
                "MusteriGrubu=@p10 where ID=@p11", 
                txtMusAd.Text,
                txtMusSoyad.Text,
                txtMusUnvan.Text,
                maskedBTel.Text,
                maskedBGSM.Text,
                maskedBFax.Text,
                txtEmail.Text,
                txtTC.Text,
                richTextBoxMusAciklama.Text,
                richTextBoxMusAdres.Text,
                cmbMusGrubu.SelectedIndex,frm2.id
                );
            }

       
         
        
    }
}
