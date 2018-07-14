using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car(); // 'Car()' is a constructor method. Allows you the option to write some code the moment that object is created

            //myNewCar.Make = "Jeep";
            myNewCar.Model = "Cherokee";
            myNewCar.Year = 1997;
            myNewCar.Color = "Silver";

            Car myFirstJeep; 
            myFirstJeep = myNewCar; // 2 references to the same object in memory
            Car anotherCarOverloadedConstructor = new Car("Ford", "Mustang", 1965, "red");
            Car.MyMethod();

        Console.WriteLine(anotherCarOverloadedConstructor.Model);
           Console.WriteLine(" {0} - {1} - {2} - {3}",
                myFirstJeep.Make,
                myFirstJeep.Model,
                myFirstJeep.Year,
                myFirstJeep.Color);

            Console.WriteLine(" {0} - {1} - {2} - {3}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Year,
                myNewCar.Color);

            //double marketValueOfCar = determineMarketValue(myNewCar);
            Console.WriteLine("Cars value: {0:C}", myNewCar.determineMarketValue()); // this will call the determineMarketValue() method using myNewCar's attributes
            Console.WriteLine(myFirstJeep.Model);
        }

         private static double determineMarketValue(Car _car) // _car is a parameter
        {
        double carValue = 100.0;
        return carValue;
        }

    }

}

   
