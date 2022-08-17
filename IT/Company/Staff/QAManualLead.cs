using IT.Company.Accounting;
using System;

namespace IT.Company.Staff
{
    public class QAManualLead : QAManual, ICanAssignTask, ICanReviewTestCase
    {
        public QAManualLead(string fullName, DateTime dateOfBirth, Company company, Salary salary) : base(fullName, dateOfBirth, company, salary)
        {
        }

        public void AssignTaskTo(EmployeeTask employeeTask, Employee employee)
        {
            if (!(employee is QAManual))
                throw new Exception("QA Manual Lead can assign task to QA Manual only!");

            if (!Company.TaskBoard.Tasks.Contains(employeeTask))
                throw new Exception("Task is not on the company board!");

            employeeTask.AssignedTo = employee;
        }

        public void ReviewTestCase()
        {
            throw new NotImplementedException();
        }
    }
}
