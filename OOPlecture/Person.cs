using System;

namespace OOPlecture
{
    interface ICanSayName
    {
        string Name{get;}
        void SayName();
    }
    public class TVshow : ICanSayName
    {
        public string Name{get;set;}
        public void SayName()
        {
            Console.WriteLine("tv show: {0}", Name);
        }
    }

    // ***********************************************

   public class Person : ICanSayName     // public means this class can be accessed anywhere
   {
       public static int PersonCount = 0;
       protected string _name; //use Property accessor below to allow access to attributes
       // note protected allows '_name' tobe used anywhere from this class. But not the class Program
       protected int _age;

       // **crucial!!! Property accessors. Cross b2 field and method. Looks like a field. Behaves like method
       public string Name
       {
           get{return _name;}
       }

        public int Age
        {
            get{return _age;}
        }

        //public virtual void SayName()
        public virtual void SayName() // POLYMORISM
        // second way overrdie method, not using "virtual" and "override"
        //change SayName under "Programmer class" from 'override' to 'new'
        // a way to have Sharon use the Person class and not Programmer class 
        {
            Console.WriteLine($"What up {_name}");
            Console.WriteLine($"you are {_age} years old");

        }
    
        // this constructor method is invoked on line 16 of
        // Program.cs file. 2 parameters are required to call function
       public Person(string name, int age)   // constructor method
       // 1st place it comes to if a new object is created from this
       // class. 3 arguments are being passed over as attributes.
       {
           _name = name;
           _age = age;
           PersonCount++;
       }
       
   } 

    //********************************************************* */

   
    
    
}

