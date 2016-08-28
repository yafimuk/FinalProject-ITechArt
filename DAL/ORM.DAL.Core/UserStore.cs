using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ORM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Core {

    public class UserStore : UserStore<ApplicationUser>, IUserStore<ApplicationUser> {
        public UserStore(DbContext context)
            : base(context) {

        }
    }
}
