using System;

namespace ITCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            ITCompany company = new ITCompany("Igor Borodin", "SmartThings");
            company.HireEmployee(new DevEmployee("Vladimir", "Bondar", 30, 3500, "C#"));
            company.HireEmployee(new DevEmployee("Konstantin", "Brilev", 25, 4000, "C#, Java"));
            company.HireEmployee(new DevEmployee("Gleb", "Vint", 27, 3300, "C#, TypeScript"));
            company.HireEmployee(new BAEmployee("Anna", "Ivanova", 25, 2500, "ClickUp, Excel"));
            company.HireEmployee(new BAEmployee("Olga", "Petrova", 22, 2000, "ClickUp, Excel"));
            company.HireEmployee(new QAEmployee("Ivan", "Ivanov", 26, 2000, "Jira"));
            company.HireEmployee(new QAEmployee("Irina", "Solovey", 23, 1800, "Bugzilla"));
            company.HireEmployee(new QAAutomationEmployee("Gleb", "Parfenov", 24, 2100, "Backlog", "Python"));
            company.HireEmployee(new QAAutomationEmployee("Kira", "Kachenova", 28, 2000, "Lighthouse", "C#"));
            company.HireEmployee(new QAAutomationEmployee("Petr", "Dainov", 27, 1900, "Lighthouse", "Java"));
            foreach (var employee in company.Employees)
                employee.DoYourJob();
            company.PrintCompanyInfo();
        }
    }
}
