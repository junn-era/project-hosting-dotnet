using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHosting.Models
{
    public class Person
    {
        public Person() { }
        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        public string Name { get; set;}
        public string LastName { get; set;}
        public string FullName => $"{Name} {LastName}".ToUpper();
    }
}