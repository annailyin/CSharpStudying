using IT.Company.Accounting;
using System;

namespace IT.Company.Staff
{
    public class SoftwareDeveloperLead : SoftwareDeveloper, ICanAssignTask, ICanWriteCode, ICanReviewCode
    {
        public SoftwareDeveloperLead(string fullName, DateTime dateOfBirth, Company company, Salary salary) : base(fullName, dateOfBirth, company, salary)
        {
        }

        public void AssignTaskTo(EmployeeTask employeeTask, Employee employee)
        {
            if (!(employee is SoftwareDeveloper))
                throw new Exception("Software Developer Lead can assign task to Software Developer only!");

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
