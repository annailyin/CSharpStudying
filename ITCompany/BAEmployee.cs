using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class BAEmployee : Employee
    {
        public string BATools { get; set; }

        public BAEmployee(string fName, string lName, int age, int salary, string bATools) : base(fName, lName, age, salary)
        {
            BATools = bATools;
        }

        public override void DoYourJob()
        {
            Console.WriteLine("Business Analyst {0} {1} uses {2} tools for working purposes.", FirstName, LastName, BATools);
        }
    }
}
