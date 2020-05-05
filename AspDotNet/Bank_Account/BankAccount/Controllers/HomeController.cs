using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BankAccount.Controllers
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
            return View();
        }
        [HttpPost("new")]
        public IActionResult New(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("Account");
                
            }
            else{
                return View("Index");
            }
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet("account")]
        public IActionResult Account()
        {
            int? userid = HttpContext.Session.GetInt32("UserId");
            ViewBag.Us = dbContext.Users.SingleOrDefault(l => l.UserId == userid);
            if(userid == null)
            {
                return View("Index");
            }
            else
            {
                List<Transaction> AllTrans= dbContext.Transactions.ToList();
                ViewBag.thisTrans= AllTrans.OrderByDescending(l => l.CreatedAt);
                return View();
            }
        }
        [HttpPost("logged")]
        public IActionResult Logged(LoginUser logged)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == logged.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(logged, userInDb.Password, logged.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Account");
            }
            else
            {
                return View("Login");
            }
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpPost("update")]
        public IActionResult Update(decimal amount)
        {
            ModelState.AddModelError("Amount", "Balance is insufficient");
            int? userid = HttpContext.Session.GetInt32("UserId");
            ViewBag.Us = dbContext.Users.SingleOrDefault(l => l.UserId == userid);
            List<Transaction> AllTrans= dbContext.Transactions.ToList();
            ViewBag.thisTrans= AllTrans.OrderByDescending(l => l.CreatedAt);
            User CurrentUser = dbContext.Users.SingleOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            if (amount > 0)
            {
                CurrentUser.Balance += amount;
                Transaction NewTransaction = new Transaction
                {
                    Amount = amount,
                    CreatedAt = DateTime.Now,
                    UserId = CurrentUser.UserId
                };
                dbContext.Add(NewTransaction);
                dbContext.SaveChanges();
                return RedirectToAction("Account");
            }
            
            else
            {
                if (CurrentUser.Balance + amount < 0)
                {
                    return View("Account");
                }
                else
                {
                    CurrentUser.Balance += amount;
                    Transaction NewTransaction = new Transaction
                    {
                        Amount = amount,
                        CreatedAt = DateTime.Now,
                        UserId = CurrentUser.UserId
                    };
                    dbContext.Add(NewTransaction);
                    dbContext.SaveChanges();
                    return RedirectToAction("Account");
                }
            }
        }
    }
}
