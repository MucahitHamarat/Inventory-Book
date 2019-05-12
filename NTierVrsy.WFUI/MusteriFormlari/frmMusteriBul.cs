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
    public partial class frmMusteriBul : Form
    {
        public frmMusteriDuzeltSil frm1; 
        //SqlVeresiyeContext
        SqlVeresiyeContext db = new SqlVeresiyeContext();
        SqlRepositoryVeresiye<Musteri> musteriRepo = new SqlRepositoryVeresiye<Musteri>();
        public frmMusteriBul()
        {
            InitializeComponent();
        }
       
        
        private void frmMusteriBul_Load(object sender, EventArgs e)
        {
            //gridMusBul.DataSource = db.Database.SqlQuery<Musteri>("select ID,Ad,Soyad,Unvan,CepTelefon from Müşteri").
            //    Select(s => new {s.ID,s.Ad,s.Soyad,s.Unvan,s.CepTelefon }).ToList();


            musteriRepo.Listele().Select(s => new
            {
                ID = s.ID,
                MüşteriAd = s.Ad,
                MüşteriSoyad = s.Soyad,
                GSM = s.CepTelefon,
                Adres = s.Adres


            }).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Musteri> musteris = new List<Musteri>();
            if (!string.IsNullOrEmpty(txtAdaGore.Text))
            {
                //Databaseden getirsin 
                gridMusBul.DataSource = db.Database.SqlQuery<Musteri>("Select * from Müşteri where Ad like " + "'%" + txtAdaGore.Text + "%'").ToList();

            }
            if (!string.IsNullOrEmpty(txtSoyadaGore.Text))
            {
                //Repositoryden Getirsin listeleri
                musteris = musteriRepo.Listele().Where(w => w.Soyad.Contains(txtSoyadaGore.Text)).ToList();
                gridMusBul.DataSource = musteris;

                
            }
            if (!string.IsNullOrEmpty(txtUnvanaGore.Text))
            {
                //Repositoryden Getirsin listeleri
                musteris = musteriRepo.Listele().Where(w => w.Unvan.Contains(txtUnvanaGore.Text)).ToList();
                gridMusBul.DataSource = musteris;

            }
            //if (!string.IsNullOrEmpty(txtUnvanaGore.Text)&& !string.IsNullOrEmpty(txtSoyadaGore.Text))
            //{
            //    Repositoryden Getirsin listeleri
            //    musteris = musteriRepo.Listele().Where(w =>new { w.Ad.Contains(txtAdaGore.Text), w.Soyad.Contains(txtSoyadaGore.Text) }).ToList();
            //    gridMusBul.DataSource = musteris;
            //    datagrid.Datasource = db.Products.Where(w => w.Name.Contains("a")).ToList();
            //    select en sonda olmalı
            //}

        }

        //*/bu id'yi public yapmazsan diğer formdan çağıramazsın.*/
        //public int id = 3;
        private void gridMusBul_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            frmMusteriDuzeltSil frmx = new frmMusteriDuzeltSil();
            frmx.label12.Text = gridMusBul.CurrentRow.Cells["ID"].Value.ToString();
            int  id = Convert.ToInt32(frmx.label12.Text);//bu da public olmuş oldu.
            Musteri m = musteriRepo.Listele(s => s.ID == id).First();
            frmx.txtMusAd.Text = m.Ad;
            frmx.txtMusSoyad.Text = m.Soyad;
            frmx.txtMusUnvan.Text = m.Unvan;
            frmx.maskedBTel.Text = m.SabitTelefon;
            frmx.maskedBGSM.Text = m.CepTelefon;
            frmx.maskedBFax.Text = m.FaxTelefon;
            frmx.txtEmail.Text = m.email;
            frmx.txtTC.Text = m.TC;
            frmx.cmbMusGrubu.SelectedItem = m.MusteriGrubu;
            frmx.richTextBoxMusAdres.Text = m.Adres;
            frmx.richTextBoxMusAciklama.Text = m.Aciklama;
            this.Close();
            frmx.ShowDialog();
            //db.Database.ExecuteSqlCommand("exec sp_IdGoreMusteriGetir @p0",grid );
        }

        private void btnMusSil_Click(object sender, EventArgs e)
        {
            db.Database.ExecuteSqlCommand("Delete Müşteri Where ID=@p0", gridMusBul.CurrentRow.Cells[0].Value);
            //Yukle();
            gridMusBul.DataSource = db.Database;
        }


    }
}
