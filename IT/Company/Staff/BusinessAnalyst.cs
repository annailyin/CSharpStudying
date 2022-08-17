using IT.Company.Accounting;
using System;

namespace IT.Company.Staff
{
    public class BusinessAnalyst : Employee, ICanReviewTestCase
    {
        public BusinessAnalyst(string fullName, DateTime dateOfBirth, Company company, Salary salary) : base(fullName, dateOfBirth, company, salary)
        {
        }

        public void ReviewTestCase()
        {
            throw new NotImplementedException();
        }
    }
}
