using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Dojodachi.Controllers
{
    public class DojoController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetObjectFromJson<DojodachiInfo>("Dojodachi") == null)
            //checking to see if the session (that is type 'DojodachiInfo') exists. Null means no it doesnt exist
            {
                HttpContext.Session.SetObjectAsJson("Dojodachi", new DojodachiInfo());
                //creating a new session that will store an object. The object calls the 'SetObjectAsJson() method
                // creating a new key called 'Dojodachi' and instantiating a NEW object from the DojodachiInfo class.
                //the new object 'Dojodachi' will be converted to Json
            }

            // if the Dojodachi exists already. The 'GetObjectFromJson()' method is called. This method will take the Json 
            // and turn it back into an object. From here you will have access to the Objects attributes
            ViewBag.Dojodachi = HttpContext.Session.GetObjectFromJson<DojodachiInfo>("Dojodachi");

            // setting up 'Message', 'GameStatus', 'Reaction' up to be displayed on the index.cshtml
            ViewBag.Message = "You got a brand new Dojodachi!";
            ViewBag.GameStatus = "running";
            ViewBag.Reaction = "";
            return View();
        }

        [HttpPost] // where the form data will be posted an evaluated
        [Route("performAction")]//route the form calls for to be sent
        
        public IActionResult PerformAction(string action)
        {
            //a new varible 'EditDachi' is created as datatype 'DojodachiInfo'. 
            //This new variable is set to the newly reconstructed object with updated attributes)
            DojodachiInfo EditDachi = HttpContext.Session.GetObjectFromJson<DojodachiInfo>("Dojodachi");

            Random RandObject = new Random(); //setting up a way to randomize
            ViewBag.GameStatus = "running"; // eventually, the player will either win or lose. At this point ViewBag.GameStatus will be changed from running
            // to GameStatus = "over" and the game will be over

            // when one of the 4 actions(forms)is clicked, it will come here to determine which action was chosen. Hidden input fields
            // are used to pass the value ('feed','sleep','work','play')
            switch(action) 
            
            {
                case "feed":
                    //checking to see if the dojodachi has any meals left
                    if(EditDachi.Meals > 0){
                        EditDachi.Meals -= 1;
                        if(RandObject.Next(0, 4) > 0) // will pick random #'s b2 0 and 3. 
                        //If the random number is 1,2,3 this IF statement will be used
                        {
                            EditDachi.Fullness += RandObject.Next(5, 11); //random # b2 5-10
                            ViewBag.Reaction = ":)";
                            ViewBag.Message = "Dojodachi enjoyed the meal!";
                        }
                        else // this condition will run when the random # is 0. This is how we create a 75%/25% like to dislike ratio
                        {
                            ViewBag.Reaction = ":(";
                            ViewBag.Message = "Dojodachi didn't like the food very much...";
                        }
                    }
                    else //the dojodachi has no meals left to feed
                    {
                        ViewBag.Reaction = ":(";
                        ViewBag.Message = "You don't have any food for your Dojodachi!";
                    }
                    break;

                case "play":
                    if(EditDachi.Energy > 4) //the dojodachi has to have at least 5 energy to play
                    {
                        EditDachi.Energy -= 5; // playing costs the dojodachi 5 units of energy
                        if(RandObject.Next(0, 4) > 0)
                        {
                            EditDachi.Happiness += RandObject.Next(5, 11); //the dojodachi gains 5-10 units of happiness when playing
                            ViewBag.Reaction = ":)";
                            ViewBag.Message = "Dojodachi had fun playing!";
                        }
                        else // this condition will run when the random # is 0. This is how we create a 75%/25% like to dislike ratio
                        {
                            ViewBag.Reaction = ":(";
                            ViewBag.Message = "Looks like Dojodachi didn't want to play...";
                        }
                    }
                    else // the dojodachi does not have enough energy to play
                    {
                        ViewBag.Reaction = ":(";
                        ViewBag.Message = "Not enough energy...";
                    }

                    break;

                case "work":
                    if(EditDachi.Energy > 4)
                    {
                        EditDachi.Energy -= 5;
                        EditDachi.Meals += RandObject.Next(1, 4);
                        ViewBag.Reaction = ":)";
                        ViewBag.Message = "You worked hard to feed your Dojodachi!";
                    }
                    else // this condition will run when the random # is 0. This is how we create a 75%/25% like to dislike ratio
                    {
                        ViewBag.Reaction = ":(";
                        ViewBag.Message = "Not enough energy...";
                    }
                    break;
                case "sleep":
                    EditDachi.Energy += 15;
                    EditDachi.Fullness -= 5;
                    EditDachi.Happiness -= 5;
                    ViewBag.Reaction = ":)";
                    ViewBag.Message = "Dojodachi seems well rested.";
                    break;
                default:
                    // Handle unxpected values submitted from form
                    ViewBag.Reaction = "XXXXXXXXXXXXXX";
                    ViewBag.Message = "There's a glitch in the martix...";
                    break;

            }

            //after the switch statement is determined, these conditions will execute

            // if either the dojodachis fullness OR happiness is less < 0, these code is run
            if(EditDachi.Fullness < 1 || EditDachi.Happiness < 1)
            {
                ViewBag.Reaction = "X(";
                ViewBag.Message = "Oh no! Your Dojodachi has died...";
                ViewBag.GameStatus = "over";
            }

            // the dojodachi's fullness AND happiness both need to be over 100 for this condition to run
            else if(EditDachi.Fullness > 99 && EditDachi.Happiness > 99)
            {
                ViewBag.Reaction = ":D";
                ViewBag.Message = "Congratulations! You win!";
                ViewBag.GameStatus = "over";
            }

            // the Dojodachi object will be converted to Json to be stored in session
            HttpContext.Session.SetObjectAsJson("Dojodachi", EditDachi);

            // Viewbag is used to store the updated dojodachi object(that has been converted to Json)
            ViewBag.Dojodachi = EditDachi;
            return View("Index");
        }

        [HttpGet]
        [Route("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }

    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
