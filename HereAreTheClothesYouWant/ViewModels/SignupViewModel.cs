using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HereAreTheClothesYouWant.ViewModels
{
    public class SignupViewModel
    {
        [Required]
        [MinLength(4, ErrorMessage = "Too Short!")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Too Short!")]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Not a valid Email")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
