using System;
using System.ComponentModel.DataAnnotations;
namespace SereneEmployees.Personnel
{ 
    public class DateRangeValidationAttribute : ValidationAttribute
    {
        private readonly DateTime _minDate;

        public DateRangeValidationAttribute(string minDate)
        {
             _minDate = DateTime.Parse(minDate);
             ErrorMessage = $"Hire date must be on or after {_minDate.ToShortDateString()}.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime hireDate && hireDate < _minDate)
            {
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
