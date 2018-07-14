using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args) // entry point into program
        {
            Car newCar = new Car(120);
            Console.WriteLine(newCar.wheels);
            Console.WriteLine(newCar.doubleWheels);
            newCar.honkHorn();
            newCar.Move(125);
            newCar.Move(55);
            newCar.Move(-45);
            newCar.Move(-1000).Move(400).Move(69); // can chain methods
            Console.WriteLine(newCar.DistanceTraveled);
            Ford mustang = new Ford();
            Console.WriteLine(mustang.speed);

        }
    }
}
