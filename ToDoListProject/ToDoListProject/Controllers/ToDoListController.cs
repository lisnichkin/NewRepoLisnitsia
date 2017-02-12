using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoListProject.Controllers
{
    public class ToDoListController : Controller
    {
        // GET: ToDoList
        public ActionResult Index()
        {
            return View();
        }

        // GET: ToDoList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ToDoList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDoList/Create
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

        // GET: ToDoList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ToDoList/Edit/5
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

        // GET: ToDoList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ToDoList/Delete/5
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
