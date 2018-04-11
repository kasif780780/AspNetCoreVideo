using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VideoOnDemand.Data.Data.Entities;
using VideoOnDemand.UI.Models;
using VideoOnDemand.UI.Repositories;

namespace VideoOnDemand.UI.Controllers
{

   
   
    public class HomeController : Controller
    {
        private SignInManager<User> _signInManager;
        public HomeController(SignInManager<User> signInMgr)
        {
            _signInManager = signInMgr;
        }
        public IActionResult Index()
        {
            var rep = new MockReadRepository();
            var courses = rep.GetCourses("4d79c09d-6161-4541-a6de-97daed5ec8b6");
            var course = rep.GetCourse("4d79c09d-6161-4541-a6de-97daed5ec8b6", 1);
            var Video = rep.GetVideo("4d79c09d-6161-4541-a6de-97daed5ec8b6",1);
            var videosForModules = rep.GetVideos("4d79c09d-6161-4541-a6de-97daed5ec8b6", 1);

            if (!_signInManager.IsSignedIn(User))
                return RedirectToAction("Login", "Account");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
