using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human 
    {
       private int _health = 92;
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
        private int _dexterity = 175;
        public new int dexterity
        {
            get { return _dexterity;}
        }

     public Ninja(string name) : base(name)
        {
            
        }

     public void Steal(object obj)
        {
            _health += 15;
            Console.WriteLine(name + "'s health is now, " + health);
        }

     public void Get_Away()
        {
            _health -= 15;
            Console.WriteLine(name + "'s health is now, " + health);
        }

















    }

}