using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class CEO : Employee
    {
        public List<string> BusinessStrategies { get; set; }

        public List<string> Deals { get; set; }

        public CEO (string fName, string lName, int age, Salary salary) : base(fName, lName, age, salary)
        {
            BusinessStrategies = new List<string>();
            Deals = new List<string>();
        }

        public void AddBusinessStrategy(string businessStrategy)
        {
            BusinessStrategies.Add(businessStrategy);
        }

        public void RemoveBusinessStrategy(string businessStrategy)
        {
            BusinessStrategies.Remove(businessStrategy);
        }

        public void AddDeal(string deal)
        {
            Deals.Add(deal);
        }

        public void RemoveDeal(string deal)
        {
            Deals.Remove(deal);
        }

        public override string GetJobDescription()
        {
            return string.Format("CEO {0} {1} is the top position in IT company and responsible for implementing existing plans and policies.", FirstName, LastName);
        }
    }
}
