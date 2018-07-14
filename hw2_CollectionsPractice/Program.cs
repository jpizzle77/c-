using System;
using System.Collections.Generic;

namespace hw2_CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
    {
       var list_of_objects = new List<object>();
       Console.WriteLine(list_of_objects);
       list_of_objects.Add(28);
       list_of_objects.Add(7);
       list_of_objects.Add(-1);
       list_of_objects.Add("chair");
       list_of_objects.Add("dog");
       list_of_objects.Add(true);
       list_of_objects.Add(48);
       list_of_objects.Add(-35);
       list_of_objects.Add(3.14);
       list_of_objects.Add(7.14);
       Console.WriteLine("Here are the numbers in the list: ");
       int total = 0;
       for (var idx = 0; idx < list_of_objects.Count; idx++)
       {

            if (list_of_objects[idx] is int) {
                total = (int)list_of_objects[idx] + total;
                Console.WriteLine((idx+1) + ": " + list_of_objects[idx]+ " is a number/int");}

            else if (list_of_objects[idx] is float){
                Console.WriteLine((idx+1) + ": " + list_of_objects[idx]+ " is a float");}

            else if (list_of_objects[idx] is string){
                //if ((string)(list_of_objects[idx]) == "dog")
                Console.WriteLine((idx+1) + ": " + list_of_objects[idx]+ " is a string");}

            else if (list_of_objects[idx] is bool){
                Console.WriteLine((idx+1) + ": " + list_of_objects[idx]+ " is a boolean");}

           
          
       }
              Console.WriteLine("The sum of the numbers in the list is : " + total);
        
    }
    }
}
