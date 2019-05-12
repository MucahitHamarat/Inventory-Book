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

namespace NTierVrsy.WFUI
{
    public partial class frmMusteri : Form
    {
        SqlVeresiyeContext db = new SqlVeresiyeContext();
           SqlRepositoryVeresiye<Musteri> musteriRepo = new SqlRepositoryVeresiye<Musteri>();    
        //private SqlRepositoryVeresiye<Tedarikci> tedarikciRepo = new SqlRepositoryVeresiye<Tedarikci>();    
        //private SqlRepositoryVeresiye<Urun> urunRepo = new SqlRepositoryVeresiye<Urun>();    
        
        public frmMusteri()  
        {
            InitializeComponent();
        }
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            yukle();
        }
        void yukle()
        {//
            gridMusteriEkle.DataSource = musteriRepo.Listele().Select(s => new
            {
                ID = s.ID,
                MüşteriAd = s.Ad,
                MüşteriSoyad = s.Soyad,
                Ünvan = s.Unvan,
                Telefon = s.SabitTelefon,
                GSM = s.CepTelefon,
                Fax = s.FaxTelefon,
                Email = s.email,
                TCKimlikNo = s.TC,
                Açıklama = s.Aciklama,
                Adres = s.Adres,
                // gridMusteriEkle.DataSource = db.Database.SqlQuery<Musteri>("select ID,Ad,Soyad,Unvan,SabitTelefon," +
                //     "CepTelefon,FaxTelefon," +
                //     " email,TC,Aciklama,Adres,MusteriGrubu from Müşteri").
                //Select(s => new { s.ID, s.Ad, s.Soyad, s.Unvan, s.SabitTelefon,
                //    s.CepTelefon,s.FaxTelefon,s.email
                //,s.TC,s.Aciklama,s.Adres,s.MusteriGrubu}).ToList();


            }).ToList();
            cmbMusGrubu.DataSource = Enum.GetNames(typeof(EMusteriGrubu));
         }
        private void button1_Click(object sender, EventArgs e)
        {
            if (chBoxHesabiniAc.Checked == true)
                db.Database.ExecuteSqlCommand("Insert into Müşteri Values(@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", txtMusAd.Text, txtMusSoyad.Text, txtMusUnvan.Text, maskedBTel.Text, maskedBGSM.Text, maskedBFax.Text, txtEmail.Text, txtTC.Text,  richTextBoxMusAciklama.Text, richTextBoxMusAdres.Text, (EMusteriGrubu)Enum.Parse(typeof(EMusteriGrubu), cmbMusGrubu.Text)); 

            //musteriRepo.Insert(new Musteri
            //{
            //    Ad = txtMusAd.Text,
            //    Soyad = txtMusSoyad.Text,
            //    Unvan = txtMusUnvan.Text,
            //    SabitTelefon = maskedBTel.Text,
            //    CepTelefon = maskedBGSM.Text,
            //    FaxTelefon = maskedBFax.Text,
            //    email = txtEmail.Text,
            //    TC = txtTC.Text,
            //    MusteriGrubu = (EMusteriGrubu)Enum.Parse(typeof(EMusteriGrubu), cmbMusGrubu.Text),
            //    Aciklama = richTextBoxMusAciklama.Text,
            //    Adres = richTextBoxMusAdres.Text


        //});
            txtMusAd.Text = "";
            yukle();

            //dataGridView1.DataSource = db.Database.SqlQuery<Product>("select ID,Name,BrandID from Product Where BrandID=" + textBox1.Text).Select(s => new { s.ID, s.Name }).ToList();
            //dataGridView1.DataSource = db.Database.SqlQuery<Product>("select ID,Name,BrandID from Product Where BrandID=@p0", textBox1.Text).Select(s => new { s.ID, s.Name }).ToList();

            //db.Database.ExecuteSqlCommand("Insert into Product Values('"+textBox1.Text+"',1)");
            //db.Database.ExecuteSqlCommand("Insert into Product Values(@p0,@p1)",textBox1.Text,2);
            //db.Database.ExecuteSqlCommand("exec sp_urunEkle @p0,@p1", textBox1.Text, 2);

            //dataGridView1.DataSource = db.Database.SqlQuery<Product>("select ID,Name,BrandID from Product").Select(s => new { s.ID, s.Name }).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {//iptal Butonu
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
