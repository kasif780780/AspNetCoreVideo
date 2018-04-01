using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route("company/[controller]")]
    public class EmployeeController : Controller
    {
        [Route("")]
        [Route("[action]")]
        public string Name()
        {
            return "Jonas";
        }
        public string Country()
        {
            return "Swedan";
        }
        [Route("[action]")]
        public string Index()
        {
            return "Hello From Employee";
        }
    }
}