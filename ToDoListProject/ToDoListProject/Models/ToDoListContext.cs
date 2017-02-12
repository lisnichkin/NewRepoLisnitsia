using System.Data.Entity;
using System.Web.Configuration;

namespace ToDoListProject.Models
{
    public class ToDoListContext : DbContext
    {
        public DbSet<Task> TasksDto { get; set; }
        public DbSet<Project> ProjectsDto { get; set; }
    }
}