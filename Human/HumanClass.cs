/*
1)Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health
2)Give a default value of 3 for strength, intelligence, and dexterity. Health should have a default of 100.
3)When an object is constructed from this class it should have the ability to pass a name
 */



using System;
using System.Collections.Generic;

    namespace Human
    {

        public class HumanBeing
        {
            string name;
            int strength = 3;
            int intelligence =3;
            int dexterity =3;
            int health =100;
            

            public HumanBeing(string _name)
                {
                    name = _name;
                    

                }

              public HumanBeing(string _name, int _intelligence, int _dexterity, int _health, int _strength)
                {
                    name = _name;
                    intelligence = _intelligence;
                    dexterity = _dexterity;
                    health = _health;
                    strength = _strength;
                    

                }

                 public void Attack(HumanBeing enemy)
                 {
                 enemy.health -= 5 * strength;
                 Console.WriteLine($"The attacker:{name} {strength} ");
                 Console.WriteLine($"Enemy Name: {enemy.name}, Health:{enemy.health}");
                 health -= 5 * enemy.strength;
                 Console.WriteLine($"{name} attacked {enemy.name} and his health dropped to:{health}");
                 
                 }


              public void PrintArray()
                {
                    Console.WriteLine($"The human's name is {name}");
                    Console.WriteLine($"This human's health is: {health}, It's strength is: {strength}, intelligence: {intelligence}, and dexterity:{dexterity}");
                }
        }

    }
