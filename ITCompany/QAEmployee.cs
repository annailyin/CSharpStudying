using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class QAEmployee : Employee
    {
        public string BugTrackingTools { get; set; }

        public QAEmployee(string fName, string lName, int age, int salary, string bugTrackingTools) : base(fName, lName, age, salary)
        {
            BugTrackingTools = bugTrackingTools;
        }
        
        public override void DoYourJob()
        {
            Console.WriteLine("QA specialist {0} {1} does manual testing using {2} bug tracking tools.", FirstName, LastName, BugTrackingTools);
        }
    }
}
