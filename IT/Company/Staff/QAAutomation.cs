using IT.Company.Accounting;
using System;

namespace IT.Company.Staff
{
    public class QAAutomation : QAManual, ICanWriteCode
    {
        public QAAutomation(string fullName, DateTime dateOfBirth, Company company, Salary salary) : base(fullName, dateOfBirth, company, salary)
        {
        }

        public void WriteCode()
        {
            throw new NotImplementedException();
        }
    }
}
