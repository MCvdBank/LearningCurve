using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LearnMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [FirstNameValidation]
        public string FirstName { get; set; }

        [StringLength(15, ErrorMessage = "Last Name length should not be greater than 15")]
        public string LastName { get; set; }
        
        public int? Salary { get; set; }
    }

    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) // Checking for Empty Value
            {
                return new ValidationResult("Please Provide First Name");
            }
            else
            {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("First Name should Not contain @");
                }
            }
            return ValidationResult.Success;
        }
    }
}