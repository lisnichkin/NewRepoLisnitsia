using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListProject.DataProviders;

namespace ToDoListProject.Models
{
    public class GridModel
    {
        public List<SelectListItem> ProjectItems { get; set; }

        public List<TaskGridItemModel> TaskGridItem { get; set; }

        public  GridModel GetModel(List<Task> taskList)
        {
            var model = new GridModel();
            model.TaskGridItem=new List<TaskGridItemModel>();
            foreach (var item in taskList)
            {
                model.TaskGridItem.Add(ToModel(item));
            }
            model.ProjectItems = GetProjectItems(DataProvider.GetAllProjects());
            return model;
        }
        public  TaskGridItemModel ToModel(Task task)
        {
            return new TaskGridItemModel
            {
                Id = task.TaskId,
                ProjectName = DataProvider.GetProjectNameById(task.ProjectId),
                ProjectId = task.ProjectId,
                TaskName = task.TaskName
            };
        }

        public  List<SelectListItem> GetProjectItems(List<Project> listProjects)
        {
            var itemList = new List<SelectListItem>();
            foreach (var project in listProjects)
            {
                itemList.Add(new SelectListItem
                {
                    Value = project.ProjectId.ToString(),
                    Text = project.ProjectName
                });
            }
            return itemList;
        }
    }
}