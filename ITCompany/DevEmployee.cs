using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class DevEmployee : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public DevEmployee (string fName, string lName, int age, Salary salary, string pLanguage) : base (fName, lName, age, salary)
        {
            ProgrammingLanguage = pLanguage;
        }

        public override string GetJobDescription()
        {
            return string.Format("Developer {0} {1} writes code in {2} language.", FirstName, LastName, ProgrammingLanguage);
        }
    }
}
