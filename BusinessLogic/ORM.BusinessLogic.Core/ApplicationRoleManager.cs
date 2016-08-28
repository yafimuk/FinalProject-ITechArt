using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using ORM.DAL.Models;
using ORM.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ORM.DAL.Core;


namespace ORM.DAL.Core {

    public class ApplicationRoleManager : RoleManager<ApplicationRole> {
        public ApplicationRoleManager(IRoleStore<ApplicationRole> store)
            : base(store) {

        }
    }
}
