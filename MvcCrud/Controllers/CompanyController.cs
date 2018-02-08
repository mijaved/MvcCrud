using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrud.Models;

namespace MvcCrud.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var models = new Company().GetRandaomCompany();

            return View(models);
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            var model = new Company();
            return View(model);
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            var model = new Company();
            return View(model);
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(Company model) //FormCollection collection
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

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new Company();
            return View(model);
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Company model) //FormCollection collection
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

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
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
