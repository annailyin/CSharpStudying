using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class DevEmployee : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public DevEmployee (string fName, string lName, int age, int salary, string pLanguage) : base (fName, lName, age, salary)
        {
            ProgrammingLanguage = pLanguage;
        }

        public override void DoYourJob()
        {
            Console.WriteLine("Developer {0} {1} writes code in {2} language.", FirstName, LastName, ProgrammingLanguage);
        }
    }
}
