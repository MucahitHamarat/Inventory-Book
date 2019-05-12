using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresiye.BOL.Entities
{
    [Table("Tedarikçi")]
    public class Tedarikci
    {
        public int ID { get; set; }
        [Column(TypeName = "Varchar"), StringLength(50)]
        public string TedarikciAdi { get; set; }
        [Column(TypeName = "Varchar"), StringLength(50)]
        public string Sektor { get; set; }
        [Column(TypeName = "Varchar"), StringLength(50)]
        public string YetkiliAd { get; set; }
        [Column(TypeName = "Varchar"), StringLength(50)]
        public string YetkiliSoyad { get; set; }
        [Column(TypeName = "Varchar"), StringLength(50)]
        
        public string SabitTelefon { get; set; }
        public string CepTelefon { get; set; }
        public string FaxTelefon { get; set; }
        public string email { get; set; }
        [Column(TypeName = "Varchar"), StringLength(40)] 
        public string VergiDairesi { get; set; }
        [Column(TypeName = "Varchar"), StringLength(40)]
        public string VergiNo { get; set; }
        [Column(TypeName = "Varchar"), StringLength(11)]
        public string TC { get; set; }
        [Column(TypeName = "Varchar"), StringLength(200)]
        public string Adres { get; set; }
        [Column(TypeName = "Varchar"), StringLength(200)]
        public string AciklamaTed { get; set; }
        //public Urun Urun { get; set; }

    }
}
