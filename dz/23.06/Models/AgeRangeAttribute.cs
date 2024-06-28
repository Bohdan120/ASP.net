using System.ComponentModel.DataAnnotations;

namespace _23._06.Models
{
    public class AgeRangeAttribute : ValidationAttribute
    {
        private readonly int _min;
        private readonly int _max;

        public AgeRangeAttribute(int min, int max)
        {
            _min = min;
            _max = max;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is int age)
            {
                if (age >= _min && age <= _max)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult($"Вік повинен бути в межах {_min}-{_max} років");
                }
            }
            return new ValidationResult("Некоректний вік");
        }
    }
}
