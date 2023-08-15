using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class Uye : BaseEntity
    {
       
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string ResimYolu { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public int Okundu { get; set; }
        public DateTime Tarih { get; set; }


        public ICollection<KitapHareket> KitapHarekets { get; set; }
        public ICollection<EmanetKitap> EmanetKitaps  { get; set; }

    }
}
