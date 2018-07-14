using System;
using System.Collections.Generic;

namespace OOP_Todd_EndersPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Array nums = new Array(new double[] {1,3,7});
            Console.WriteLine(nums);
            Console.WriteLine(nums);
            nums.PrintArray();
            nums.AverageArray();*/

            List<int> x = new List<int>();
            
            List<int> OddArray = new List<int>();
                for (int i = 0; i < 256; i++)
                {
                    if (i % 2 == 1)
                    {
                    OddArray.Add(i);
                    }
                }
            //Console.WriteLine(OddArray);

            foreach (var item in OddArray)
            {
                //Console.WriteLine(item);
            }
            int[] y = OddArray.ToArray();
            //Console.WriteLine(y);

            foreach (var item in y)
            {
                //Console.WriteLine(y);
            }

            int[] terms = new int[256];
            for (int num = 0; num < 256; num++)
            {
                if (num % 2 == 1)
                {
                terms[num] = num;
                Console.WriteLine(num);
                }
            }

           
        }
       
    
    }
    
}
