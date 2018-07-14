using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPFORMSnSHIT.Models;

namespace ASPFORMSnSHIT.Controllers
{
   
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User user)
        {
            //if location = "Seattle"
            if(user.location != null && user.location.ToLower()=="seattle")
            {
                ModelState.AddModelError("location", "no dipshits from seattle");
            }

            if(ModelState.IsValid)
            {
                   return  View("Show",user);
            }

            return View("Index");

        }

    }

}