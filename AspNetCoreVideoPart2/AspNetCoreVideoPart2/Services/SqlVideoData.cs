using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideoPart2.Data;
using AspNetCoreVideoPart2.Entities;
using AspNetCoreVideoPart2.Services;
using AspNetCoreVideoPart2.ViewModels;


namespace AspNetCoreVideoPart2.Services
{
    public class SqlVideoData:IVideo
    {
        private VideoDbContext _db;
        public SqlVideoData(VideoDbContext db)
        {
            _db = db;
        }

        public void Add(Video newVideo)
        {
            _db.Add(newVideo);
            _db.SaveChanges();
        }
        public int Commit()
        {
            return _db.SaveChanges();
        }
        public Video Get(int id)
        {
            return _db.Find<Video>(id);
        }
        public IEnumerable<Video> GetAll()
        {
            return _db.Videos;
        }
       
    }
    
}
