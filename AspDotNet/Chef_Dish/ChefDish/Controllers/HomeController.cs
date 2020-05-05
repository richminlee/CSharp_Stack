using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefDish.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ChefDish.Controllers
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
            List<Chef> AllChefs = dbContext.Chefs.Include(i => i.CreatedDishes).ToList();
            var Che = AllChefs.OrderByDescending(l => l.CreatedAt);
            return View(Che);
        }
        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = dbContext.Dishes.Include(i => i.Creator).ToList();
            var Dis = AllDishes.OrderByDescending(l => l.CreatedAt);
            return View(Dis);
        }
        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.Che = AllChefs.OrderByDescending(l => l.CreatedAt);
            return View();
        }
        [HttpPost("new")]
        public IActionResult New(Chef thisChef)
        {
                if(ModelState.IsValid)
                {
                    dbContext.Add(thisChef);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                else{
                    return View("New", thisChef);
                }
        }
        [HttpPost("newdishes")]
        public IActionResult NewDishes(Dish thisDish)
        {
                if(ModelState.IsValid)
                {
                    dbContext.Add(thisDish);
                    dbContext.SaveChanges();
                    return RedirectToAction("Dishes");
                }
                else{
                    List<Chef> AllChefs = dbContext.Chefs.ToList();
                    ViewBag.Che = AllChefs.OrderByDescending(l => l.CreatedAt);
                    return View("NewDish");
                }
        }
        [HttpGet("delete/{chefid}")]
        public IActionResult Delete(int chefid)
        {
            Chef thisChe = dbContext.Chefs.SingleOrDefault(l => l.ChefId == chefid);
            dbContext.Chefs.Remove(thisChe);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet("deleteDish/{dishid}")]
        public IActionResult DeleteDish(int dishid)
        {
            Dish Dishies = dbContext.Dishes.SingleOrDefault(l => l.DishId == dishid);
            dbContext.Dishes.Remove(Dishies);
            dbContext.SaveChanges();
            return RedirectToAction("Dishes");
        }
    }
}
