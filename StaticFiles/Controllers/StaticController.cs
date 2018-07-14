using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

 
namespace Static.Controllers  //Controllers is a sub namespace
{
     public class StaticController : Controller  //HelloController inherits all classes from Controller
    {
        [HttpGet]
        [Route("home")]  // ==> localhost:5000/home  

        public IActionResult Home() 
        {
           
            
            return View();
        }

        [HttpGet]
        [Route("projects")] // ==> localhost:5000/projects
        public IActionResult Projects()
        {
            return View();
        }

        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        [Route("about")]
        public IActionResult About()
        {
            return View();
        }





    }
}

        /*[HttpGet]
        [Route("displayint")]
        public JsonResult DisplayInt()
            {
                return Json(34);
            }

        [HttpGet]
        [Route("edit")]
        public IActionResult edit()
        {
            return View();
        }

        [HttpGet]
        [Route("delete")]
        public IActionResult Delete()
        {
            
            return View();
        }
 
*/
