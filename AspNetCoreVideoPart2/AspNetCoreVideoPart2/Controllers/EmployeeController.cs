using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
   
    public class EmployeeController : Controller
    {
       
        public ContentResult Name()
        {
            return Content("Jonas");
        }
        public ContentResult Country()
        {
            return Content("Swedan");
        }
        
        public ContentResult Index()
        {
            return Content("Hello From Employee");
        }
    }
}