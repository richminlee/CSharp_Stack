    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    namespace Products.Models
    {
        public class Category
        {
            [Key]
            public int CategoryId { get; set; }
            [Required]
            public string Name { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
            public List<Association> ProductsfromCategory {get; set;}
        }
    }