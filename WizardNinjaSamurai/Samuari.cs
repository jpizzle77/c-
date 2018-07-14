using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human 
    {
        // CLASS VARIABLES
        public static int count = 0; // setting the 'count' of instances made
       
        public new int health; //PROPERTY TO ACCESS PRIVATE VARIABLE '_health'. A getter-setter
        /*// 
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
        }*/

       //------------------------    CONSTRUCTOR METHODS      -----------------------
       
        public static int How_Many()
            {
                return count; // will return the toal number of Samurais
            }


            // this contructor method below will always being invoked when a new object is instantiated
            // it expects a 'string name' to be passed which will be 'pushed to' one of the base Human constructors
        public Samurai(string name) : base(name)  
            {
                health = 177;
                count ++; //
                
               
            }




        // --------------------      CLASS METHODS      ------------------------------
        
        public void Death_Blow(object obj)  // this function has a parameter that will be a generic object
        {
             if (obj is Wizard) // checking to see if the parameter object being passed is of type: Wizard
            {
                Wizard enemy = obj as Wizard; //Safe Explicit Casting

                if (enemy.health > 50) //this will access the Property setter method on the Wizard.cs  Line 8
                
                {
                    enemy.health = health; 
                    
                    Console.WriteLine("Attacking a wizard! His health is: " + enemy.health);
                }
                else
                {
                     enemy.health = health;
                     Console.WriteLine("DEATH BLOW!! Enemies health is now: " + enemy.health);
                }
            
             
            }

             else if (obj is Samurai) // checking to see if the parameter object being passed is of type: Wizard
            // or Unboxing
            {
                Samurai enemy = obj as Samurai; //Safe Explicit Casting
                if (enemy.health > 50)
                    {
                        enemy.health = health;
                        Console.WriteLine("Attacking a samurai! His health is: " + enemy.health);
                    }
                else
                {
                     enemy.health = health;
                     Console.WriteLine("DEATH BLOW!! You KILLED your fellow SAMURAI UP!: " + enemy.health);
                }
            }


            else if (obj is Ninja) // checking to see if the parameter object being passed is of type: Wizard
            // or Unboxing
            {
                Ninja enemy = obj as Ninja; //Safe Explicit Casting
                if (enemy.health > 50)
                {
                    enemy.health = health;
                    Console.WriteLine("Attacking a Ninja! His health is: " + enemy.health);
                }
                else
                {
                     enemy.health = health;
                     Console.WriteLine("DEATH BLOW!! Enemies health is now: " + enemy.health);
                }
            }

            else if (obj is Human) // checking to see if the parameter object being passed is of type: Human
            //NOTE: THE PARENT CLASS SHOULD GO ON BOTTOM SINCE ALL THE ABOVE INHERIT FROM THE HUMAN
            // I HAD HUMAN ABOVE NINJA EARLIER AND IT KEPT PRINTING "Attacking a human"
            {
                Human enemy = obj as Human; //Safe Explicit Casting
                 if (enemy.health > 50)
                {
                    enemy.health = health;
                    Console.WriteLine("Attacking a Human! His health is: " + enemy.health);
                }
                else
                {
                     enemy.health = health;
                     Console.WriteLine("DEATH BLOW!! Enemies health is now: " + enemy.health);
                }
            }
            
           
        }

        public void Mediatate()
        {
            health -= 115; //example of Samurai's health being down
            Console.WriteLine(name + "'s health is now, " + health);
            health = 200; //reset Health to 200
            Console.WriteLine(name + "'s health is now, " + health);
            base.dexterity +=6;
            Console.WriteLine("The new D is: " + dexterity);
        }




    }




}