using IT.Company.Accounting;
using System;
using System.Collections.Generic;

namespace IT.Company.Staff
{
    public class CEO : Employee
    {
        public List<string> BusinessStrategies { get; } = new List<string>();

        public CEO (string fullName, DateTime dateOfBirth, Company company, Salary salary) : base(fullName, dateOfBirth, company, salary)
        {
        }
    }
}
