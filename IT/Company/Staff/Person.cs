using System;

namespace IT.Company.Staff
{
    public abstract class Person
    {
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Person(string fullName, DateTime dateOfBirth)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
        }
    }
}
