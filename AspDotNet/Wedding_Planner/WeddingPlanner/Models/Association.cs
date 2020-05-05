    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    namespace WeddingPlanner.Models
    {
        public class Association
        {
            [Key]
            public int AssociationId { get; set; }
            public int UserId { get; set; }
            public int WeddingId { get; set; }
            public User User { get; set; }
            public Wedding Wedding { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }