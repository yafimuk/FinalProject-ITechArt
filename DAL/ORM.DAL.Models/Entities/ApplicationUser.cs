using Microsoft.AspNet.Identity.EntityFramework;


namespace ORM.DAL.Models {

    public class ApplicationUser : IdentityUser {

        public string FirstName { get; set; }
        public string SecondName { get; set; }
       
    }
}