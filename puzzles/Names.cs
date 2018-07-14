/*

Names
Build a function Names that returns an array of strings

Create an array with the values: Todd, Tiffany, Charlie, Geneva, Sydney
Shuffle the array and print the values in the new order
Return an array that only includes names longer than 5 characters
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
    {
        public class Name
        {
            public static void Names()
            {
                string[] myCars = new string[7] { "Mazda", "Ford", "Dodge", "Nissan", "Chevy", "Toyota", "GM"};
                foreach (var item in myCars)
                {
                    Console.WriteLine(item);
                }

            }

            public static void ShuffleArray(string[] array) // an array is passed into the method
            { 
                var list_to_store_array_indexes = new List<int>(Enumerable.Range(0, array.Length)); //create a new list (0,1,2,3,4) that stores the Index numbers
                var shuffled_list = new List<int>();  // initializing  a new empty list to place 'shuffled objects'
    
                System.Random random = new System.Random(); //creating a random object
               
                while (list_to_store_array_indexes.Count > 0) 
                {
                    int random_index_number = random.Next(list_to_store_array_indexes.Count); // creates a random number between 5 variables (0,1,2,3,4) on first iteration
                    // on 2nd iteration, it will create a random number from 4 variables (note: 1 is removed by the RemoveAt(r) method)
                    // same thing again on 3rd iteration, except only 3 variables
                    // note RemoveAt() is almost like a negative counter

                    shuffled_list.Add(list_to_store_array_indexes[random_index_number]); // the new list 'shuffled_list' has items added to it 

                    list_to_store_array_indexes.RemoveAt(random_index_number); // removes the random index from the list. This will reduce the list by 1 each time
                    // when it gets to last item, it removes it and then the list 'list_to_store_array_indexes = 0' and the while loop ends
                }
              
                foreach (var item in shuffled_list)
                {
                    Console.Write(array[item] + " \n");
                }
               

            }
            public static void CheckNameLength(string[] array)
            {
                List<string> names = new List<string>(); // create a list to store names over 4 characters

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length > 4) // if name has more than 4 characters
                    {
                        names.Add(array[i]); // it is added to the list called 'names'
                    }
                }
               
                string[] array_names_larger_than_4_characters = names.ToArray(); // convert list to an array
                //Console.WriteLine(array_names_larger_than_4_characters);  // this shows System.Int32[] (syntax for an array)

                foreach(var name in array_names_larger_than_4_characters)
                Console.Write(name.ToString() + "\n");

            }
            
        
        }

    }