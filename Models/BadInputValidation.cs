using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaxCalculatorGlobalBlue.Models
{
    public class BadInputValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var tax = (TaxInput)validationContext.ObjectInstance;

            if ((tax.Gross==null && tax.Net==null && tax.Total==null) || (tax.Gross > 0 || tax.Net >0 || tax.Total > 0))
            {
                return new ValidationResult("One field must be grater than 0");
            }
            else
            {
                //
                return ValidationResult.Success;
            }
        }
    }
}