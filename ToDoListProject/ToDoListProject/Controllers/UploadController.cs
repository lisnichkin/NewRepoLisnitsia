using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoListProject.DataProviders;
using ToDoListProject.Models;

namespace ToDoListProject.Controllers
{
    public class UploadController : ApiController
    {
        [HttpPost]
        public void Post([FromBody] Task value)
        {
            DataProvider.SaveTaskToBase(value);
        }
    }
}
