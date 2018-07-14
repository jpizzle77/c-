using System.ComponentModel.DataAnnotations;

namespace ASP1.Models
{
    public class Movie
    {
        [Required]
        [Display(Name="Title")]
        [MinLength(3, ErrorMessage ="Movie must be more than 3 characters")]
        [MaxLength(7, ErrorMessage ="Dee movie title cant be more than 7")]
        public string title { get; set; }

        [Required]
        public string genre { get; set; }

        [Required]
        public int release_year { get; set; }

    }


}