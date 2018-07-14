using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanBeing john = new HumanBeing("John");
            //john.PrintArray();

            HumanBeing freddy  =new HumanBeing("freddy",25,50,100,5);
            //freddy.PrintArray();
            freddy.Attack(john);
            // this of these command above as 2 objects interacting with each other
            // the objects 'freddy' and 'john' has access to any methods or attribute
            // including (name, intelligence, strength, health, and dexterity) plus the method 'Attack'
            john.Attack(freddy);
        }
    }
}
