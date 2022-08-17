using IT.Company;
using IT.Company.Staff;

namespace IT
{
    public interface ICanAssignTask
    {
        void AssignTaskTo(EmployeeTask employeeTask, Employee employee);
    }
}
