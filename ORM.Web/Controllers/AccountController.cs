using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ORM.BusinessLogic.Common;
using ORM.DAL.Models.Entities;
using ORM.Web.Models;
using Microsoft.AspNet.Identity;
using System.Net.Mail;
using ORM.DAL.Models;
using Microsoft.Owin.Security;
using System.Security.Claims;
using ORM.DAL.Core;

namespace ORM.Web.Controllers {
    public class AccountController : Controller {
        private ApplicationUserManager UserManager {
            get {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }

        public ActionResult Register() {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterModel model) {
            if (ModelState.IsValid) {
                ApplicationUser user = new ApplicationUser { FirstName = model.FirstName, Email = model.Email};
                IdentityResult result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded) {
                    return RedirectToAction("Login", "Account");
                }
                else {
                    foreach (string error in result.Errors) {
                        ModelState.AddModelError("", error);
                    }
                }
            }
            return View(model);
        }

        private IAuthenticationManager AuthenticationManager {
            get {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public ActionResult Login(string returnUrl) {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(ORM.Web.Models.LoginModel model, string returnUrl) {
            if (ModelState.IsValid) {
                ApplicationUser user = await UserManager.FindAsync(model.Email, model.Password);
                if (user == null) {
                    ModelState.AddModelError("", "Неверный логин или пароль.");
                }
                else {
                    ClaimsIdentity claim = await UserManager.CreateIdentityAsync(user,
                                            DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationManager.SignOut();
                    AuthenticationManager.SignIn(new AuthenticationProperties {
                        IsPersistent = true
                    }, claim);
                    if (String.IsNullOrEmpty(returnUrl))
                        return RedirectToAction("Index", "Home");
                    return Redirect(returnUrl);
                }
            }
            ViewBag.returnUrl = returnUrl;
            return View(model);
        }
        public ActionResult Logout() {
            AuthenticationManager.SignOut();
            return RedirectToAction("Login");
        }


    }
}