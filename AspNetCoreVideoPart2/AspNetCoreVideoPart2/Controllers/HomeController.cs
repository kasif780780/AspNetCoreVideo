using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreVideoPart2.Models;
using AspNetCoreVideoPart2.Services;

namespace AspNetCoreVideoPart2
{
    
    public class HomeController : Controller
    {
        private IVideo _videos; public
           
       HomeController(IVideo videos)
        {
            _videos = videos;
        }

        public ViewResult Index()
        {
            var model = _videos.GetAll();

            return View(model);
        }
    }
}