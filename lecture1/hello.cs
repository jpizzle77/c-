using System;
using System.Collections.Generic;

namespace lecture1
{
   public class Hello
    {
        private string _name;

        private int _age;

       
       public void Bonjour()
       {
           Console.WriteLine($"hey {_name}, you are {_age} years old");
       }

       public void Hola()
       {
           Console.WriteLine($"you are a {_name} * {_age}");
       }

         public Hello(string name, int age)   //constructor method
       {
           _name = name;
           _age = age;
       }
          
       
    }
}   