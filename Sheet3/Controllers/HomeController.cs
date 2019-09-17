using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Entities;
using Sheet3.Models;

namespace Sheet3.Controllers
{
    public class HomeController : Controller
    {
        public Model model = new Model();

        // GET: Home
        public ActionResult Index()
        {
            var records = model.GetList();
            return View(records);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ContactRecord cR)
        {
            model.AddRecord(cR);

            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var currentRecord = model.Details(id);

            return View(currentRecord);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var currentRecord = model.Details(id);

            return View(currentRecord);
        }
        [HttpPost]
        public ActionResult Delete(ContactRecord cR)
        {
            model.Delete(cR);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var currentRecord = model.Details(id);

            return View(currentRecord);
        }
        [HttpPost]
        public ActionResult Edit(ContactRecord cR)
        {
            model.Update(cR);

            return RedirectToAction("Index");
        }
    }
}