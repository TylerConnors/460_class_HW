using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace _460HW5.Models
{
    public class WOUForm
    {
        public int ID { get; set; }

        [Display(Name = "V Number"), Required]
        public string VNum { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string First_Name { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }

        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone_Number { get; set; }

        [Required]
        [Display(Name = "Catalogue Year")]
        public int Catalog_Year { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Major")]
        public string Major { get; set; }

        [Required]
        [Display(Name = "Minor")]
        public string Minor { get; set; }

        [Required]
        [Display(Name = "Advisor")]
        public string Advisor { get; set; }

        
        public override string ToString()
        {
        return $"{base.ToString()}: ID = {ID} VNum = {VNum} First_Name = {First_Name} Last_Name = {Last_Name}  DATE = {Date} Phone = {Phone_Number} Catalog_year = {Catalog_Year} Email = {Email} Major = {Major} Minor = {Minor} Advisor = {Advisor}";
        }
    }
}