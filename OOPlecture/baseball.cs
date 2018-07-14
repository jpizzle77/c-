using System;

namespace OOPlecture
{
    public class BaseballPlayer : Person
    {
        int _avg;
        int _hr;
       public BaseballPlayer(string name, int age, int avg, int hr) : base(name, age)
        {
           _avg = avg;
           _hr = hr;
        }
        public void playerstats()
        {
            Console.WriteLine("{0}-{1}-{2}-{3}",_age, _name, _avg,_hr);
        }

    }





















}