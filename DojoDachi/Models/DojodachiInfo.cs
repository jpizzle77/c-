namespace Dojodachi
{
    public class DojodachiInfo
    {
        public int Fullness { get; set; }

        public int Happiness { get; set; }

        public int Meals { get; set; }

        public int Energy { get; set; }

        public DojodachiInfo() // from line   from HomeController.cs. This constructor method is called to build a new Dojodachi
        // will have preset values
        {
            Fullness = 20;
            Happiness = 20;
            Meals = 3;
            Energy = 50;
        }
    }
}