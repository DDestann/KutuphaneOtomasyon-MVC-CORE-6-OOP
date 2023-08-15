using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class YayinEv : BaseEntity
    {

        public string Ad { get; set; }
        public DateTime Tarih { get; set; }

        public ICollection<Kitap> Kitaps { get; set; }
    }
}
