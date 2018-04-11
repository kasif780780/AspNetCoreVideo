﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoOnDemand.Data.Entities;

namespace VideoOnDemand.UI.Repositories
{
    interface IReadRepository
    {
        IEnumerable<Course> GetCourses(string userId);

        Course GetCourse(string userId, int courseId);

        Video GetVideo(string userId, int videoId);

        IEnumerable<Video> GetVideos(string userId, int moduleId = default(int));
    }
}
