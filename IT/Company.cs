using System;

namespace IT
{
    public class Company
    {
        public string Name { get; set; }

        public CEO CEO { get; set; }

        public List<Employee> Employees { get; } = new List<Employee>();

        public Company(string name, CEO ceo)
        {
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
