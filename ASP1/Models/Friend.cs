using System.ComponentModel.DataAnnotations;

namespace ASP1.Models
{
    public class Friend
    {
        [Display(Name="Friend First Name")]
        [Required]
        public string first_name { get; set; }

        [Display(Name="Friend Last Name")]
        public string last_name { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string email { get; set; }
    }

}