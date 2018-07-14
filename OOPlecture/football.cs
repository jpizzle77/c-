using System;

namespace OOPlecture
{
    public class FootballPlayer : Person
    {
        int _speed;
        int _power;
       public FootballPlayer(string name, int age, int speed, int power) : base(name, age)
        {
           _speed = speed;
           _power = power;
        }
        public void playerstats()
        {
            Console.WriteLine("{0}-{1}-{2}-{3}",_age, _name, _speed,_power);
        }

    }





















}