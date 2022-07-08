using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class PMEmployee : Employee
    {
        public PMEmployee(string fName, string lName, int age, Salary salary) : base(fName, lName, age, salary)
        {
        }

        public override string GetJobDescription()
        {
            return string.Format("Project Manager {0} {1} manages the project team.", FirstName, LastName);
        }
    }
}
