using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class KullaniciHareketController : Controller
    {
        KullaniciHareketDAL dal = new KullaniciHareketDAL();
        public IActionResult Index()
        {
            return View();
        }
    }
}
