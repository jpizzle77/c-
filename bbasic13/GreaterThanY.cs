/*
Greater than Y

Write a program that takes an array and returns the number of values in that array whose value is 
greater than a given value y. 
For example, if array = [1, 3, 5, 7] and y = 3. 
After your program is run it will print 2 (since there are two values in the array that are greater than 3).

            int[] array = {19, 22,1,2,3,4,6,1,8};
            int y = 3;
            List<int> Numbers_larger_than_Y = new List<int>(); // create list to store numbers larger than y. Will convert to an array at end of program

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > y)
                {
                    Numbers_larger_than_Y.Add(array[i]); // looping through the array. Adding any number larger than y to list called 'Numbers_larger_than_Y'
                }
            }
            Console.WriteLine(Numbers_larger_than_Y); //prints System.Collections.Generic.List'1[System.Int32]  (syntax for a list)

             //***************   CONVERT LIST TO AN ARRAY ******************
            int[] Array_Numbers_Greater_Y = Numbers_larger_than_Y.ToArray(); // convert list to an array
            Console.WriteLine(Array_Numbers_Greater_Y);  // this shows System.Int32[] (syntax for an array)

             // ************** TO SHOW ACTUAL ARRAY *****************8
            // loop through each item in array and convert to string
            foreach(var number in Array_Numbers_Greater_Y)
                Console.Write(number.ToString() + " ");





 */
 