using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPnForms.Models;


namespace ASPnForms.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Person person = new Person
            {
                first_name = "dip",
                last_name = "dipshit",
                age = 45


            };
            return View(person);
        }

       
    }
}
