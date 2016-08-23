using Microsoft.AspNet.Identity.EntityFramework;


namespace ORM.Web.Models {
    public class ApplicationUser : IdentityUser {
        public int Year { get; set; }
        public ApplicationUser() {
        }
    }
}