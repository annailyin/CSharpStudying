using IT.Company.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT.Company
{
    public class Company
    {
        public string Name { get; set; }

        public List<Employee> Employees { get; } = new List<Employee>();

        public TaskBoard TaskBoard { get; } = new TaskBoard();

        public Company(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"You're welcome to our company {Name} with staff of {Employees.Count} employees!";
        }

        public string GetEmployeesAbilitiesReport()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var employee in Employees)
            {
                switch (employee)
                {
                    case ICanAssignTask _:
                        sb.AppendLine($"Employee {employee.FullName} can assign task.");
                        break;
                    case ICanReviewCode _:
                        sb.AppendLine($"Employee {employee.FullName} can review code.");
                        break;
                    case ICanReviewTestCase _:
                        sb.AppendLine($"Employee {employee.FullName} can review testcase.");
                        break;
                    case ICanWriteCode _:
                        sb.AppendLine($"Employee {employee.FullName} can write code.");
                        break;
                }
            }

            return sb.ToString();
        }
    }
}
