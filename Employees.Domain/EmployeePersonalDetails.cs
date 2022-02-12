using System.ComponentModel.DataAnnotations;

namespace Employees.Domain

{
    public class EmployeePersonalDetails
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public string? MiddleName { get; set; }
        public EmployeeContactDetails EmployeeContactDetails { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }

    }
}