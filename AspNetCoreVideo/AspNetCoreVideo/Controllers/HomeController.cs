﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello From Controller";
        }
    }
}