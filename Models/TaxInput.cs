using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaxCalculatorGlobalBlue.Models
{
    public class TaxInput
    {
        public int Id { get; set; }
        [Range(10,20, ErrorMessage = "Please Select a VAT rate")]
        [Required]
        public double? VAT { get; set; }
        [BadInputValidation]
        public double? Net { get; set; }
        [Display(Name ="Tax Value")]
        public double? Gross { get; set; }
        public double? Total { get; set; }
    }
}