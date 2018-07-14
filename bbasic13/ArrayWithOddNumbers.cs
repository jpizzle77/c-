/*

Array with Odd Numbers

Write a program that creates an array 'y' that contains all the odd numbers between 1 to 255.
When the program is done, 'y' should have the value of [1, 3, 5, 7, ... 255]


            List<int> oddNumbersInList = new List<int>(); // create a List to store the odd numbers. Lists are expandable. Arrays are not. Can convert to array later
            for (int i = 0; i < 256; i++)
            {
               if (i % 2 == 1)
               {
                   //Console.WriteLine(i);
                   oddNumbersInList.Add(i); // adding every odd number to the list called 'oddNumbersInList'
               }     
            }
         
            Console.WriteLine(oddNumbersInList); // System.Collections.Generic.List'1[System.Int32]  (syntax for a list)

            //***************   CONVERT LIST TO AN ARRAY ******************88
            int[] Array_Odd_Numbers = oddNumbersInList.ToArray();
            Console.WriteLine(Array_Odd_Numbers);  // this shows System.Int32[] (syntax for an array)

            // ************** TO SHOW ACTUAL ARRAY *****************8
            // loop through each item in array and convert to string
            foreach(var odd_number in Array_Odd_Numbers)
                Console.Write(odd_number.ToString() + " ");





 */