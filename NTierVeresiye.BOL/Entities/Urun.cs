using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresiye.BOL.Entities
{
    [Table("Ürün")]
    public class Urun
    {//ürün eklede combobox eklediğin tedarikçi listesinden seçtiriyor.o listenin olduğu yerde modifier
     //public yapacaksın.
        public int ID { get; set; }
        [Column(TypeName = "Varchar"), StringLength(50)]
        public string BarkodUrun { get; set; }
        [Column(TypeName = "Varchar"), StringLength(50)]
        public string Ad { get; set; }
        [Column(TypeName = "Varchar"), StringLength(50)]
        public string Miktar { get; set; }
        public EBirim Birim { get; set; }
        public float AlisFiyati { get; set; }
        public float SatisFiyati { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime SKT { get; set; }
        public int MyProperty { get; set; }
        //public Tedarikci Tedarikci { get; set; }

    }
        public enum EBirim
    {
        ADET=1,
        KUTU,
        GRAM,
        KİLO,
        TON,
        METRE,
        METREKARE,
        
    }
}
