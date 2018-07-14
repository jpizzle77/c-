using System;
using System.Collections.Generic;

namespace OOP_Todd_EndersPart2
{

    public class Testity
    {
        public void Testy()
        {
            //Box some string data into a variable
            object BoxedData = "This is clearly a string";
            //Make sure it is the type you need before proceeding
            if (BoxedData is int) {
                //This shouldn't run
                Console.WriteLine("I guess we have an integer value in this box?");
            }
            if (BoxedData is string) {
                Console.WriteLine("It is totally a string in the box!");
            }

        }

    }

}