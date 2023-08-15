using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class Kullanici : BaseEntity
    {
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime Tarih { get; set; }

        public ICollection<KullaniciRol> KullaniciRols { get; set; }
        public ICollection<KitapHareket> KitapHarekets { get; set; }
        public ICollection<KullaniciHareket> KullaniciHarekets  { get; set; }
        public ICollection<KitapKayitHareket>  KitapKayitHarekets  { get; set; }



    }
}
