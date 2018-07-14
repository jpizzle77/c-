using System;
using System.Collections.Generic;


namespace OOPlecture
{
   
    class Program //entry point into our application or program
    {
         public static void SayHello(string name)
            {
                Console.WriteLine("Hello, {0}, how are you doing today?", name);
            }
        static void Main(string[] args)
        { 
            Person Leo = new Person("Leo",69); // Person("Leo") is the contructor () being called (inside the class Person)
           // Leo.SayName();
            // the object Leo invokes the SayName()
            Programmer Sharon = new Programmer("Sharon",29, 80.9);
            //Sharon.SayName();
            //(Sharon as Person).SayName();
           // Console.WriteLine(Person.PersonCount);



            TVshow Seinfeld = new TVshow
            {
                Name = "Seinfeld"
            };
            List<ICanSayName> Names = new List<ICanSayName>
            {
                Seinfeld,
                Leo,
                Sharon
            };
            foreach(ICanSayName name in Names)
            {
                name.SayName();
            }
            Seinfeld.SayName();
            SayHello("dipshit");
        }
    }
}
