using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AgeValidation
{
    class AgeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int age = int.Parse(value.ToString());
            if (age >= 1 && age <= 100)
            {
                return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false,
                    "Age should be in range [1-100]");
            }
        }
    }
}