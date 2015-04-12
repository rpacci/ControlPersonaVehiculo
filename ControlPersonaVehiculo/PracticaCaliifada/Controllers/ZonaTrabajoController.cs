using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlPersonaVehiculo.Services;
using ControlPersonaVehiculo.Dominio;

namespace PracticaCaliifada.Controllers
{
    public class ZonaTrabajoController : Controller
    {
        // GET: ZonaTrabajo
        public ActionResult Index()
        {
            try
            {
                var ZonaTrabajoService = new ZonaTrabajoService();
                var ZonasDeTrabajo = ZonaTrabajoService.SelectAll();
                return View(ZonasDeTrabajo);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorDescription = ex.ToString();
                return View("Error");
            }


            //return View();
        }

        // GET: ZonaTrabajo/Details/5
        public ActionResult Details(int? id)
        {

            try
            {
                var ZonaTrabajoService = new ZonaTrabajoService();
                var ZonaTrabajo = ZonaTrabajoService.Select(new ZonaTrabajo { ID = id.Value });
                return View(ZonaTrabajo);
            }
            catch (Exception ex) 
            {
                ViewBag.ErrorDescription = ex.ToString();
                return View("Error");
            }

        }

        // GET: ZonaTrabajo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZonaTrabajo/Create
        [HttpPost]
        public ActionResult Create(ZonaTrabajo _ZonaTrabajo)
        {
            if (!ModelState.IsValid)
                return View(_ZonaTrabajo);
            try
            {

                var ZonaTrabajoService = new ZonaTrabajoService();
                ZonaTrabajoService.Insert(_ZonaTrabajo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(_ZonaTrabajo);
            }
        }

        // GET: ZonaTrabajo/Edit/5
        public ActionResult Edit(int? id)
        {
            var ZonaTrabajoServices = new ZonaTrabajoService();
            var zonatrabajo = ZonaTrabajoServices.Select(new ZonaTrabajo { ID = id.Value });
            return View(zonatrabajo);
        }

        // POST: ZonaTrabajo/Edit/5
        [HttpPost]
        public ActionResult Edit(ZonaTrabajo _ZonaTrabajo)
        {
            if (!ModelState.IsValid)
                return View(_ZonaTrabajo);
            try
            {
                var ZonaTrabajoService = new ZonaTrabajoService();
                ZonaTrabajoService.Update(_ZonaTrabajo);
                return RedirectToAction("Index");          
            }
            catch
            {
                return View();
            }
        }

        // GET: ZonaTrabajo/Delete/5
        public ActionResult Delete(int? id)
        {
            var ZonaTrabajoServices = new ZonaTrabajoService();
            var zonatrabajo = ZonaTrabajoServices.Select(new ZonaTrabajo { ID = id.Value });
            return View(zonatrabajo);
        }

        // POST: ZonaTrabajo/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, ZonaTrabajo _ZonaTrabajo)
        {
            try
            {
                var ZonaTrabajoServices = new ZonaTrabajoService();
                ZonaTrabajoServices.Delete(new ZonaTrabajo { ID = id.Value });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
