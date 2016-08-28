using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ORM.DAL.Models;
using ORM.DAL.Models.Entities;

namespace ORM.DAL.Core {
    
        public class ApplicationContext : IdentityDbContext<ApplicationUser> {
            public ApplicationContext() : base("ORM") { }

        public DbSet<ApplicationUserTicket> UserTickets { get; set; }
        public DbSet<ApplicationTicket> Tickets { get; set; }

        public static ApplicationContext Create() {
                return new ApplicationContext();
            }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}

