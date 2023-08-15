using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;
using MvcCoreKutuphane.Entities.Entity;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class YayinevController : Controller
    {
        YayinEvDAL dal = new YayinEvDAL();
        public IActionResult Index()
        {

            return View(dal.GetAll());
        }

        public IActionResult Insert()
        {
            return View("Insert");
        }
        [HttpPost]
        public IActionResult Insert(YayinEv yayinEv)
        {
            yayinEv.Tarih = DateTime.Now;
            dal.Insert(yayinEv);
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
        public IActionResult Update(YayinEv yayinEv)
        {
            dal.Update(yayinEv);
            return RedirectToAction("Index");
        }
    }
}
