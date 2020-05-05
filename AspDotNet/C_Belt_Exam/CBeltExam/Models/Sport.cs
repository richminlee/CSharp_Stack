using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace CBeltExam.Models
{
    public class Sport
    {
        [Key]
        public int SportId {get;set;}
        [Required]
        [Display(Name = "Title:")]
        public string SportName {get;set;}
        [Date(ErrorMessage = "Activity must be in the future")]
        public DateTime Date {get;set;}
        // public DateTime Time {get;set;}
        public int Duration {get;set;}
        public string DurationHour {get;set;}
        [Required]
        public string Description {get;set;}
        public List <Association> UsersfromSport{get;set;}
        public User Creator {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
    public class DateAttribute : RangeAttribute
   {
        public DateAttribute()
        : base(typeof(DateTime), 
            DateTime.Now.ToString("MM/dd/yyyy"),     
            DateTime.Now.AddYears(100).ToString("MM/dd/yyyy")) 
        { } 
   }
}