﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047___Generic_Collection_Object
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} yaşında";
        }
    }
}
