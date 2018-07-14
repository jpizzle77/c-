using System;

namespace hw1_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            
             for (int i = 1; i <= 100; i++)
                if ((i % 5) == 0 && (i % 3) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i % 5) == 0)

                {
                    Console.WriteLine("fizz");
                }
                else 
                    if ((i % 3) == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                
        }

        }
    }

