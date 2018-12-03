using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_08.Immutable
{
    public class Immutable
    {
        private string FirstName { get; }
        private string LastName { get; }

        public Immutable(string fName, string lName) 
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public Immutable SetFirstName(string newFirstName)
        {
            return new Immutable(newFirstName, this.LastName);
        }

        public Immutable SetLastName(string newLastName)
        {
            return new Immutable(this.FirstName, newLastName);
        }
    }
}
