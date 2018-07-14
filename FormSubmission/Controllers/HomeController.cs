using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost("")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                return View("Success");
            }
            return View("Index");

        }


    }
}
