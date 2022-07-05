using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class BAEmployee : Employee
    {
        public string BATool { get; set; }

        public BAEmployee(string fName, string lName, int age, Salary salary, string bATool) : base(fName, lName, age, salary)
        {
            BATool = bATool;
        }

        public override string GetJobDescription()
        {
            return string.Format("Business Analyst {0} {1} uses {2} tool for working purposes.", FirstName, LastName, BATool);
        }
    }
}
