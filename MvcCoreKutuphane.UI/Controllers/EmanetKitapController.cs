using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class EmanetKitapController : Controller
    {EmanetKitapDAL dal = new EmanetKitapDAL();
        public IActionResult Index()
        {
            return View();
        }
    }
}
