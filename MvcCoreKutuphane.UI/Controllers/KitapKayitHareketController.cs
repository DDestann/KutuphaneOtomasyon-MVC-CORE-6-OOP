using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class KitapKayitHareketController : Controller
    {
        KitapKayitHareketDAL dal = new KitapKayitHareketDAL();
        public IActionResult Index()
        {
            return View();
        }
    }
}
