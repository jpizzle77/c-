using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

 
namespace HelloAsp.Controllers  //Controllers is a sub namespace
{
     public class HelloController : Controller  //HelloController inherits all classes from Controller
    {
        [HttpGet]
        [Route("")]  // ==> localhost:5000/   [Route("index")] ==> localhost5000 /index

         //templates/views
       // public ViewResult Index() //return a VIEW respone  OR
       public IActionResult Index() //IactionResult lets you do any of the 4 responses (return a string, JSON, views, or redirects)
        {
           
            
            return View();
        }

        [HttpGet]
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
 



        











     /*   public string Index2() //return a string response
        {
            return "shitfuck fuckshit!";
        }

     //json
        public JsonResult YahJson() //return a JSON respone
        {
            return Json(new {hello ="World"});
        }

        //redirect
        public RedirectToActionResult YahRedirect() // return a redirect response
        {
            return RedirectToAction("Index");
        }*/
       
 
    }
}