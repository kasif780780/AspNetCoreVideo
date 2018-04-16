﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.RazorPages;

using VideoOnDemand.Admin.Services;

using VideoOnDemand.Admin.Models;

using Microsoft.AspNetCore.Authorization;
using VideoOnDemand.Data.Entities;
using VideoOnDemand.Data.Services;

namespace VideoOnDemand.Admin.Pages.Videos

{

    [Authorize(Roles = "Admin")]

    public class CreateModel : PageModel

    {

        private IDbReadService _dbReadService;
        private IDbWriteService _dbWriteService;



        [BindProperty]

        public Video Input { get; set; } = new Video();



        // Used to send a message back to the Index Razor Page.

        [TempData]

        public string StatusMessage { get; set; }



        public CreateModel(IDbReadService dbReadService,IDbWriteService dbWriteService)

        {
            _dbReadService = dbReadService;
            _dbWriteService = dbWriteService;



        }



        public void OnGet()

        {
            ViewData["Modules"] = _dbReadService.GetSelectList<Module>("Id", "Title");

        }



        public  async Task<IActionResult> OnPostAsync()

        {

            if (ModelState.IsValid)
            {
                Input.CourseId = _dbReadService.Get<Module>(Input.ModuleId).CourseId; var success = await _dbWriteService.Add(Input);

                if (success) { StatusMessage = $"Created a new Video: {Input.Title}."; return RedirectToPage("Index"); }
            }





            // Something failed, redisplay the form.

            return Page();

        }

    }

}