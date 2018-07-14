using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using example8.Models; //this will include anything in the Models folder

namespace example8.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {

            //List<Dictionary<string,object>> friends = DbConnector.Query("SELECT * FROM users");
            //ViewBag.Friends = friends;
            ViewBag.Friends = DbConnector.Query("SELECT * FROM users");
            System.Console.WriteLine(ViewBag.Friends+"shit fuck");
            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            Movie movie = new Movie()
            {
                Title = "rambo",
                Director ="some dipshit"
            };
            
             return View(movie);
        }

        [HttpGet("friend/{id}")]
        public IActionResult Show(int id)
        {
            string query= $"SELECT * FROM users WHERE id={id}";
            ViewBag.Friend = DbConnector.Query(query).First(); 
            //this query will grab an individual user
            //the query returns a list of dictionaries
            // using First() will allow us to grab the first(and only) object in the list

            return View();  //will return the Show.cshtml
        }
        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            string query= $"SELECT * FROM users WHERE id={id}";
            ViewBag.Friend = DbConnector.Query(query).First(); 
            //this returns a list of dictionaries
            // using First() will allow us to grab the first(and only) object in the list

            return View();  //will return the Delete.cshtml
        }


         // Below are all HTTP POSTS. These routes are called when a form is submitted

         [HttpPost("createFriend")]
        public IActionResult CreateFriend(Friend friend)
        {
            if(ModelState.IsValid)
            {
                string query = $@"INSERT INTO users (first_name, last_name, created_at) 
                                VALUES('{friend.first_name}', '{friend.last_name}', NOW())";

                DbConnector.Execute(query);
                return RedirectToAction("Index");
            }
    
            return View("Index", friend);
        }

        [HttpPost("submit2")]
        public IActionResult CreateEnemy(People people)
        {
           ViewBag.People = people;

            return View("Show");

        }

       [HttpPost("make")]
        public IActionResult Make(Movie movie)
        {
            return View("About");
        }

        [HttpPost("update")]
        public IActionResult UpdateFriend(Friend friend)
        {
            string query = $@"UPDATE users SET first_name = '{friend.first_name}', 
                            last_name = '{friend.last_name}' 
                            WHERE id = {friend.id}";
            
            DbConnector.Execute(query);

            return RedirectToAction("Index");
        }

        [HttpPost("delete")]
        public IActionResult DeleteFriend(Friend friend)
        {
            string query = $@"DELETE FROM users 
                            WHERE id = {friend.id}";
            
            DbConnector.Execute(query);

            return RedirectToAction("Index");
        }



    }
}
