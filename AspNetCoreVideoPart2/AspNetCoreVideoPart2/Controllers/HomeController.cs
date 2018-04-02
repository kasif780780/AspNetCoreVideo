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
        private IVideo _videos; public
           
       HomeController(IVideo videos)
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
                Genre = Enum.GetName(typeof(Genres), video.GenreId)

            });

            return View(model);

        }

            
        }
    }
