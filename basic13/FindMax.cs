using System;
using System.Collections.Generic;

namespace basic13
{
    
		public class Max
        {
           public static void maxNum()
           {

            int[] array = { -14, -5, -2, -7 };
            int index_for_max_num = -1; //
            int largest_number = Int32.MinValue; //this will set 'largest_number' to the smallest number in the Int32 range (-2,147,483,648 )
            // which will allow this function to compare negative numbers in the array
            
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (value > largest_number) // e.g. if (14 > -2,147,483,648) for the first iteration, then value is set to 14
                {
                    largest_number = value;
                    index_for_max_num = i; // both 'largest_number' and 'index_for_max_num' will be reset if the if condition passes
                }
            }
         Console.WriteLine($"The largest number in the index is {largest_number}. It is found at index {index_for_max_num}");
            }
			
		}
}