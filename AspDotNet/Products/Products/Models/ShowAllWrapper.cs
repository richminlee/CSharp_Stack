using System;
using System.Collections.Generic;
namespace Products.Models
{
    public class ShowAllWrapper
    {
        public Product ThisProduct {get;set;}
        public Category ThisCategory {get;set;}
        public Association Association {get; set;}
        public List<Product> AllProducts {get;set;}
        public List<Product> ProdsNotInCat {get;set;}
        public List<Category> AllCategories {get;set;}
        public List<Category> CatsNotInProd {get;set;}
        public List<Association> AllAssociations {get;set;}
    }
}