using System;
namespace Lecture2

{
    public class Car
    {
        // types of accesors: internal(safest), private, protected, public 
        private int _numWheels; //public gives access anywhere in program
        private int _speed;


        // PROPERTY
        public int wheels
        {
            get { return _numWheels;}
        }
         public int speed
        {
            get { return _speed;}
        }

        // another Property. Kinda a hybrid between a method and field
        public int DistanceTraveled{get;set;}

        

        //constructor method
        public Car(int speed)
        {
            _numWheels = 4;
            _speed = speed;
            DistanceTraveled = 0;
        }
        public int doubleWheels
        {
            get{return _numWheels * 2;}
        }

        public void honkHorn()
        {
         Console.WriteLine("Beep beep");
        }

        public Car Move(int _distance)
        {
            DistanceTraveled += _distance;
            return this;  //'this' return the object that was instatiated
        }
        


    }
    public class Ford : Car
    {
        public Ford() : base(100){}
    }
}
