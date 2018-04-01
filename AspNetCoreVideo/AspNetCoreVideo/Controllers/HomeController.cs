using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreVideo.Models;

namespace AspNetCoreVideo.Controllers
{
    public class HomeController : Controller
    {
        public ObjectResult Index()
        {
            var model = new Video { Id = 1, Title = "Shreck" };
            return new ObjectResult(model);
        }
    }
}