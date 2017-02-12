using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListProject.Models;

namespace ToDoListProject.DataProviders
{
    public class DataProvider 
    {
        private static readonly ToDoListContext Db = new ToDoListContext();
        public static List<Task> GetAllTasks()
        {
            
            try
            {
                return Db.TasksDto.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception(); 
            }
        }

        public static Task GetTaskById(int taskId)
        {
            try
            {
                return Db.TasksDto.FirstOrDefault(x=>x.TaskId == taskId);
            }
            catch (Exception exception)
            {
                throw new Exception();
            }
        }

        public static List<Project> GetAllProjects()
        {
            try
            {
                return Db.ProjectsDto.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception();
            }
        }

        public static void SetDefaultProjects()
        {
            Db.ProjectsDto.Add(new Project { ProjectName = "Home"});
            Db.ProjectsDto.Add(new Project { ProjectName = "Work" });
        }

        public static string GetProjectNameById(int id)
        {
                var model = Db.ProjectsDto.FirstOrDefault(x=>x.ProjectId==id);
                if (model != null)
                    return model.ProjectName;
                return string.Empty;
        }

        public static int SaveTaskToBase(Task model)
        {
            Db.TasksDto.Add(model);
            Db.SaveChanges();
            var id = Db.TasksDto.ToList().Last().TaskId;
            return id;
        }

        public static void DeleteTaskFromBase(int taskId)
        {
            var model = Db.TasksDto.FirstOrDefault(x => x.TaskId == taskId);
            Db.TasksDto.Remove(model);
            Db.SaveChanges();
        }

        public static void UpdateTask(int taskId, int projectId, string taskName)
        {
            var model = Db.TasksDto.FirstOrDefault(x => x.TaskId == taskId);
            model.ProjectId = projectId;
            model.TaskName = taskName;
            Db.SaveChanges();
        }
    }
}