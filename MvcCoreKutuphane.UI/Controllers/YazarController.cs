using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;
using MvcCoreKutuphane.Entities.Entity;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class YazarController : Controller
    {
        YazarDAL dal = new YazarDAL();
        public IActionResult Index()
        {

            return View(dal.GetAll());
        }

        public IActionResult Insert()
        {
            return View("Insert");
        }
        [HttpPost]
        public IActionResult Insert(Yazar  yazar)
        {
            yazar.FullAd = yazar.Ad + " " + yazar.Soyad;
            dal.Insert(yazar);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {

            dal.Delete(id);

            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var get = dal.GetById(id);
            return View("Update", get);
        }
        [HttpPost]
        public IActionResult Update(Yazar  yazar)
        {
            yazar.FullAd = yazar.Ad + " " + yazar.Soyad;
            dal.Update(yazar);
            return RedirectToAction("Index");
        }
    }
}
