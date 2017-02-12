using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListProject.DataProviders;

namespace ToDoListProject.Models
{
    public class TaskGridItemModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int ProjectId { get; set; }
        public string TaskName { get; set; }      
    }
}