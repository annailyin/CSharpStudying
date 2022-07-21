using IT.Company;
using IT.Company.Accounting;
using IT.Company.Staff;
using IT;
using System;
using System.Linq;
using System.Text;

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
            softwareDeveloper1.Skills.Add(new Skill("C#"));
            softwareDeveloper1.Skills.Add(new Skill("Java"));
            softwareDeveloper1.Skills.Add(new Skill("TypeScript"));

            SoftwareDeveloper softwareDeveloper2 = new SoftwareDeveloper("Ivan Krivoy", new DateTime(1987, 05, 21), company, new Salary(3100, Currency.USD));
            company.Employees.Add(softwareDeveloper2);
            softwareDeveloper2.Skills.Add(new Skill("C#"));
            softwareDeveloper2.Skills.Add(new Skill("Java"));
            softwareDeveloper2.Skills.Add(new Skill("TypeScript"));
            softwareDeveloper2.Skills.Add(new Skill("SQL"));

            SoftwareDeveloper softwareDeveloper3 = new SoftwareDeveloper("Anna Trubko", new DateTime(1986, 05, 20), company, new Salary(2700, Currency.USD));
            company.Employees.Add(softwareDeveloper3);
            softwareDeveloper2.Skills.Add(new Skill("C#"));
            softwareDeveloper2.Skills.Add(new Skill("SQL"));

            SoftwareDeveloperLead softwareDeveloperLead1 = new SoftwareDeveloperLead("Bobber Jonson", new DateTime(1986, 2, 10), company, new Salary(3500, Currency.USD));
            company.Employees.Add(softwareDeveloperLead1);
            softwareDeveloperLead1.Skills.Add(new Skill("C#"));
            softwareDeveloperLead1.Skills.Add(new Skill("Java"));
            softwareDeveloperLead1.Skills.Add(new Skill("JavaScript"));
            softwareDeveloperLead1.Skills.Add(new Skill("Python"));

            BusinessAnalyst businessAnalyst1 = new BusinessAnalyst("Katarina Miranovskaya", new DateTime(2001, 6, 7), company, new Salary(1500, Currency.USD));
            company.Employees.Add(businessAnalyst1);

            BusinessAnalystLead businessAnalystLead1 = new BusinessAnalystLead("Anna Trubko", new DateTime(1990, 5, 20), company, new Salary(2000, Currency.USD));
            company.Employees.Add(businessAnalystLead1);

            ProjectManager projectManager1 = new ProjectManager("Andrey Kurio", new DateTime(1986, 3, 25), company, new Salary(3000, Currency.USD));

            QAAutomation qAAutomation1 = new QAAutomation("Valery Kulagin", new DateTime(1990, 4, 5), company, new Salary(2000, Currency.USD));
            company.Employees.Add(qAAutomation1);
            qAAutomation1.Skills.Add(new Skill("C#"));
            qAAutomation1.Skills.Add(new Skill("SQL"));

            QAAutomationLead qAAutomationLead1 = new QAAutomationLead("Yuri Papko", new DateTime(1985, 6, 13), company, new Salary(3000, Currency.USD));
            company.Employees.Add(qAAutomationLead1);
            qAAutomationLead1.Skills.Add(new Skill("C#"));
            qAAutomationLead1.Skills.Add(new Skill("SQL"));
            qAAutomationLead1.Skills.Add(new Skill("Java"));

            QAManual qAManual1 = new QAManual("Irina Zagorovskaya", new DateTime(1991, 2, 17), company, new Salary(1500, Currency.USD));
            company.Employees.Add(qAManual1);
            QAManualLead qAManualLead1 = new QAManualLead("Alena Travkina", new DateTime(1980, 2, 17), company, new Salary(2000, Currency.USD));
            company.Employees.Add(qAManualLead1);


            EmployeeTask employeeTask = new EmployeeTask("D101", "Task 101 for Software Developer.") { Label = EmployeeTaskLabel.Dev };
            company.TaskBoard.Tasks.Add(employeeTask);
            softwareDeveloperLead1.AssignTaskTo(employeeTask, softwareDeveloper1);

            //Console.WriteLine(company.GetSortedEmployees(new EmployeeByFullNameLengthComparer()));
            //Console.WriteLine(company.GetSortedEmployees(new EmployeeBySalaryComparer()));
            //Console.WriteLine(company.GetSortedEmployees(new EmployeeByPositionComparer()));
            //Console.WriteLine(company.GetEmployeesAbilitiesReport());

            //LINQ
            var countEmployeesWriteCode = company.Employees
                .Where(x => x is ICanWriteCode)
                .Count();
            Console.WriteLine($"The quantity of employees who can write code: {countEmployeesWriteCode}.\n");

            var maxEmployeeSalary = company.Employees
                .Max(x => x.Salary.Value);
            Console.WriteLine($"The maximum employee salary: {maxEmployeeSalary}.\n");

            var employeeFullNameStartWithI = company.Employees
                .Where(x => x.FullName.ToUpper().StartsWith("I")).OrderBy(x => x.FullName).ToList();
            Console.WriteLine($"The list of Employees with FullName starts with I:\n{company.GetListOfEmployees(employeeFullNameStartWithI)}");

            var allSkillNames = company.Employees
                .SelectMany(x => x.Skills)
                .Select(x => x.Name)
                .Distinct();

            var programmingLanguages = allSkillNames
                .Where(x => Constants.ProgrammingLanguages.Contains(x));

            Console.WriteLine($"List of programming languages that at least one employee in the company knows:\n{string.Join(", ", programmingLanguages)}.\n");

            var employeesByPositionCount = company.Employees
                .GroupBy(x => x.GetType().Name)
                .Select(g => new { EmployeePosition = g.Key, Count = g.Count() });

            Console.WriteLine($"Position name and quantity of employees:\n{string.Join(", ", employeesByPositionCount)}.\n");

            var averageEmployeeSalary = company.Employees.
                Average(x => x.Salary.Value);
            Console.WriteLine($"The average employee salary: {averageEmployeeSalary}.\n");

            var averageEmployeeSalaryByPosition = company.Employees
                .GroupBy(x => x.GetType().Name)
                .Select(g => new { EmployeePosition = g.Key, AverageSalary = g.Average(s => s.Salary.Value) });

            Console.WriteLine($"Position name and average salary:\n{string.Join(", ", averageEmployeeSalaryByPosition)}.\n");

            var emp = company.Employees.Select(p => new
            {
                FullName = p.FullName,
                Salary = p.Salary.Value
            }).ToList();
            Console.WriteLine($"List of employees and salary:\n{string.Join(", ", emp)}.\n");
        }
    }
}
