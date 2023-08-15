using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class EmanetKitap : BaseEntity
    {
        public DateTime KitapIadeTarihi { get; set; }
        public DateTime KitapAlisTarihi { get; set; }
        public int KitapSayisi { get; set; }
        public int UyeId { get; set; }
        public Uye Uye { get; set; }
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }
    }
}
