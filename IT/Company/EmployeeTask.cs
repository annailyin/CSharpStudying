using IT.Company.Staff;

namespace IT.Company
{
    public class EmployeeTask
    {
        public string Number { get; }

        public string Description { get; }

        public Employee AssignedTo { get; set; }

        public EmployeeTaskStatus Status { get; set; }

        public EmployeeTaskLabel Label { get; set; }

        public EmployeeTask (string number, string description)
        {
            Number = number;
            Description = description;
        }
    }
}
