using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class KullaniciController : Controller
    {
        KullaniciDAL dal = new KullaniciDAL();
        public IActionResult Index()
        {
            return View();
        }
    }
}
