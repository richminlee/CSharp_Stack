using System;
using Microsoft.AspNetCore.Mvc;
    namespace TimeDisplay.Controllers
    {
        public class HomeController : Controller
        {

            [HttpGet("")]
            public ViewResult Index()
            {
                return View();
            }
        }
    }