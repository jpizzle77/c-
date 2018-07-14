/*
Shifting the values in an array

Given any array x, say [1, 5, 10, 7, -2], create an algorithm that shifts each number by one to the front 
and adds '0' to the end. 
For example, when the program is done,  
if the array [1, 5, 10, 7, -2] is passed to the function, it should become [5, 10, 7, -2, 0].

        double[] array = {1, 5, 10, 7,-2};

         for (int i = 0; i <array.Length; i++)
         {
             if (i == array.Length -1) //this is to hit the last index in array and switch the number to 0
             {
                 array[i] = 0;
             }
             else
            {
                array[i] = array[i+1];
            }
             
         }
     
        Console.WriteLine(array);
        foreach(var number in array)
            Console.Write(number.ToString() + " ");

















 */