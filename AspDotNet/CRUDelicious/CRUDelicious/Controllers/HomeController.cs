using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Http;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private CrudContext dbContext;
        public HomeController(CrudContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            var Dishies = AllDishes.OrderByDescending(l => l.CreatedAt);

            return View(Dishies);
        }
        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }
        [HttpPost("new")]
        public IActionResult New(Dish thisDish)
        {
                if(ModelState.IsValid)
                {
                    dbContext.Add(thisDish);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                else{
                    return View("New", thisDish);
                }
        }
        [HttpGet("{dishid}")]
        public IActionResult Number(int dishid)
        {
            Dish Dishies = dbContext.Dishes.SingleOrDefault(l => l.DishId == dishid);
            return View(Dishies);
        }
        [HttpGet("delete/{dishid}")]
        public IActionResult Delete(int dishid)
        {
            Dish Dishies = dbContext.Dishes.SingleOrDefault(l => l.DishId == dishid);
            dbContext.Dishes.Remove(Dishies);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet("edit/{dishid}")]
        public IActionResult Edit(int dishid)
        {
            Dish Dishies = dbContext.Dishes.SingleOrDefault(l => l.DishId == dishid);
            return View(Dishies);
        }
        [HttpPost("edited/{dishid}")]
        public IActionResult Edited(int dishid, Dish thisDish)
        {
                if(ModelState.IsValid)
                {
                    thisDish.DishId = dishid;
                    dbContext.Update(thisDish);
                    dbContext.Entry(thisDish).Property("CreatedAt").IsModified = false;
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Edit", thisDish);
                }
        }
    }
}
