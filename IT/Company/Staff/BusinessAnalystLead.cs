using IT.Company.Accounting;
using System;

namespace IT.Company.Staff
{
    public class BusinessAnalystLead : BusinessAnalyst, ICanAssignTask
    {
        public BusinessAnalystLead(string fullName, DateTime dateOfBirth, Company company, Salary salary) : base(fullName, dateOfBirth, company, salary)
        {
        }

        public void AssignTaskTo(EmployeeTask employeeTask, Employee employee)
        {
            if (!(employee is BusinessAnalyst))
                throw new Exception("Business Analyst Lead can assign task to Business Analyst only!");

            if (!Company.TaskBoard.Tasks.Contains(employeeTask))
                throw new Exception("Task is not on the company board!");

            employeeTask.AssignedTo = employee;
        }
    }
}
