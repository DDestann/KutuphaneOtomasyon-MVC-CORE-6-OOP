using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class KullaniciHareket : BaseEntity
    {
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }

        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
