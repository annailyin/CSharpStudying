using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class BALeadEmployee : BAEmployee
    {
        public BALeadEmployee(string fName, string lName, int age, Salary salary, string bATool) : base(fName, lName, age, salary, bATool)
        {
        }

        public override string GetJobDescription()
        {
            return string.Format("Business Analyst Team Lead {0} {1} leads business analysis team.", FirstName, LastName);
        }

    }
}
