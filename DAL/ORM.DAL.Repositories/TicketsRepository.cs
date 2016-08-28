using ORM.DAL.Interfaces;
using ORM.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Repositories {
    public class TicketsRepository : BaseRepository<ApplicationTicket>, ITicketsRepository<ApplicationTicket> {
        public TicketsRepository(DbContext context)
            : base(context) {

        }

        public ApplicationTicket GetById(int id) {
            return this.DbSet.Find(id);
        }
    }
}
