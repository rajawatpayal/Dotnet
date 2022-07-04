using BulkyBook.Data.Repository.IRepository;
using BulkyBook.Models;
using BulkyBookWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Data.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

       
    }
}
