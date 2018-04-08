﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreVideoPart2.ViewModels;
using AspNetCoreVideoPart2.Entities;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreVideoPart2.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View();

            var user = new User { UserName = model.UserName };

            return View();
        }
    }
}