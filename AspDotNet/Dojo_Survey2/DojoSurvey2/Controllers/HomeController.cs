using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey2.Models;

namespace DojoSurvey2.Controllers
{
    public class HomeController : Controller
    {
            [HttpGet("")]
            public ViewResult Index()
            {
                return View();
            }
            [HttpPost("result")]
            public IActionResult Success(Survey mysurvey)
            {
                if(ModelState.IsValid)
                {
                    Survey person = new Survey()
                    {
                        Name = mysurvey.Name,
                        Location = mysurvey.Location,
                        Language = mysurvey.Language,
                        Comment = mysurvey.Comment
                    };
                    return View("Success", person);
                }
                else{
                    return View("Index");
                }
            }
    }
}
