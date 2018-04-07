using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideoPart2.Entities;

namespace AspNetCoreVideoPart2.Services
{

    
    public class MockVideoData:IVideo
    {
        private IEnumerable<Video> _videos; //This field will hold the video data, loaded from a constructor

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video{Id=1,GenreId=1,Title="Shreck"},
               new Video{Id=2,GenreId=1,Title="Despicable ME"},
               new Video{Id=3, GenreId=1,Title="MegaMind"}
            };
        }
        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }
        public Video Get(int id)
        {
            return _videos.FirstOrDefault(v => v.Id.Equals(id));
        }
    }
}
