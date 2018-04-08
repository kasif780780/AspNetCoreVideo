using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideoPart2.Entities;
using AspNetCoreVideoPart2.ViewModels;
using AspNetCoreVideoPart2.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AspNetCoreVideoPart2.Data
{
    public class VideoDbContext:IdentityDbContext
    {

        public DbSet<Video> Videos { get; set; }
        public VideoDbContext( DbContextOptions<VideoDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
