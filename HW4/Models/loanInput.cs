using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _460HW4.Models
{
    public class loanInput
    {
        [Required(ErrorMessage = "Please enter the loan amount")]
        public string principal { get; set; }

        [Required(ErrorMessage = "Please enter the interest rate")]
        public string interest { get; set; }

        [Required(ErrorMessage = "Please enter the number of months")]
        public string months { get; set; }
    }
}