using System;
using System.Collections.Generic;
using DbConnection;

namespace MySqlCSharp
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //CreateName();
           // UpdateName();
           DeleteName();

            List<Dictionary<string,object>> things = DbConnector.Query("SELECT * FROM users");
            foreach (var item in things)
            {
                Console.WriteLine($"{item["id"]} {item["first_name"]} {item["last_name"]} ");
            }

         

            
            
        }
         static void CreateName()
        {
            System.Console.WriteLine("Enter First Name");
            string first_name = Console.ReadLine();

            System.Console.WriteLine("Enter Last Name");
            string last_name = Console.ReadLine();

            string insert_query = $"INSERT INTO users (first_name,last_name) VALUES('{first_name}', '{last_name}')";
            DbConnector.Execute(insert_query);
        }

        static void UpdateName()
        {
             System.Console.WriteLine("UPDATE Last Name ID");
            string id = Console.ReadLine();

            System.Console.WriteLine("UPDATE Last Name");
            string last_name = Console.ReadLine();

             string update_query = $"UPDATE users SET last_name ='{last_name}' WHERE id = '{id}'";
             DbConnector.Execute(update_query);
        }
         static void DeleteName()
         {
            System.Console.WriteLine("Delete Person");
            string person = Console.ReadLine();

             string delete_query = $"DELETE FROM users WHERE id = '{person}'";
             DbConnector.Execute(delete_query);

         }
    }
}
