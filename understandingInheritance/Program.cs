using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

                myNewCar.Make = "Jeep";
                myNewCar.Model = "Cherokee";
                myNewCar.Year = 1997;
                myNewCar.Color = "Silver";
                

            printVehicleDetails(myNewCar); // this will call the method printCarDetails(Car _car). It passes myNewCar's info (parameter)

            Truck myTruck = new Truck();

                myTruck.Make ="Ford";
                myTruck.Model ="F-250";
                myTruck.Year = 2009;
                myTruck.Color= "black";
                myTruck.TowingCapacity = 1200;
                printVehicleDetails(myTruck);



        }

            // create helper method belongs to the Program class(Line #5)
            private static void printVehicleDetails(Vehicle _vehicle) //_car is a incoming parameter (or info from object)
            {
                Console.WriteLine("Here are the Vehicle's details: {0}",
                _vehicle.FormatMe()); //this calls the FormatMe() method that is part of the Car class. Will use  _car objects info
            }

    }

    // abstract base class. 2 things to note: 
    // 1) You can not create an instance/object from an abstract base class
    // 2) They are only useful when an actual class has been made from it (concrete)
    abstract class Vehicle
    {
        //class attributes
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe(); // this basically says you have to use an implementaton of FormatMe() in class. You can't create an instace from a abstract
    }
    
    class Car : Vehicle
    {
       //---------------         HELPER METHOD CALLED FormatMe()            --------------------
       public override string FormatMe()
       {
           return String.Format("{0} - {1} - {2} - {3}",
           this.Make,
           this.Model,
           this.Year,
           this.Color);
       }

    }

    sealed class Truck : Vehicle  // the term "sealed" prevents anymore inheritance
    {
      public int TowingCapacity { get; set; }  

       public override string FormatMe()
       {
           return String.Format("{0} - {1} - {2} - Towing Units",
           this.Make,
           this.Model,
           this.TowingCapacity);
       }

    }

   /* class Semi : Truck
    {
            NOTE: will show error, that Semi cannot be derived from Truck class since it is sealed
    }*/
}
