using System.ComponentModel.DataAnnotations;

namespace ASP1.Models
{

    public class Actor
    {
        [Required]
        [MinLength(3, ErrorMessage="More than 2 characters")]
        [MaxLength(7, ErrorMessage="less than 8 characters")]
        public string first_name { get; set; }

        [Required]
        [MinLength(3, ErrorMessage="More than 2 characters")]
        [MaxLength(7, ErrorMessage="Less than 8 characters")]
        public string last_name { get; set; }

        [Required]
        public int? age { get; set; }
    }
}