using System.ComponentModel.DataAnnotations;

namespace ASP1.Models

{
    public class Dog
    {
        [Required]
        [MinLength(3, ErrorMessage="Must be more than 3")]
        [Display(Name="Shitfuck")]
        public string type { get; set; }

        [Required]
        public int? weight { get; set; }

        [Required]
        public string email { get; set; }
    }




}