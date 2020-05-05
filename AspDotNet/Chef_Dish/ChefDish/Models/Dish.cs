using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChefDish.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        [Display(Name = "Name of Dish")]
        public string Name { get; set; }
        [Required]
        [Range(1,5)]
        public int Tastiness { get; set; }
        [Required]
        [Range(1,999999999999999999)]
        [Display(Name = "# of Calories")]
        public int Calories { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        [Display(Name = "Chef")]
        public int ChefId {get;set;}
        [ForeignKey("ChefId")]
        public Chef Creator {get;set;}
    }
}