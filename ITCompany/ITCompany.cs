using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class ITCompany
    {
        public List<Employee> Employees { get; set; }

        public CEO CEO { get; set; }

        public string Name { get; set; }

        public ITCompany(string name, CEO ceo)
        {
            Employees = new List<Employee>();
            Name = name;
            CEO = ceo;
        }

        public void HireEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void FireEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public override string ToString()
        {
            return $"You're welcome to our company {Name} with staff of {Employees.Count} employees!";
        }
    }
}
