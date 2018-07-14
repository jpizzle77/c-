using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginRegister.Models

{
    public class Message
    {
        //public int messages_id { get; set; }
        public string message { get; set; }
       
    }

    public class Comment
    {
        [Display(Name="Comment on this Post")]
        [Required]
        public string comment {get;set;}
        public int message_id {get;set;}

    }



  public class WallModels
    {
        public Message NewMessage {get;set;}
        public List<Dictionary<string,object>> Messages { get; set; }
        
    }
}

