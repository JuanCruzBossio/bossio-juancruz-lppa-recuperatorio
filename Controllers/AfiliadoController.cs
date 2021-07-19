using bossio_juancruz_lppa_recuperatorio.Data;
using bossio_juancruz_lppa_recuperatorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bossio_juancruz_lppa_recuperatorio.Controllers
{
    public class AfiliadoController : Controller
    {
        BaseDataService<Afiliado> db;
        public AfiliadoController()
        {
            db = new BaseDataService<Afiliado>();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var lista = db.Get();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Afiliado modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Create(modelo);
                    return RedirectToAction("Index");
                }
                catch
                {
                }

            }
            return View(modelo);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var modelo = db.GetById(id);
            if (modelo == null)
            {
                return HttpNotFound();
            }
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Edit(Afiliado modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(modelo);
                    return RedirectToAction("Index");
                }
                catch
                {

                }

            }
            return View(modelo);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var modelo = db.GetById(id);
            if (modelo == null)
            {
                return HttpNotFound();
            }
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Delete(Afiliado modelo)
        {
            try
            {
                db.Delete(modelo.Id);
                return RedirectToAction("Index");
            }
            catch
            {
            }
            return View(modelo);
        }
    }
}
