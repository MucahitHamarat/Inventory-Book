using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WFXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter xmldosyasi = new XmlTextWriter("urun.xml", System.Text.UTF8Encoding.UTF8);
            //Daha önce bu isimle oluşturulan bir XML dosyası var ise, eski dosya silinir.
            xmldosyasi.Formatting = Formatting.Indented;
            // Dosya yapısını hiyerarşik olarak oluşturarak okunabilirliği arttırır.
            try
            {
                xmldosyasi.WriteStartDocument(); //Xml dökümanına ait declaration satırını oluşturur. Kısaca yazmaya başlar.
                xmldosyasi.WriteStartElement("urunler");
                xmldosyasi.WriteStartElement("urun");
                //urunler(root) ve urun etiketleri oluşturuldu.
                xmldosyasi.WriteAttributeString("id", "1");
                xmldosyasi.WriteElementString("ad", "Elma");
                xmldosyasi.WriteElementString("Tur", "gida");
                xmldosyasi.WriteElementString("fiyat", "5");
                //İçerik isim-değer çiftleri şeklinde ogretmen etiketinin içerisine element türünde eklendi.
                xmldosyasi.WriteEndElement();
                xmldosyasi.WriteEndElement();
                //urunler ve urun etiketleri sonlandırıldı.
                xmldosyasi.Close();
                //XML akışı sonlandırıldı.
                MessageBox.Show("XML Dosyası oluşturuldu");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: açıklama:" + ex.Message);
            }
        }
    }
}
