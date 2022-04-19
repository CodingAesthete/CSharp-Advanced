using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.OpinionPoll
{
    public class Family
    {
        public List<Person> people { get; set; }
        public Family()
        {
            people = new List<Person>();
        }
        public void AddMember(Person person)
        {
            people.Add(person);
        }
        public Person GetOldestMember()
        {
            List<Person> first = people.OrderByDescending(s => s.Age).ToList();
            Person person = first.First();
            return person;
        }
    }
}
