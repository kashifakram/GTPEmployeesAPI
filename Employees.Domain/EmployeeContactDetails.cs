using System.ComponentModel.DataAnnotations;

namespace Employees.Domain
{
    public class EmployeeContactDetails
    {
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int Mobile { get; set; }

        [Required]
        public string ResidentialAddress { get; set; } = string.Empty;
    }
}