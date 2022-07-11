using IT.Company.Accounting;
using System;

namespace IT.Company.Staff
{
    public class QAAutomationLead : QAAutomation, ICanAssignTask, ICanWriteCode, ICanReviewCode
    {
        public QAAutomationLead(string fullName, DateTime dateOfBirth, Company company, Salary salary) : base(fullName, dateOfBirth, company, salary)
        {
        }

        public void AssignTaskTo(EmployeeTask employeeTask, Employee employee)
        {
            if (!(employee is QAAutomation))
                throw new Exception("QA Automation Lead can assign task to QA Automation only!");

            if (!Company.TaskBoard.Tasks.Contains(employeeTask))
                throw new Exception("Task is not on the company board!");

            employeeTask.AssignedTo = employee;
        }

        public void ReviewCode()
        {
            throw new NotImplementedException();
        }
    }
}
