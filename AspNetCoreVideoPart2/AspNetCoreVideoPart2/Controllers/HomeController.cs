using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreVideoPart2.Entities;
using AspNetCoreVideoPart2.Services;
using AspNetCoreVideoPart2.ViewModels;

namespace AspNetCoreVideoPart2
{
    
    public class HomeController : Controller
    {
        private IVideo _videos;

        public HomeController(IVideo videos)
        {
            _videos = videos;
        }

        public ViewResult Index()
        {
            var model = _videos.GetAll().Select(video =>
            new VideoViewModel
            {
                Id = video.Id,
                Title = video.Title,
                Genre = video.Genre.ToString()

            });

            return View(model);

        }
        public IActionResult Details(int id)
        {

            var model = _videos.Get(id);

            if(model==null)
            {
                return RedirectToAction("Index");
            }
            return View(new VideoViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Genre = model.Genre.ToString()
    });
            }

        [HttpGet]
          public IActionResult Edit(int id)
           {


            var video = _videos.Get(id);

            if (video == null) return RedirectToAction("Index");

            return View(video);

        }
        [HttpPost]
        public IActionResult Edit(int id, VideoEditViewModel model)

        {
            var video = _videos.Get(id);

            if (video == null || !ModelState.IsValid) return View(model);

            video.Title = model.Title; video.Genre = model.Genre;

            _videos.Commit();

            return RedirectToAction("Details", new { id = video.Id });

        }
        [HttpGet]
        public IActionResult Create()
        {


            return View();

        }

        [HttpPost]
        public IActionResult Create(VideoEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var video = new Video
                {
                    Title = model.Title,
                    Genre = model.Genre
                };

                _videos.Add(video);
                return RedirectToAction("Details", new { id = video.Id });
            }

            return View();
           
        }

    }

}
