namespace function

{
    class Program
    {
        static void Main(string[] args)
        {
            Person Leo = new Person("Leo", 40);
            //Leo.SayName();
            //Leo.Name = "YouDirtySlut";
            Person.Programmer Sharon = new Person.Programmer("Sharon", 24);
            Sharon.SayName();
        }
    }
    
}
