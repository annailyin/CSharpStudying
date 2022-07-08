using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class DevLeadEmployee : DevEmployee
    {
        public DevLeadEmployee(string fName, string lName, int age, Salary salary, string pLanguage) : base(fName, lName, age, salary, pLanguage)
        {
        }

        public override string GetJobDescription()
        {
            return string.Format("Developer Team Lead {0} {1} leads the developer team.", FirstName, LastName);
        }
    }
}
