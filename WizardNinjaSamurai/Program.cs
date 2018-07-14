using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human John = new Human("John");
            Console.WriteLine(John.health);
            Human Juan = new Human("Juan", 75,10,10,75);
            John.attack(Juan);
            Wizard joe = new Wizard("joe");
            Wizard jack = new Wizard("jack");
            Ninja Leo = new Ninja("Leo");
           // Leo.Steal(John);
           // Leo.Get_Away();
            //Console.WriteLine(Leo.name + "'s health is now, " + Leo.health);
            //Console.WriteLine("A ninja has a dexterity of: "+Leo.dexterity + " and health is: "+ Leo.health);
           // Console.WriteLine("\n" + joe.health + " dexterity: " + joe.dexterity);
            //Console.WriteLine("Joe's intelligence is " + joe.intelligence);
            //joe.Heal();
            //joe.attack(Juan);
           // Console.WriteLine("Johns health b4 wizards attack: "+ John.health);
            joe.Fireball(John);
            Console.WriteLine("Johns health after wizard attack " + John.health);

           // Console.WriteLine("Jacks health b4 wizards attack: "+ jack.health);
            //joe.Fireball(jack);
            //Console.WriteLine($"Jacks health after {joe.name} the wizard attacked is {jack.health}");
            Samurai Billy = new Samurai("Billy the Samurai");
            Samurai Chuck = new Samurai("Chuck the Samurai");
            Samurai Dave = new Samurai("Dave the Samurai");
           // Console.WriteLine("The Samurai's health is: " + Billy.health + ". His intelligence is: " + Billy.intelligence);
           // Billy.Mediatate();
            Billy.Death_Blow(joe);
            Billy.Death_Blow(John);
            Billy.Death_Blow(Billy);
           // int count = Samurai.How_Many();
           // Console.WriteLine(count);
           // Samurai.How_Many();
            Billy.Death_Blow(Chuck);
           // Billy.Mediatate();
           string InputLine = Console.ReadLine();
           Console.WriteLine(InputLine);

            
        }
    }
}
