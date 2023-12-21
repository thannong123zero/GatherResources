using System.ComponentModel.DataAnnotations;

namespace CustomizeDataAnnotationDemo.CustomizeDataAnnotation
{
    public class CustomizeEmailValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Custom validation logic goes here
            // Return ValidationResult.Success if the value is valid
            // Return a new ValidationResult with an error message if the value is invalid
            if (value == null)
            {
                return ValidationResult.Success;
            }
            if(value.ToString() == "nguyenhoangtai2k@gmail.com")
            {
                return new ValidationResult("Email is exist!");
            }

            return ValidationResult.Success;
        }
    }
}
