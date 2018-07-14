using System;
namespace function

{

    public class Person
    {
        private string _name;
        private int _age;

        public int Age 
        {
            get { return _age;}
            public int MyProperty { get; set; }         
        }

        public void SayName()
        {
            Console.WriteLine($"My name is {_name}");
        }
        public string Name
        {
            get{return _name;}

        }
        public Person(string name, int age) 
        {
        _name = name;
        _age = age;
        }

    public class Programmer : Person
        {
            public Programmer(string name, int age) : base(name,age)
            {

            }
        }

    }


}