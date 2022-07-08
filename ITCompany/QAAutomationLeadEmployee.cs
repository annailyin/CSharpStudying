using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class QAAutomationLeadEmployee : QAAutomationEmployee
    {
        public QAAutomationLeadEmployee(string fName, string lName, int age, Salary salary, string bTrackingTool, string pLanguage) : base(fName, lName, age, salary, bTrackingTool, pLanguage)
        {
        }

        public override string GetJobDescription()
        {
            return string.Format("QA Automation Team Lead {0} {1} does automation testing using {2} bug tracking tools and {3} programming language.", FirstName, LastName, BugTrackingTool, ProgrammingLanguage);
        }
    }
}
