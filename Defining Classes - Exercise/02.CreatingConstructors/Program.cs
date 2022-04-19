using System;

namespace _02.CreatingConstructors
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person secondPerson = new Person(25);
            Person thirdPerson = new Person("Peter", 24);
        }
    }
}
