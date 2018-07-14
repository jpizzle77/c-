using System;

namespace OOPlecture
{


 // child class of Person
    public class Programmer : Person
    {
      
        static double FastTypeSpeed = 50.75;
        private double _typeSpeed;
        public bool IsFastType
        {
            get{return _typeSpeed < FastTypeSpeed;}
        }
        //public override void SayName()
        public new void SayName()
        {
            System.Console.WriteLine($"i have a smelly snatch. Its name is {_name}");
        }
        public Programmer(string name, int age, double speed) : base(name, age)
        {
            _typeSpeed = speed;
        }

    }
}