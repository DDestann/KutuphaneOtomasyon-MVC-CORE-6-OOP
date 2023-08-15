using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class KitapHareket : BaseEntity
    {
        public string YapilanIslem { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public int UyeId { get; set; }
        public Uye Uye { get; set; }
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }
    }
}
