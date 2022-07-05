using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    abstract class Employee : Person
    {
        public int Salary { get; set; }

        public Employee (string fName, string lName, int age, int salary) : base (fName, lName, age)
        {
            Salary = salary;
        }

        public abstract void DoYourJob();
    }
}
