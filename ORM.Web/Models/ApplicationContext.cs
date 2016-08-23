using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ORM.Web.Models {
    public class ApplicationContext : IdentityDbContext<ApplicationUser> {
        public ApplicationContext() : base("ORM") { }

        public static ApplicationContext Create() {
            return new ApplicationContext();
        }
    }
}