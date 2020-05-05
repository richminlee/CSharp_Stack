using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefDish.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Date(ErrorMessage="Chef must be at least 18 years old.")]
        public DateTime Birthdate { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Dish> CreatedDishes {get;set;}
        public int Age 
        {
            get { return DateTime.Now.Year - Birthdate.Year; }
        } 
    }
    public class DateAttribute : RangeAttribute
   {
        public DateAttribute()
        : base(typeof(DateTime), DateTime.Now.AddYears(-999).ToShortDateString(),     DateTime.Now.AddYears(-18).ToShortDateString()) { } 
   }
}