using IT.Company;
using IT.Company.Accounting;
using IT.Company.Staff;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("IsSoft");

            CEO ceo = new CEO("Alexander Shneerson", new DateTime(1958, 11, 7), company, new Salary(10000, Currency.USD));
            company.Employees.Add(ceo);
            SoftwareDeveloper softwareDeveloper1 = new SoftwareDeveloper("Ivan Ivanov", new DateTime(2000, 10, 1), company, new Salary(3000, Currency.USD));
            company.Employees.Add(softwareDeveloper1);
            SoftwareDeveloperLead softwareDeveloperLead1 = new SoftwareDeveloperLead("Bob Jonson", new DateTime(1986, 2, 10), company, new Salary(3500, Currency.USD));
            company.Employees.Add(softwareDeveloperLead1);
            BusinessAnalyst businessAnalyst1 = new BusinessAnalyst("Kate Miranovskaya", new DateTime(2001, 6, 7), company, new Salary(1500, Currency.USD));
            company.Employees.Add(businessAnalyst1);
            BusinessAnalystLead businessAnalystLead1 = new BusinessAnalystLead("Anna Trubko", new DateTime(1990, 5, 20), company, new Salary(2000, Currency.USD));
            company.Employees.Add(businessAnalystLead1);
            ProjectManager projectManager1 = new ProjectManager("Andrey Kurio", new DateTime(1986, 3, 25), company, new Salary(3000, Currency.USD));
            QAAutomation qAAutomation1 = new QAAutomation("Valery Kulagin", new DateTime(1990, 4, 5), company, new Salary(2000, Currency.USD));
            company.Employees.Add(qAAutomation1);
            QAAutomationLead qAAutomationLead1 = new QAAutomationLead("Yuri Papko", new DateTime(1985, 6, 13), company, new Salary(3000, Currency.USD));
            company.Employees.Add(qAAutomationLead1);
            QAManual qAManual1 = new QAManual("Irina Zagorovskaya", new DateTime(1991, 2, 17), company, new Salary(1500, Currency.USD));
            company.Employees.Add(qAManual1);
            QAManualLead qAManualLead1 = new QAManualLead("Alena Travkina", new DateTime(1980, 2, 17), company, new Salary(2000, Currency.USD));
            company.Employees.Add(qAManualLead1);


            EmployeeTask employeeTask = new EmployeeTask("D101", "Task 101 for Software Developer.") { Label = EmployeeTaskLabel.Dev };
            company.TaskBoard.Tasks.Add(employeeTask);
            softwareDeveloperLead1.AssignTaskTo(employeeTask, softwareDeveloper1);

            Console.WriteLine(company.GetEmployeesAbilitiesReport());
        }
    }
}
