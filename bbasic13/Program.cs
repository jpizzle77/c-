using System;
using System.Collections.Generic;

namespace bbasic13
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] array = {1, -5, 10, 7,-2};
        List<object> temp_list = new List<object>();

        for (int i = 0; i < array. Length; i++)
        {
            string x = "Coding";

            if (array[i] < 0)
            {
                
                temp_list.Add(x);
                //Console.WriteLine(array[i]);
            }
            else
            {
                temp_list.Add(array[i]);
               // Console.WriteLine(array[i]);
            }
        }
        //Console.WriteLine(temp_list);

        object[] array2 = temp_list.ToArray(); // convert the list "temp_list" to an array using ToArray()
        //Console.WriteLine(array2);  // this shows System.Int32[] (syntax for an array)

        // ************** TO SHOW ACTUAL ARRAY *****************8
            // loop through each item in array and convert to string
        foreach(var number in array2)
            Console.Write(number.ToString() + " ");
          
		}	
		
    }
}
