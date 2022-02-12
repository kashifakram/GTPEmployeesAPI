using System.ComponentModel.DataAnnotations;

namespace EmployeesAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public string? MiddleName { get; set; }

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int Mobile { get; set; }

        [Required]
        public string ResidentialAddress { get; set; } = string.Empty;
    }
}
