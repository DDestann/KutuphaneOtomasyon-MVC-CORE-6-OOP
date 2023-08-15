using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcCoreKutuphane.AppData.AppDataContext;
using MvcCoreKutuphane.DAL.DAL;
using MvcCoreKutuphane.Entities.Entity;

namespace MvcCoreKutuphane.UI.Controllers
{
    public class KitapController : Controller
    {
        KitapDAL dal = new KitapDAL();
        KutuphaneContextDb db = new KutuphaneContextDb();
        public IActionResult Index()
        {
            var list = dal.Include("Tur","Yazar","YayinEv").Where(x => x.Silindimi == false);
           
            return View(list);
        }

        public IActionResult IsDelete()
        {
            var list = dal.Include("Tur", "Yazar", "YayinEv").Where(x => x.Silindimi == true);

            return View(list);
        }

        public IActionResult Insert()
        {
            ViewBag.droptur = new SelectList(db.Turs, "Id", "Ad");
            ViewBag.dropyazar = new SelectList(db.Yazars, "Id", "FullAd");
            ViewBag.dropyayinev = new SelectList(db.YayinEvs, "Id", "Ad");



            return View();
        }
        [HttpPost]
        public IActionResult Insert(Kitap kitap)
        {
            dal.Insert(kitap);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
           var get =db.Kitaps.Where(x=>x.Id ==id).FirstOrDefault();
            get.Silindimi = true;

            dal.Update(get);

            return RedirectToAction("Index");
        }

        public IActionResult HasDelete(int id)
        {
            dal.Delete(id);
            return RedirectToAction("IsDelete");
        }


        public IActionResult Update(int id)
        {
            var get = dal.GetById(id);

            ViewBag.droptur = new SelectList(db.Turs, "Id", "Ad",db.Kitaps);
            ViewBag.dropyazar = new SelectList(db.Yazars, "Id", "FullAd" , db.Kitaps);
            ViewBag.dropyayinev = new SelectList(db.YayinEvs, "Id", "Ad", db.Kitaps);

            return View("Update",get);
        }
        [HttpPost]
        public IActionResult Update(Kitap kitap , int id)
        {
            if (kitap.Silindimi==false)
            {
                kitap.GuncellemeTarihi = DateTime.Now;
                dal.Update(kitap);
                return RedirectToAction("Index");
            }
            var get = db.Kitaps.Where(x => x.Id == id).FirstOrDefault();
            get.Silindimi = true;

            dal.Update(get);
            return RedirectToAction("Index");
        }


        }
}
