using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;
using MvcCoreKutuphane.Entities.Entity;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class TurController : Controller
    {
        TurDAL dal = new TurDAL();
        public IActionResult Index()
        {

            return View(dal.GetAll());
        }

        public IActionResult Insert()
        {
            return View("Insert");
        }
        [HttpPost]
        public IActionResult Insert(Tur tur)
        {
            tur.Tarih = DateTime.Now;
            dal.Insert(tur);
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
            return View("Update",get);
        }
        [HttpPost]
        public IActionResult Update(Tur tur)
        {
            dal.Update(tur);
            return RedirectToAction("Index");
        }


    }
}
