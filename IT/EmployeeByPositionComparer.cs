using IT.Company.Staff;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IT
{
    public class EmployeeByPositionComparer : IComparer<Employee>
    {
        private static readonly Dictionary<Type, short> Dictionary = new Dictionary<Type, short>
        {
            { typeof(CEO), 1 },
            { typeof(ProjectManager), 2 },
            { typeof(BusinessAnalystLead), 3 },
            { typeof(QAAutomationLead), 3 },
            { typeof(QAManualLead), 3 },
            { typeof(SoftwareDeveloperLead), 3 },
            { typeof(BusinessAnalyst), 4 },
            { typeof(QAAutomation), 4 },
            { typeof(QAManual), 4 },
            { typeof(SoftwareDeveloper), 4 }
        };

        public int Compare(Employee employee1, Employee employee2)
        {
            if (employee1.Equals(null) || employee2.Equals(null))
                throw new Exception("Employee shouldn't be null!");

            short key1 = Dictionary[employee1.GetType()];
            short key2 = Dictionary[employee2.GetType()];
            return key1.CompareTo(key2);
        }
    }
}
