using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class Yazar : BaseEntity
    {
        public string Ad { get; set; }
        public string FullAd { get; set; }
        public string Soyad { get; set; }

        public DateTime Tarih { get; set; }= DateTime.Now;

        public ICollection<Kitap> Kitaps { get; set; }
    }
}
