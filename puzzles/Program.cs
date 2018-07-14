using System;
using System.Collections.Generic;


namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Random.RandomArray(); // runs Class Random and uses its method RandomArray to create a random # between 5-25
            //CoinToss.Toss();
            //CoinToss.TossMultipleCoins(1000);
            //Name.Names();

            //Name.ShuffleArray(new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"});

            Name.CheckNameLength(new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney","Jon","jo", "Larry", "Herman","Cher"});
           

            
            
        }
    }
}
