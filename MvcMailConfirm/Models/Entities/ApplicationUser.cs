using Microsoft.AspNetCore.Identity;

namespace MvcAjax.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}