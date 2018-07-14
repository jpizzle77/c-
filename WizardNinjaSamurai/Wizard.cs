using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human 
    {
        private int _health = 147;
        public new int health
        {
            get
             { return _health;}
            set
            {
               if (_health > 50)
               {
                   _health -= 32;
               }
               else
               {
                   _health = 0;
               }
            }

        }
            

        private int _intelligence = 25;
        public new int intelligence
        {
            get {return _intelligence;}
        }

        public Wizard(string name) : base(name)
        {
            
        }
         public void Heal()
        {
            _health += 2 * intelligence;
           Console.WriteLine(name + "'s health is now, " + _health);
        }

        public void Fireball(object obj)
        { 
            Random rand = new Random();
            if (obj is Wizard) 
            {
                Wizard enemy = obj as Wizard;
                enemy._health -= rand.Next(20, 51);
                Console.WriteLine("Attacking a wizard");
            }
            else if (obj is Human) 
            {
                 Human enemy = obj as Human;
                 enemy.health -= rand.Next(20, 51);
                
                Console.WriteLine("Attacking a human");
            }


           
           
            
           


           
        

        }


    

    }


}