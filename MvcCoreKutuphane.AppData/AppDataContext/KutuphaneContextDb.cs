using Microsoft.EntityFrameworkCore;
using MvcCoreKutuphane.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.AppData.AppDataContext
{
    public class KutuphaneContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5APVMI5; database=KutuphaneDb; integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<Tur> Turs { get; set; }
        public DbSet<Uye>  Uyes { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<YayinEv> YayinEvs { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<KullaniciHareket> KullaniciHarekets { get; set; }
        public DbSet<KullaniciRol> KullaniciRols { get; set; }
        public DbSet<KitapKayitHareket> KitapKayitHarekets { get; set; }
        public DbSet<KitapHareket> KitapHarekets { get; set; }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<EmanetKitap> EmanetKitaps { get; set; }
    }
}
