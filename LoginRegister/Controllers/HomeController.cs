using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegister.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginRegister.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            IndexView model = new IndexView() // you need to initialize an object of IndexView
            //to have access to the class models inside (User and LoginUser from User.cs)
            // on index.cshtml you will have @model IndexView (means it expects a object of IndexView)
            {
                Messages = DbConnector.Query("SELECT * FROM users") //will grab all the users from the DB
                // and save it a a list that was created in the ViewModels.cs
            };
            return View(model);
        }


        [HttpGet("success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("id") == null)
            {
                return RedirectToAction("LoginView");
            }

            int user_session =(int)HttpContext.Session.GetInt32("id");
            ViewBag.Session= user_session;

            


            return View(user_session);
        }


        [HttpPost("register")]
        public IActionResult Register(IndexView model)
        {
            User user = model.NewUser;
            //make sure email is unique
            string checkEmail = $"SELECT id FROM users WHERE email ='{user.email}'";
            if(DbConnector.Query(checkEmail).Count > 0)
            {
               ModelState.AddModelError("email", "email already exists"); 
            }
           
            if(ModelState.IsValid)
            { 
                //hash plain text password
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                string hashed = hasher.HashPassword(user, user.password);
               
                string query = $@"INSERT INTO users(first_name,last_name,email,password, created_at, updated_at)
                                VALUES('{user.first_name}','{user.last_name}','{user.email}','{hashed}', NOW(),NOW())";
                
                DbConnector.Execute(query);
                
                
               /* string query2 = $"SELECT last_insert_id() as 'id'";
                //Dictionary<string,object> new_user_id = new Dictionary<string,object>();
                object new_user_id = DbConnector.Query(query2);
                System.Console.WriteLine(new_user_id + " shittttttttttttttttttttttttt");

                
                TempData["last_id"] = new_user_id;  //this code doesnt work to grab last_id*/

                TempData["success"] = "You have successfully registered. Please log in";
                return RedirectToAction("LoginView"); //make sure to set a route to make RediretToAction to work
                // return View("Success");
            }
    
            return View("Index");
        }
        
        [HttpGet("login")]
        public IActionResult LoginView()
        {
            
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(IndexView model)
        {
            
            LoginUser user = model.LogUser;

            if(ModelState.IsValid)
             {
                //check that email is in the database
                string checkEmail = $"SELECT id, password FROM users WHERE email ='{user.log_email}'";
                //Dictionary<string,object> userToLog = DbConnector.Query(checkEmail).FirstOrDefault();
                var userToLog = DbConnector.Query(checkEmail).FirstOrDefault();


                if(userToLog == null) //means no email in database
                {
                    ModelState.AddModelError("email", "invalid email or password 1"); 
                }
                    
                    //check hashed password if email exists in database
                    //if VerifyHashedPassword evaluates to 0, the passwords do not match
                else
                {
                    string hashedPWfromDB = (string)userToLog["password"];
                    PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                    if(hasher.VerifyHashedPassword(user, hashedPWfromDB, user.log_password) == 0)
                    {
                        ModelState.AddModelError("password", "invalid email or password 2");  
                    }
                                    
                    //log in user
                    HttpContext.Session.SetInt32("id",(int)userToLog["id"]);
                    TempData["id"] = "Thanks for logging in";
                    return RedirectToAction("Index", "Wall");

                }
             }
           
           
            return View("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
       

    }


}
