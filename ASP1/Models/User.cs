using System.ComponentModel.DataAnnotations;

namespace ASP1.Models


{
    public class User
    
    {
        [Display(Name="First Name")]
        [Required]
        [MinLength(3, ErrorMessage="Names must be 3 character")]
        [MaxLength(7, ErrorMessage="No more than 7")]
        public string first_name { get; set; }
        //------------------------------

        [Display(Name="Last Name")]
        [Required]
        [MinLength(3)]
        [MaxLength(7)]
        public string last_name { get; set; }
        //--------------------------------


        [Display(Name="Age")]
        [Required]
        public int age { get; set; }

    }
}