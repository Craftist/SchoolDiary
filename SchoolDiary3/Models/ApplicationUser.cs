using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SchoolDiary3.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Range(1, 11)]
        public int Grade { get; set; }
        
        [Required, MinLength(1), MaxLength(2)]
        public string GradeLetter { get; set; }

        [Required, DefaultValue("en")]
        public string Locale { get; set; }
    }
}
