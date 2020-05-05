using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CBeltExam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;

namespace CBeltExam.Controllers
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
            return RedirectToAction("Signin");
        }
        [HttpGet("signin")]
        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost("new")]
        public IActionResult New(ThisWrapper newUser)
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if(regex.IsMatch(newUser.ThisUser.Password))
            {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.ThisUser.Email))
                {
                    ModelState.AddModelError("ThisUser.Email", "Email already in use!");
                    return View("Signin");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.ThisUser.Password = Hasher.HashPassword(newUser.ThisUser, newUser.ThisUser.Password);
                dbContext.Add(newUser.ThisUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.ThisUser.UserId);
                return RedirectToAction("Dashboard");
            }
            else{
                return View("Signin");
            }
            }
            else
            {
                ModelState.AddModelError("ThisUser.Password", "Password requires One Number, One Uppercase Letter and One Special Character");
                return View("Signin");
            }
            
        }
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? userid = HttpContext.Session.GetInt32("UserId");
            if(userid == null)
            {
                return View("Signin");
            }
            else
            {
                ThisWrapper vMod = new ThisWrapper();
                vMod.AllSports = dbContext.Sports
                    .Include(b => b.UsersfromSport)
                    .ThenInclude(v => v.User)
                    .Include(c => c.Creator)
                    .ToList();
                vMod.ThisUser = dbContext.Users
                    .FirstOrDefault(u => u.UserId == (int)userid);
                return View(vMod);
            }
        }
        [HttpPost("logged")]
        public IActionResult Logged(ThisWrapper logged)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == logged.ThisLoginUser.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("ThisLoginUser.Email", "Invalid Email/Password");
                    return View("Signin");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(logged.ThisLoginUser, userInDb.Password, logged.ThisLoginUser.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("ThisLoginUser.Email", "Invalid Email/Password");
                    return View("Signin");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Signin");
            }
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Signin");
        }
        [HttpGet("sport/{sportid}")]
        public IActionResult OneSport(int sportid)
        {
            int? userid = HttpContext.Session.GetInt32("UserId");
            ThisWrapper vMod = new ThisWrapper();
            vMod.ThisSport = dbContext.Sports
                .Include(b => b.UsersfromSport)
                .ThenInclude(v => v.User)
                .Include(d => d.Creator)
                .FirstOrDefault(b => b.SportId == sportid);
            vMod.AllSports = dbContext.Sports
                .Include(b => b.UsersfromSport)
                .ThenInclude(v => v.User)
                .ToList();
            vMod.ThisUser = dbContext.Users
                .FirstOrDefault(u => u.UserId == (int)userid);
            return View(vMod);
        }
        [HttpPost("createsport")]
        public IActionResult CreateSport(Sport thisSport)
        {
            if(ModelState.IsValid)
            {
                    int? userid = HttpContext.Session.GetInt32("UserId");
                    User CurrentUser = dbContext.Users
                        .FirstOrDefault(u => u.UserId == (int)userid);
                    Sport newSport = new Sport
                    {
                        SportName = thisSport.SportName,
                        Date = thisSport.Date,
                        // Time = thisSport.Time,
                        Duration = thisSport.Duration,
                        DurationHour = thisSport.DurationHour,
                        Description = thisSport.Description,
                        Creator = CurrentUser
                    };
                    dbContext.Add(newSport);
                    dbContext.SaveChanges();
                    var OneSport = dbContext.Sports
                    .FirstOrDefault(u => u.SportName == thisSport.SportName);
                    var sportid = OneSport.SportId;
                    return RedirectToAction("OneSport", new {sportid = sportid});
            }
            else{
                return View("Sport");
            }
        }
        [HttpGet("sport")]
        public IActionResult Sport()
        {
            return View();
        }
        [HttpPost("delete/{sportid}")]
        public IActionResult Delete(int sportid)
        {
            var OneSport = dbContext.Sports
                .FirstOrDefault(u => u.SportId == sportid);
            dbContext.Remove(OneSport);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpPost("join/{sportid}")]
        public IActionResult Join(int sportid, ThisWrapper ThisUser)
        {
            ThisUser.Association.SportId = sportid;
            dbContext.Add(ThisUser.Association);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");       
        }
        [HttpPost("leave/{sportid}")]
        public IActionResult Leave(int sportid)
        {
            int? userid = HttpContext.Session.GetInt32("UserId");
            var thisAsso = dbContext.Associations
                .FirstOrDefault(u => u.SportId == sportid && u.UserId == (int)userid );
            dbContext.Remove(thisAsso);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpPost("joina/{sportid}")]
        public IActionResult Joina(int sportid, ThisWrapper ThisUser)
        {
            ThisUser.Association.SportId = sportid;
            dbContext.Add(ThisUser.Association);
            dbContext.SaveChanges();
            return RedirectToAction("OneSport", new{sportid = sportid});       
        }
        [HttpPost("leavea/{sportid}")]
        public IActionResult Leavea(int sportid)
        {
            int? userid = HttpContext.Session.GetInt32("UserId");
            var thisAsso = dbContext.Associations
                .FirstOrDefault(u => u.SportId == sportid && u.UserId == (int)userid );
            dbContext.Remove(thisAsso);
            dbContext.SaveChanges();
            return RedirectToAction("OneSport", new{sportid = sportid});
        }
    }
}
