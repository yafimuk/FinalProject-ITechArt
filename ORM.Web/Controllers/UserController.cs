using ORM.DAL.Core;
using ORM.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORM.Web.Controllers
{
    public class UserController : Controller
    {
       /* public ActionResult UserInfo(string id) {

            ApplicationContext db = new ApplicationContext();

            var model = new UserProfile
            {
                Profile = db.Users.FirstOrDefault(o => o.Id == id)
            };
            if (model.Profile!=null) {
                return View(model);
            }
            
            return View("EditDetails");
        }*/
    }
}