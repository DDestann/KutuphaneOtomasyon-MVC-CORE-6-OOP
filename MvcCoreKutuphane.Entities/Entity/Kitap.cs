using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class Kitap : BaseEntity
    {
     
        public string Ad { get; set; }
        public int Stok { get; set; }
        public int SayfaSayisi { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklemeTarihi { get; set; } = DateTime.Now;
        public DateTime GuncellemeTarihi { get; set; }= DateTime.Now;
        public bool Silindimi { get; set; } = false;



        public int TurId { get; set; }
        public Tur Tur { get; set; }
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }
        public int YayinEvId { get; set; }
        public YayinEv YayinEv { get; set; }

        public ICollection<KitapHareket> KitapHarekets { get; set; }
        public ICollection<KitapKayitHareket> KitapKayitHarekets { get; set; }
        public ICollection<EmanetKitap> EmanetKitaps { get; set; }

    }
}
