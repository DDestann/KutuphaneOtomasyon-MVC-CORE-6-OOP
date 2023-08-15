using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;
using MvcCoreKutuphane.UI.Models;
using System.Diagnostics;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class HomeController1 : Controller
    {
        private readonly ILogger<HomeController1> _logger;

        public HomeController1(ILogger<HomeController1> logger)
        {
            _logger = logger;
        }

        TurDAL DAL = new TurDAL();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}