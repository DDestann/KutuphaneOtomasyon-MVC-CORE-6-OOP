using Microsoft.AspNetCore.Mvc;
using MvcCoreKutuphane.DAL.DAL;
using MvcCoreKutuphane.Entities.Entity;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class RolController : Controller
    {
        RolDAL dal = new RolDAL();
        public IActionResult Index()
        {

            return View(dal.GetAll());
        }

        public IActionResult Insert()
        {
            return View("Insert");
        }
        [HttpPost]
        public IActionResult Insert(Rol rol)
        {
           
            dal.Insert(rol);
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
        public IActionResult Update(Rol rol)
        {
            dal.Update(rol);
            return RedirectToAction("Index");
        }
    }
}
