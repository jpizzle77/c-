using System.ComponentModel.DataAnnotations;

namespace ASP1.Models
{
    public class Animal
    {
        [Required]
        public string type { get; set; }

        
        public int weight { get; set; }

        [MinLength(3)]
        public string name { get; set; }
    }
}