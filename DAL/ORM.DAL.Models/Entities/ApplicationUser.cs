using Microsoft.AspNet.Identity.EntityFramework;


namespace ORM.DAL.Models {
    public class ApplicationUser : IdentityUser {
        public int Year { get; set; }
        public ApplicationUser() {
        }
    }
}