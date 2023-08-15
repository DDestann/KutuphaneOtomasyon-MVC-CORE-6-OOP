using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class KitapHareketController : Controller
    {
        KitapHareketDAL dal = new KitapHareketDAL();
        public IActionResult Index()
        {
            return View();
        }
    }
}
