using Microsoft.AspNetCore.Identity;

namespace GreenMeadowsPortal.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }  // ✅ Added
        public string LastName { get; set; }   // ✅ Added
        public string FullName => $"{FirstName} {LastName}"; // ✅ Auto-generated
        public string Address { get; set; }
    }
}
