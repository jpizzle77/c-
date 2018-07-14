using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RandomPasscode.Controllers
{
    public class CodeController : Controller
    {
        [HttpGet]
        [Route("")] //localhst/5000
        public IActionResult Index()
        {
            int? RunCount = HttpContext.Session.GetInt32("RunCount");
            //int variables are non-nullable
            // use int ? to store null if nothing exists yet in session

            if(RunCount == null) //if session is empty
            {
                RunCount = 0; //set RunCount to 0
            }
            RunCount += 1; //increment 
            string PossibleCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string PassCode = "";
            string PassCode2 = "";
            Random Rand = new Random();
            for(int i = 0; i < 14; i++)
            {
                PassCode = PassCode + PossibleCharacters[Rand.Next(0, PossibleCharacters.Length)];    
            }
            for(int i = 0; i < 14; i++)
            {
                PassCode2 = PassCode2 + PossibleCharacters[Rand.Next(0, PossibleCharacters.Length)];    
            }
            TempData["Variable"] = PassCode;
            ViewBag.PassCode = PassCode;
            ViewBag.PassCode2 = PassCode2;
            ViewBag.RunCount = RunCount;
            HttpContext.Session.SetInt32("RunCount", (int)RunCount);
            return View();
        }
    }
}