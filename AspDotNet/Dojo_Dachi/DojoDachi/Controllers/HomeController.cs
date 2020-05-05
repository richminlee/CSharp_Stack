using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoDachi.Models;
using Microsoft.AspNetCore.Http;

namespace DojoDachi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int? ful = HttpContext.Session.GetInt32("Fullness");
            int? hap = HttpContext.Session.GetInt32("Happiness");
            int? ene = HttpContext.Session.GetInt32("Energy");
            int? mea = HttpContext.Session.GetInt32("Meals");
            string mes = HttpContext.Session.GetString("Message");

            if (ful <= 0 ||hap <= 0 )
            {
                mes = $"Your Dojodachi has passed away.";
                Dachi update = new Dachi((int)ful, (int)hap, (int)ene, (int)mea, mes );
                return View("Index", update);
            }
            else if (ful >= 100 && hap >= 100 && ene >= 100 )
            {
                mes = "Congratulations! You won!";
                Dachi update = new Dachi((int)ful, (int)hap, (int)ene, (int)mea, mes );
                return View("Index", update);
            }

            else if (ful != null)
            {
                Dachi update = new Dachi((int)ful, (int)hap, (int)ene, (int)mea, mes );
                return View("Index",update);
            }

            else
            {
                Dachi first = new Dachi();
                HttpContext.Session.SetInt32("Fullness", first.Fullness);
                HttpContext.Session.SetInt32("Happiness", first.Happiness);
                HttpContext.Session.SetInt32("Energy", first.Energy);
                HttpContext.Session.SetInt32("Meals", first.Meals);
                HttpContext.Session.SetString("Message", first.Message);

                return View("Index", first);
            }

        }
        [HttpPost("feed")]
        public IActionResult Feed()
        {
            int? ful = HttpContext.Session.GetInt32("Fullness");
            int? hap = HttpContext.Session.GetInt32("Happiness");
            int? ene = HttpContext.Session.GetInt32("Energy");
            int? mea = HttpContext.Session.GetInt32("Meals");
            string mes = HttpContext.Session.GetString("Message");
            if (mea >= 1)
            {
            Random randy = new Random();
            int numbe = randy.Next(1,5);
            if (numbe == 1)
            {
                mea -= 1;
                mes = $"You fed your Dojodachi Meals-1.";
                HttpContext.Session.SetInt32("Meals", (int)mea);
                HttpContext.Session.SetString("Message", mes);
            }
            else
            {
                Random rand = new Random();
                mea -= 1;
                int numb = rand.Next(5,11);
                ful += numb;
                mes = $"You fed your Dojodachi Meals-1 & Fullness+{numb}.";
                HttpContext.Session.SetInt32("Meals", (int)mea);
                HttpContext.Session.SetInt32("Fullness", (int)ful);
                HttpContext.Session.SetString("Message", mes);
            }

            }

            return RedirectToAction("Index");
        }
        [HttpPost("play")]
        public IActionResult Play()
        {
            Random randy = new Random();
            int numbe = randy.Next(1,5);
            int? ful = HttpContext.Session.GetInt32("Fullness");
            int? hap = HttpContext.Session.GetInt32("Happiness");
            int? ene = HttpContext.Session.GetInt32("Energy");
            int? mea = HttpContext.Session.GetInt32("Meals");
            string mes = HttpContext.Session.GetString("Message");

            if (numbe == 1)
            {
                ene -= 5;
                mes = $"You played with your Dojodachi Energy-5";
                HttpContext.Session.SetInt32("Energy", (int)ene);
                HttpContext.Session.SetString("Message", mes);
            }
            else
            {
                if (ene >= 5)
                {
                    Random rand = new Random();
                    ene -= 5;
                    int numb = rand.Next(5,11);
                    hap += numb;
                    mes = $"You played with your Dojodachi Energy-5 & Happiness+{numb}";
                    HttpContext.Session.SetInt32("Energy", (int)ene);
                    HttpContext.Session.SetInt32("Happiness", (int)hap);
                    HttpContext.Session.SetString("Message", mes);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost("work")]
        public IActionResult Work()
        {
            int? ful = HttpContext.Session.GetInt32("Fullness");
            int? hap = HttpContext.Session.GetInt32("Happiness");
            int? ene = HttpContext.Session.GetInt32("Energy");
            int? mea = HttpContext.Session.GetInt32("Meals");
            string mes = HttpContext.Session.GetString("Message");
            
            if (ene >= 5)
            {
                Random rand = new Random();
                ene -= 5;
                int numb = rand.Next(1,4);
                mea += numb;
                mes = $"Your Dojodachi worked! Energy-5 & Meals+{numb}.";
                HttpContext.Session.SetInt32("Energy", (int)ene);
                HttpContext.Session.SetInt32("Meals", (int)mea);
                HttpContext.Session.SetString("Message", mes);
            }
            
            return RedirectToAction("Index");
        }
        [HttpPost("sleep")]
        public IActionResult Sleep()
        {
            int? ful = HttpContext.Session.GetInt32("Fullness");
            int? hap = HttpContext.Session.GetInt32("Happiness");
            int? ene = HttpContext.Session.GetInt32("Energy");
            int? mea = HttpContext.Session.GetInt32("Meals");
            string mes = HttpContext.Session.GetString("Message");
            
            ene += 15;
            ful -= 5;
            hap -= 5;
            mes = $"Your Dojodachi slept! Energy+15, Fullness-5 & Happiness-5.";
            HttpContext.Session.SetInt32("Energy", (int)ene);
            HttpContext.Session.SetInt32("Fullness", (int)ful);
            HttpContext.Session.SetInt32("Happiness", (int)hap);
            HttpContext.Session.SetString("Message", mes);
            
            return RedirectToAction("Index");
        }
        [HttpPost("restart")]
        public IActionResult Restart()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
