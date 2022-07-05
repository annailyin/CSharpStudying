using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class QAEmployee : Employee
    {
        public string BugTrackingTool { get; set; }

        public QAEmployee(string fName, string lName, int age, Salary salary, string bugTrackingTool) : base(fName, lName, age, salary)
        {
            BugTrackingTool = bugTrackingTool;
        }
        
        public override string GetJobDescription()
        {
            return string.Format("QA specialist {0} {1} does manual testing using {2} bug tracking tools.", FirstName, LastName, BugTrackingTool);
        }
    }
}
