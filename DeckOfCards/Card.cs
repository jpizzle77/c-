/*
Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). 
This "val" should be a String
Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds)
Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers

 */


using System;
using System.Collections.Generic;


namespace DeckOfCards
{

    public class Card
    {
        int[,,] array3D = new int[4,1,13];
        string [] stringVal =  {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        string[] suit = {"Clubs","Spades", "Hearts", "Diamonds"};
        int[] val = {1,2,3,4,6,7,8,9,10,11,12,13};

        public Card()
        {
            
           for (int i = 0; i < suit.Length; i++)
            {
                Console.WriteLine(suit[i]);
                for (int j = 0; j < stringVal.Length; j++)
                {
                    Console.WriteLine(suit[i] + " " + stringVal[j] )
                }
            }
        }
       


    }
    



}