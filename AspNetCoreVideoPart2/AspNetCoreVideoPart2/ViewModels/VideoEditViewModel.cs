using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideoPart2.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideoPart2.ViewModels
{
    public class VideoEditViewModel
    {
        public int Id { get; set; }
        [Required, MinLength(3),MaxLength(80)]
        public string Title { get; set; }
        public Genres Genre { get; set; }
    }
}
