using System.ComponentModel.DataAnnotations;

namespace example8.Models
{
    public class Friend 
    {
        // have the colums match the same colums in MySql
        //I originally had "public int friend_id { get; set; }"
        // the database Console_Db had the column "id", not "friend_id" which was creating confusion for me
        
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
   
}