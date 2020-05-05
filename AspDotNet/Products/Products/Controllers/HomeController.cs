using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Products.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;


namespace Products.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Product> AllProducts = dbContext.Products.ToList();
            ViewBag.Prod = AllProducts.OrderByDescending(l => l.CreatedAt);
            return View("Product");
        }
        [HttpGet("product")]
        public IActionResult Product()
        {
            List<Product> AllProducts = dbContext.Products.ToList();
            ViewBag.Prod = AllProducts.OrderByDescending(l => l.CreatedAt);
            return View();
        }
        [HttpGet("category")]
        public IActionResult Category()
        {
            List<Category> AllCategories = dbContext.Categories.ToList();
            ViewBag.Cate = AllCategories.OrderByDescending(l => l.CreatedAt);
            return View();
        }
        [HttpPost("newProduct")]
        public IActionResult NewProduct(Product thisProduct)
        {
                List<Product> AllProducts = dbContext.Products.ToList();
                ViewBag.Prod = AllProducts.OrderByDescending(l => l.CreatedAt);
                if(ModelState.IsValid)
                {
                    dbContext.Add(thisProduct);
                    dbContext.SaveChanges();
                    return RedirectToAction("Product");
                }
                else{
                    return View("Product");
                }
        }
        [HttpPost("newCategory")]
        public IActionResult NewCategory(Category thisCategory)
        {
            List<Category> AllCategories = dbContext.Categories.ToList();
            ViewBag.Cate = AllCategories.OrderByDescending(l => l.CreatedAt);
            if(ModelState.IsValid)
            {
                dbContext.Add(thisCategory);
                dbContext.SaveChanges();
                return RedirectToAction("Category");
            }
            else{
                return View("Category");
            }
        }
        [HttpGet("product/{productid}")]
        public IActionResult ProductThis(int productid)
        {
            ShowAllWrapper vMod = new ShowAllWrapper();
            vMod.ThisProduct = dbContext.Products
                .Include(b => b.CategoriesfromProduct)
                .ThenInclude(v => v.Category)
                .FirstOrDefault(b => b.ProductId == productid);
            List<Category> AllCategories = dbContext.Categories.ToList();
            List<Category> NewList = new List<Category>{};
            foreach(var i in vMod.ThisProduct.CategoriesfromProduct)
            {
                NewList.Add(i.Category);
            }
            vMod.CatsNotInProd = AllCategories
                .Except(NewList).ToList();
            return View(vMod);
        }
        [HttpGet("category/{categoryid}")]
        public IActionResult CategoryThis(int categoryid)
        {
            ShowAllWrapper vMod = new ShowAllWrapper();
            vMod.ThisCategory = dbContext.Categories
                .Include(b => b.ProductsfromCategory)
                .ThenInclude(v => v.Product)
                .FirstOrDefault(b => b.CategoryId == categoryid);
            List<Product> AllProducts = dbContext.Products.ToList();
            List<Product> NewList = new List<Product>{};
            foreach(var i in vMod.ThisCategory.ProductsfromCategory)
            {
                NewList.Add(i.Product);
            }
            vMod.ProdsNotInCat = AllProducts
                .Except(NewList).ToList();
            return View(vMod);
        }
        [HttpPost("addcategory/{productid}")]
        public IActionResult AddCategory(int productid, ShowAllWrapper thisCategory)
        {
            thisCategory.Association.ProductId = productid;
            if(ModelState.IsValid)
            {
                dbContext.Add(thisCategory.Association);
                dbContext.SaveChanges();
                return RedirectToAction("ProductThis", new {productid = productid});
            }
            else{
                return RedirectToAction("ProductThis", new {productid = productid});
            }
        }
        [HttpPost("addproduct/{categoryid}")]
        public IActionResult AddProduct(int categoryid, ShowAllWrapper thisProduct)
        {
            thisProduct.Association.CategoryId = categoryid;
            if(ModelState.IsValid)
            {
                dbContext.Add(thisProduct.Association);
                dbContext.SaveChanges();
                return RedirectToAction("CategoryThis", new {categoryid = categoryid});
            }
            else{
                return RedirectToAction("CategoryThis", new {categoryid = categoryid});
            }
        }
    }
}
