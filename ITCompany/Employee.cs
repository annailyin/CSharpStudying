using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    abstract class Employee : Person
    {
        public Salary Salary { get; set; }

        public Employee (string fName, string lName, int age, Salary salary) : base (fName, lName, age)
        {
            Salary = salary;
        }

        public abstract string GetJobDescription();
    }
}
