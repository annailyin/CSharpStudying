using IT.Company.Staff;
using System;
using System.Collections.Generic;

namespace IT
{
    public class EmployeeByFullNameLengthComparer : IComparer<Employee>
    {
        public int Compare(Employee employee1, Employee employee2)
        {
            if (employee1.Equals(null) || employee2.Equals(null))
                throw new Exception("Employee shouldn't be null!");
            return employee1.FullName.Length.CompareTo(employee2.FullName.Length);
        }
    }
}
