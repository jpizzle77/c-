using System;
using System.ComponentModel.DataAnnotations;



namespace ASPFORMSnSHIT.Models
{
    
    public class User
    {
        [Display(Name ="Name")]
        [Required]
        [MinLength(3)]
        public string name { get; set; }





        [Display(Name="Location")]
        [Required]
        [MinLength(3)]
        public string location { get; set; }



        [DataType(DataType.DateTime)]
        [Required]
        public DateTime dob { get; set; }
       

    }


}
