using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ORM.DAL.Models;

namespace ORM.DAL.Core {
    
        public class ApplicationContext : IdentityDbContext<ApplicationUser> {
            public ApplicationContext() : base("ORM") { }

            public DbSet<Route> Routes { get; set; }

            public static ApplicationContext Create() {
                return new ApplicationContext();
            }
        }

    //}
}