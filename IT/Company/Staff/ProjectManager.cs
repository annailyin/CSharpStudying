using IT.Company.Accounting;
using System;

namespace IT.Company.Staff
{
    public class ProjectManager : Employee, ICanAssignTask
    {
        public ProjectManager(string fullName, DateTime dateOfBirth, Company company, Salary salary) : base(fullName, dateOfBirth, company, salary)
        {
        }

        public void AssignTaskTo(EmployeeTask employeeTask, Employee employee)
        {
            if (!Company.TaskBoard.Tasks.Contains(employeeTask))
                throw new Exception("Task is not on the company board!");

            employeeTask.AssignedTo = employee;
        }
    }
}
