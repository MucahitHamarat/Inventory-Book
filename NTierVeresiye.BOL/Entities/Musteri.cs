using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresiye.BOL.Entities
{
    [Table("Müşteri")]
    public class Musteri
    {
        public int ID { get; set; }
        //[Column(TypeName = "Varchar"), StringLength(50)]
        public string Ad { get; set; }
        //[Column(TypeName = "Varchar"), StringLength(50)]
        public string Soyad { get; set; }
        //[Column(TypeName = "Varchar"), StringLength(50)]
        public string Unvan { get; set; }
        public string SabitTelefon { get; set; }
        public string CepTelefon { get; set; }
        public string FaxTelefon { get; set; }
        public string email { get; set; }
        //[Column(TypeName = "Varchar"), StringLength(11)]
        public string TC { get; set; }
        //[Column(TypeName = "Varchar"), StringLength(50)]
        public string Aciklama { get; set; }
        //[Column(TypeName = "Varchar"), StringLength(50)]
        public string Adres { get; set; }
        public EMusteriGrubu MusteriGrubu { get; set; }
       
    }
     public enum EMusteriGrubu
    {
        Bayiler =1,
        Aile,
        Arkadaş,
        YabancıMüşteri
    }
}
