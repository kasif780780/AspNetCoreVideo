using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    public class EmployeeController : Controller
    {
        public string Name()
        {
            return "Jonas";
        }
        public string Country()
        {
            return "Swedan";
        }
        public string Index()
        {
            return "Hello From Employee";
        }
    }
}