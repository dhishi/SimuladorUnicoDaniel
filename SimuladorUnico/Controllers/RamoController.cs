using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimuladorUnico.Controllers
{
    public class RamoController : Controller
    {
        // GET: Ramo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ramo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ramo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ramo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ramo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ramo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ramo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ramo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
