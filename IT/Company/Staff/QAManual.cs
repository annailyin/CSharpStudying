using IT.Company.Accounting;
using System;

namespace IT.Company.Staff
{
    public class QAManual : Employee
    {
        public QAManual(string fullName, DateTime dateOfBirth, Company company, Salary salary) : base(fullName, dateOfBirth, company, salary)
        {
        }
     }
}
