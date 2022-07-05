using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class QAAutomationEmployee : QAEmployee
    {
        public string ProgrammingLanguage { get; set; }

        public QAAutomationEmployee(string fName, string lName, int age, int salary, string bTrackingTools, string pLanguage) : base(fName, lName, age, salary, bTrackingTools)
        {
            ProgrammingLanguage = pLanguage;
        }

        public override void DoYourJob()
        {
            Console.WriteLine("QA Automation specialist {0} {1} does automation testing using {2} bug tracking tools and {3} programming language.", FirstName, LastName, BugTrackingTools, ProgrammingLanguage);
        }
    }
}
