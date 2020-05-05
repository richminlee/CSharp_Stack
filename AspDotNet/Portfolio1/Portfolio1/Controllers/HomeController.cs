using System;
    using Microsoft.AspNetCore.Mvc;
    namespace Portfolio1.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet("")]
            public ViewResult Index()
            {
                return View();
            }
            [HttpGet("projects")]
            public ViewResult Projects()
            {
                return View();
            }
            [HttpGet("contacts")]
            public ViewResult Contact()
            {
                return View();
            }
        }
    }