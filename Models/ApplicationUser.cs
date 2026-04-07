using Microsoft.AspNetCore.Identity;

namespace at.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string NomeCompleto { get; set; }
    }
}
