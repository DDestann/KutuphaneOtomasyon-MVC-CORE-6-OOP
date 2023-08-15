using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class KitapKayitHareket : BaseEntity
    {
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string YapilanIslem { get; set; }
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }


    }
}
