using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {22, 899, -4, 17};

            int max = numbers.Max();
            System.Console.WriteLine(max);
            int min = numbers.Min();
            System.Console.WriteLine(min);

            List<string> names = new List<string>
            {
                "Sharon",
                "Bob",
                "Jack",
                "beavis",
                "Dipshit",
                "ZZ"
            };

            var maxName = names.Max(name => name.Length);
           System.Console.WriteLine(maxName);
            string minname = names.Min();
            System.Console.WriteLine(minname);



        }
    }
}
