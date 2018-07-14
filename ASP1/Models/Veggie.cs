using System.ComponentModel.DataAnnotations;

namespace ASP1.Models

{
    public class Veggie
    {
        [Required]
        public string type { get; set; }

        [Required]
        public string color { get; set; }

        [Required]
        public int? weight { get; set; }
    }
}