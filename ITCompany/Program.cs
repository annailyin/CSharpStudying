using System;

namespace ITCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            ITCompany company = new ITCompany("SmartThings", new CEO("Igor", "Borodin", 55, new Salary(10000, Currency.EUR)));
            company.HireEmployee(new DevEmployee("Vladimir", "Bondar", 30, new Salary(3500, Currency.EUR), "C#"));
            company.HireEmployee(new DevEmployee("Konstantin", "Brilev", 25, new Salary(4000, Currency.EUR), "Java"));
            company.HireEmployee(new DevEmployee("Gleb", "Vint", 27, new Salary(3300, Currency.EUR), "TypeScript"));
            company.HireEmployee(new BAEmployee("Anna", "Ivanova", 25, new Salary(2500, Currency.EUR), "Excel"));
            company.HireEmployee(new BAEmployee("Olga", "Petrova", 22, new Salary(2000, Currency.EUR), "Excel"));
            company.HireEmployee(new QAEmployee("Ivan", "Ivanov", 26, new Salary(2000, Currency.EUR), "Jira"));
            company.HireEmployee(new QAEmployee("Irina", "Solovey", 23, new Salary(1800, Currency.EUR), "Bugzilla"));
            company.HireEmployee(new QAAutomationEmployee("Gleb", "Parfenov", 24, new Salary(2100, Currency.EUR), "Backlog", "Python"));
            company.HireEmployee(new QAAutomationEmployee("Kira", "Kachenova", 28, new Salary(2000, Currency.EUR), "Lighthouse", "C#"));
            company.HireEmployee(new QAAutomationEmployee("Petr", "Dainov", 27, new Salary(1900, Currency.EUR), "Lighthouse", "Java"));
            foreach (var employee in company.Employees)
                Console.WriteLine(employee.GetJobDescription());
            Console.WriteLine(company);
        }
    }
}
