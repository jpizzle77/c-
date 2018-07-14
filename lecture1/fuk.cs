using System;
using System.Collections.Generic;

namespace lecture1
{
   public class Fuck
    {
        string _name;
        int _height;
        int _weight;

        public Fuck(string name, int height, int weight) // constructor method. Anytime I new object is created, the object
        // will use the incoming data
        {
            _name = name;
            _height = height;
            _weight = weight;
        }
        public void Stats()
        {
            Console.WriteLine("My name is {0}, I'm {1}, and weigh {2},", _name, _height, _weight);
        }
    }
}   