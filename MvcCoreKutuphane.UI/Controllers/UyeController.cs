using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class UyeController : Controller
    {
        UyeDAL dal = new UyeDAL();
        public IActionResult Index()
        {
            return View();
        }
    }
}
