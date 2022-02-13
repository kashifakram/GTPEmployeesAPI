namespace Employees.Domain

{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool Status { get; set; }
        public bool OnGoing { get; set; }
        public string JobType { get; set; } = string.Empty;
        public int HoursPerWeek { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime EndDate { get; set; } = DateTime.Today;

    }
}