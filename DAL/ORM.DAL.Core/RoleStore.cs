using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ORM.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Core {

    public class RoleStore : RoleStore<ApplicationRole>, IRoleStore<ApplicationRole> {
        public RoleStore(DbContext context)
            : base(context) {

        }
    }
}
