
using System;

namespace WizardNinjaSamurai
{
    public class Human
    {
       
        public string name;

        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
    
        public Human()
        {
           Console.WriteLine("Name: ",name);
           Console.WriteLine("Intelligence : ",intelligence);
           Console.WriteLine("Health :", health);
           Console.WriteLine("Strength :",strength);
        }
        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 27;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
                //Console.Write(enemy.name + "'s health is " + enemy.health);
            }
        }

    } // END OF HUMAN CLASS

}  // END OF NAMESPACE



