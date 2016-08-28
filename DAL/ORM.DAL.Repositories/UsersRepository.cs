using ORM.DAL.Interfaces;
using ORM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Repositories {
    public class UsersRepository : BaseRepository<ApplicationUser>, IUsersRepository<ApplicationUser> {
        public UsersRepository(DbContext context)
            : base(context) {

        }
    }
}
