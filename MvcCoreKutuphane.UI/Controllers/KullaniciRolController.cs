using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcCoreKutuphane.AppData.AppDataContext;
using MvcCoreKutuphane.DAL.DAL;
using MvcCoreKutuphane.Entities.Entity;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class KullaniciRolController : Controller
    {
        KullaniciRolDAL dal = new KullaniciRolDAL();
        KutuphaneContextDb db = new KutuphaneContextDb();
        public IActionResult Index()
        {
            return View(dal.Include("KullaniciRols"));
        }
        public IActionResult Insert()
        {
            var list = new SelectList(db.Rols, "Id", "Roller");
            ViewBag.Droplist=list;

            return View();
        }
        [HttpPost]
        public IActionResult Insert(KullaniciRol kullaniciRol)
        {
            dal.Insert(kullaniciRol);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            dal.Delete(id);
            return View("Index");
        }

        public IActionResult Update(int id)
        {
            var get = dal.GetById(id);

            var list = new SelectList(db.Rols, "Id", "Roller",db.KullaniciRols);
            ViewBag.Droplist = list;

            return View("Update",get);
        }
        [HttpPost]
        public IActionResult Update(KullaniciRol kullaniciRol)
        {
            dal.Update(kullaniciRol);
            return RedirectToAction("Index");
        }


    }
}
