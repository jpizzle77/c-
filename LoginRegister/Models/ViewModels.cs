using System;
using System.Collections.Generic;

namespace LoginRegister.Models
{
    public class IndexView
    {
        //public Message NewMessage { get; set; }
        public List<Dictionary<string,object>> Messages { get; set; }
        public List<Dictionary<string,object>> Comments { get; set; }
        public List<Dictionary<string,object>> Message { get; set; }
        public User NewUser { get; set; }
        public LoginUser LogUser { get; set; }
        public Message NewMessage {get;set;}
        public Comment NewComment {get;set;}
         
        
    }
}