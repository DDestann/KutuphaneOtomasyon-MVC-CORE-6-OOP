using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Entities.Entity
{
    public class Rol : BaseEntity
    {
        public string Roller { get; set; }

        public ICollection<KullaniciRol> KullaniciRols { get; set; }
    }
}
