using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist FromMtVernon = Artists.Where(artist => artist.Hometown == "Mount Vernon").Single();
            Console.WriteLine($"The artist {FromMtVernon.ArtistName} from Mt Vernon is {FromMtVernon.Age} years old");

            //Who is the youngest artist in our collection of artists?
            Artist youngestArtist = Artists.Min(artist => artist.Age);

            Artist Youngest = Artists.OrderBy(artist => artist.Age).First();
            Console.WriteLine($"The Youngest artist is {Youngest.ArtistName}");

            //Display all artists with 'William' somewhere in their real name

            Artist William = Artists.Where(artist => artist.RealName == "William");

             List<Artist> Williams = Artists.Where(artist => artist.RealName.Contains("William")).ToList();
            Console.WriteLine("The Following artists have William in their real names:");

            //Display the 3 oldest artist from Atlanta
            List<Artist> fromAtlanta = Artists.Where(artist => artist.Hometown == "Atlanta")
            .OrderByDescending
          
              //Display the names of all groups less than 8 characters in length

            List<Group> EightOrLess = Groups.Where(group => group.GroupName.Length < 8);
            System.Console.WriteLine($"These are the groups of 8 characters or less");

            foreach (var item in EightOrLess)
            {
                System.Console.WriteLine(item);
            }





            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
