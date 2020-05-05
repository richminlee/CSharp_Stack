using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string word = new string
            (
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            );

            return View("Index", word);
        }
        [HttpGet("numbers")]
        public IActionResult Number()
        {
            int[] numbers = new int[]
            {
            1,2,3,4,5,6
            };
            return View(numbers);
        }
        [HttpGet("users")]
        public IActionResult Users()
        {
            User personOne = new User()
            {
                FirstName = "Moose",
                LastName = "Philips"
            };
            User personTwo = new User()
            {
                FirstName = "Richard",
                LastName = "Lee"
            };            
            User personThree = new User()
            {
                FirstName = "Manilyn",
                LastName = "Lee"
            };
            List<User> user = new List<User>()
            {
                personOne, personTwo, personThree
            };
            return View("users", user);
        }
        [HttpGet("user")]
        public IActionResult Person()
        {
            User person = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            return View("User",person);
        }
    }
}

