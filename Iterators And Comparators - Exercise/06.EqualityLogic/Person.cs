using System;
using System.Collections.Generic;
using System.Text;

namespace _06.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            else if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return 0;
        }
        public override int GetHashCode()
        {
            int nameHash = Name.GetHashCode();
            int ageHash = Age.GetHashCode();
            return nameHash * ageHash;
        }
        public override bool Equals(object obj)
        {
            if (this.GetHashCode() == obj.GetHashCode())
            {
                return true;
            }
            return false;
        }
    }
}