using System;

namespace OOP_Todd_EndersPart2
{

    public class Array
    {
        double[] _array;

        public  Array(double[] array)
        {
            _array = array;
        }

        public void PrintArray()
        {
            Console.WriteLine(_array[0]);
            Console.WriteLine(_array[1]);
            Console.WriteLine(_array[2]);
        }

        
        public void AverageArray()
        {
            double sum = 0;
            double avg = 0;
            foreach (var item in _array)
            {
                sum += item;
            }
            avg = sum/_array.Length;
            //Console.WriteLine("The sum of the array is", sum);
            Console.WriteLine("The average of the array is {0}", avg);
        }

        


    }

}