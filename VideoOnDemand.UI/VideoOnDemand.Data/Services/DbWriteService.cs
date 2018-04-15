using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoOnDemand.Data.Data;

namespace VideoOnDemand.Data.Services
{
    public class DbWriteService:IDbWriteService
    {
        private VODContext _db;
        public DbWriteService(VODContext db)
        {
            _db = db;

        } 
        
    }
}
