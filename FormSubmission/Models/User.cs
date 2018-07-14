using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Display(Name="First Name")]
        [Required]
        [MinLength(3, ErrorMessage="Must be at least 3 characters")]
        [MaxLength(10, ErrorMessage="No more than 10 characters")]
        public string first_name { get; set; }

        [Display(Name="Last Name")]
        [Required]
        [MinLength(3, ErrorMessage="Must be at least 3 characters")]
        [MaxLength(10, ErrorMessage="No more than 10 characters")]
        public string last_name { get; set; }

        [Display(Name="Age")]
        [Required]
        public int? age { get; set; }

        
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string email { get; set; }

        
        [Display(Name="Password")] 
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string password { get; set; }


        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("password", ErrorMessage = "Password and Confirmation Password must match.")]
        [DataType(DataType.Password)]
        public string confirmpassword { get; set; }
    }
}