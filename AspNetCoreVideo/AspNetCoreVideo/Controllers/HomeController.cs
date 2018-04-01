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
        public ViewResult Index()
        {
            var model = new List<Video>
            {
                new Video{Id=1,Title="Shreck"},
                new Video{Id=2,Title="Despicable ME"},
                new Video{Id=3,Title="MegaMind"}
            };
            return View(model);
        }
    }
}