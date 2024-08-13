using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(20)]
        public string ?Address { get; set; }
        [Range(0, 60)]
        public int ?Age { get; set; }
    }
}
