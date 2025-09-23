using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace Veterinaria.Validaciones
{
    public class NoCaracteresEspeciales : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {

                return base.IsValid(value, validationContext);
            }

            string pattern = @"^[\p{L}\s]+$";

            if (!Regex.IsMatch(value.ToString(), pattern))
            {
                return new ValidationResult("Tu nombre no debe tener caracteres especiales");
            }


            return ValidationResult.Success;
        }
        public NoCaracteresEspeciales()
        {
        }
    }
}

