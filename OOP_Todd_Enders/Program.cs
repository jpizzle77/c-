using System;
using System.Collections.Generic;


namespace OOP_Todd_Enders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> profile = new Dictionary<string, string>();

            profile.Add("Name", "John");
            profile.Add("Location", "Santa Barbara");

            
            //foreach (var item in profile)
            foreach (KeyValuePair<string,string> item in profile)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            // at 30 minute mark Todd Enders #2 video week1. Nested dictionary in list. IMPORTANT TO KNOW!
            //a list of dictionaries
            List<Dictionary<string,string>> people = new List<Dictionary<string, string>>();
            people.Add(profile);
            foreach (Dictionary<string,string> item in people)
            {
                foreach (KeyValuePair<string,string> value in item)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", value.Key, value.Value);
                }
            }
        }
    }
}
