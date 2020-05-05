using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            int count = new int();
            count=1;
            Random ran = new Random();
            String b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 14;
            String random = "";
            for(int i =0; i<length; i++)
            {
                int a = ran.Next(36);
                random = random + b.ElementAt(a);
            }
            HttpContext.Session.SetString("RandomPass", random);
            HttpContext.Session.SetInt32("Count", count);


            // int counts = 1;
            string randy = HttpContext.Session.GetString("RandomPass");
            int? counts = HttpContext.Session.GetInt32("Count");
            string num = counts.ToString();

            string[] pass = new string[] {randy,num};
            return View("Index", pass);
        }
        [HttpPost("random/{numb}")]
        public IActionResult RandomGen(string numb)
        {
            Random ran = new Random();
            String b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 14;
            String random = "";
            for(int i =0; i<length; i++)
            {
                int a = ran.Next(36);
                random = random + b.ElementAt(a);
            }
            
            int count = Int32.Parse(numb);
            count += 1;

            HttpContext.Session.SetString("RandomPass", random);
            HttpContext.Session.SetInt32("Count", count);


            // int counts = 1;
            string randy = HttpContext.Session.GetString("RandomPass");
            int? counts = HttpContext.Session.GetInt32("Count");
            string num = counts.ToString();

            string[] pass = new string[] {randy,num};
            return View("Index", pass);
        }
        [HttpPost("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
