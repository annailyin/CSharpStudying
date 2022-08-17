using IT.Company.Accounting;
using System;
using System.Collections.Generic;

namespace IT.Company.Staff
{
    public abstract class Employee : Person
    {
        public Company Company { get; }

        public List<Skill> Skills { get; } = new List<Skill>();

        public Salary Salary { get; set; }

        public Employee (string fullName, DateTime dateOfBirth, Company company, Salary salary) : base (fullName, dateOfBirth)
        {
            Company = company;
            Salary = salary;
        }
    }
}
