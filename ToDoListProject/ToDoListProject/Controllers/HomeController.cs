using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListProject.DataProviders;
using ToDoListProject.Models;

namespace ToDoListProject.Controllers
{
    public class HomeController : Controller
    {
        private GridModel _grid { get; set; }

        public HomeController()
        {
            _grid = new GridModel();
        }
        public ActionResult Index()
        {
            var allTasks = DataProvider.GetAllTasks();
            var gridModel = _grid.GetModel(allTasks);
            return View(gridModel);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your app description page.";

        //    return View();
        //}

        public ActionResult SaveTask(string taskName,int projectId)
        {
            var taskId = DataProvider.SaveTaskToBase(new Task {ProjectId = projectId, TaskName = taskName});
            return Json(new { Id = taskId }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteTask(int taskId)
        {
            DataProvider.DeleteTaskFromBase(taskId);
            return new EmptyResult();
        }
        public ActionResult EditTask(string taskName, int projectId, int taskId)
        {
            DataProvider.UpdateTask(taskId,projectId,taskName);
            return new EmptyResult();
        }
        
    }
}
