using ORM.DAL.Interfaces;
using ORM.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Repositories {
    public class UserTicketsRepository : BaseRepository<ApplicationUserTicket>, IUserTicketsRepository<ApplicationUserTicket> {
        public UserTicketsRepository(DbContext context)
            : base(context) {
        }

        public bool DeleteById(int id) {
            try {
                var item = base.DbSet.Find(id);

                base.DbSet.Remove(item);

                return true;
            }
            catch {
                return false;
            }

        }
    }
}
