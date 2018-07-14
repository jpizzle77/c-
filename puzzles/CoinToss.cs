/*
Create a function called TossCoin() that returns a string

Have the function print "Tossing a Coin!"
Randomize a coin toss with a result signaling either side of the coin 
Have the function print either "Heads" or "Tails"
Finally, return the result

*/

using System;
using System.Collections.Generic;

    namespace puzzles
    {

        
        public class CoinToss
        {
             public static void Toss()
             {
                System.Random random = new System.Random();
                int HeadsOrTails = random.Next(1, 3);
                Console.WriteLine("Tossing a coin!");
                if (HeadsOrTails == 1)
                    {
                        Console.WriteLine("Heads has been tossed");
                    }
                else
                    {
                         Console.WriteLine("Tails never fails");
                        
                    }
                

             }

            public static void TossMultipleCoins(int number)
            {
                System.Random random = new System.Random();
                double[] array_of_random_coin_tosses = new double[number];
                double heads = 0;
                double tails = 0;


                 for (int i = 0; i < array_of_random_coin_tosses.Length; i++)
                    {
                        double HeadsOrTails = random.Next(1, 3); // create random number 1 or 2. 1 will be used as Heads and 2 as Tails
                        array_of_random_coin_tosses[i] = HeadsOrTails; // each index is looped through with each random toss being stored inside
                        //Console.WriteLine(HeadsOrTails);

                        if (HeadsOrTails == 1)
                            
                            {
                                heads++;
                              
                            }
                        else
                            {
                                tails++;
                                
                            }
                            
                    }
                    Console.WriteLine($"Heads. It has been tossed {heads} times");
                    Console.WriteLine($"Tails. It has been tossed {tails} times");
                    Console.WriteLine("The ratio of heads being tossed is: {0} %", heads/array_of_random_coin_tosses.Length*100);
                    Console.WriteLine("The ratio of tails being tossed is: {0} %", tails/array_of_random_coin_tosses.Length*100);

            }
     

         



        }
    
    
    
    
    
    }
     

