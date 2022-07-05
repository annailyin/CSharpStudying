using System;
using System.Collections.Generic;
using System.Text;

namespace ITCompany
{
    class ITCompany
    {
        public List<Employee> Employees { get; set; }

        public string CEO { get; set; }

        public string Name { get; set; }

        public static int Counter { get; set; } = 0;

        public ITCompany(string ceo, string name)
        {
            Employees = new List<Employee>();
            CEO = ceo;
            Name = name;
        }

        public void HireEmployee(Employee employee)
        {
            Employees.Add(employee);
            Counter++;
        }

        public void FireEmployee(Employee employee)
        {
            Employees.Remove(employee);
            Counter--;
        }

        public void PrintCompanyInfo()
        {
            Console.WriteLine("\nYou're welcome to our company {0} with {1} as President and staff of {2} employees!", Name, CEO, Counter);
        }

    }
}
