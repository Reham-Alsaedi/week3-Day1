using System.ComponentModel.DataAnnotations;

namespace EmployeeMangment.Models
{
    public class Employee
    {
        // Employee ID - primary key
        public int Id { get; set; }

        // Employee Name with required validation and max length constraint
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public required string Name { get; set; }

        // Position with required validation and max length constraint
        [Required(ErrorMessage = "Position is required")]
        [StringLength(50, ErrorMessage = "Position cannot be longer than 50 characters")]
        public required string Position { get; set; }

        // Salary with range validation
        [Required(ErrorMessage = "Salary is required")]
        [Range(0, 1000000, ErrorMessage = "Salary must be between 0 and 1,000,000")]
        public decimal Salary { get; set; }
    }
}
