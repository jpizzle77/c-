 using System;

namespace CarClass
{
    class Car
    {
        //class attribute
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
             this.Make = "Ford"; // this will always make each instance a Ford unless its changed (like  to Jeep)
        }

        public Car(string make, string model, int year, string color) //overloaded contructor
        {
            Make = make;
            Model = model;
            Year  = year;
            Color = color;
        }

        // Class method
        public double determineMarketValue()
        {
            double carValue =100.0;

            if (this.Year > 1990)
                carValue = 10000.0;

            else
                carValue= 2000.0;

            return carValue;
        }

        public static void MyMethod() // static method. Dont have to create an instance of class to use 
                                      // this method in other parts of code
        {
                // on line 18 of Program.cs shows how to access this method. You type "Car.", then a box will appear
                // showing MyMethod() as a way to access this w/o instatiating a Car objeccons
                Console.WriteLine("Yo yo ma");
        }

    }
}