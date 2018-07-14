/*
Eliminate Negative Numbers

Given any array x, say [1, 5, 10, -2], create an algorithm that replaces any negative number with the value of 0. 
When the program is done, x should have no negative values, say [1, 5, 10, 0].


            int[] array = {-14, -26, 19, -3,1, 5, 10, -2};
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    array[i] = 0;
                }
            }
            Console.WriteLine(array);
            foreach(var number in array)
                Console.Write(number.ToString() + " ");













 */