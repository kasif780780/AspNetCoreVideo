﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideoPart2.Models;

namespace AspNetCoreVideoPart2.Services
{
  public interface IVideo
    {
        IEnumerable<Video> GetAll();
    }
}