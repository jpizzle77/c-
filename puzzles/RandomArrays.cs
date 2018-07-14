/*
Random Array
Create a function called RandomArray() that returns an integer array

Place 10 random integer values between 5-25 into the array
Print the min and max values of the array
Print the sum of all the values
 */

 using System;
 using System.Collections.Generic;

 namespace puzzles
 {
     public class Random
     {

     public static void RandomArray()
     {
        System.Random random = new System.Random();
    
        double[] array_of_random_numbers = new double[10]; // create an array size 10 ints
        double sum = 0; // create a sum variable to add numbers of array
        double max = 0;// create a min and max to compare
        double min = 25;
        

        for (int i = 0; i < array_of_random_numbers.Length; i++)
            {
                double randomNumber = random.Next(5, 25); //create a random # b2 5-25
                array_of_random_numbers[i] = randomNumber; // each index is looped through with each random number being stored inside
                //Console.WriteLine(array_of_random_numbers[i]);
            }

            foreach (var number in array_of_random_numbers) // loop through each number in the array. Compare then to min and max values
            {
                sum = sum + number; // sum the numbers in the array
                if (number > max)
                    {
                        max = number; //reset the max if the number in array is larger
                    }

                else if (number < min)
                    
                    {
                        min = number; // reset the min if the number in array is smaller
                    }
                   
            }
            Console.WriteLine($"The largest number in the array is: {max}");
            Console.WriteLine($"The smallest number in array is: {min}");
            Console.WriteLine($"The sum of the numbers in the array is: {sum}");
            Console.WriteLine("The average of the numbers in the array is: {0}", sum/array_of_random_numbers.Length);
            
        }
    }
}