using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage ="Must be 6 characters long", MinimumLength =6)]
        [Display(Name="Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Please Match passwords")]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
