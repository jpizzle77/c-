using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Example.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("cat")]
        public string Index()
        {
            return "Hello World!";
        }

        [HttpGet]
        [Route("template/{Name}")]
        public IActionResult Method(string Name)
        {
            ViewBag.Name = Name;
            TempData["Name"]= Name;
            return View("index");
        }

        [HttpGet]
        [Route("shitfuck")]
        public IActionResult Shit()
        {
            Dictionary<string,string> profile = new Dictionary<string,string>();
            ViewBag.Profile = profile;
            {
                profile.Add("Name", "Speros");
                profile.Add("Language", "PHP");
                profile.Add("Location", "Greece");
                            };
            return View("index");
        }
        
     }
 }