using System;
using System.Collections.Generic;

namespace lecture1
{
   public class Ass
    {

        public static void AssFuck(string verb)
        {
            Console.WriteLine($"i like  {verb} bootys");
        }

        string _name; // create variables to hold info

        public Ass(string name) //constructor method is called. arguments are passed over and stored into the variables created above
        {
            _name = name;
        }

        public  void type() //method that can be called. Not a constructor method though
        {
            Console.WriteLine($"I like {_name} bootys");
        }
    }
}   