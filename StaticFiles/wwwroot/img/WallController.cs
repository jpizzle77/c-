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
    [Route("wall")]
    public class WallController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("id") == null) //this will check to make sure someone is signed. If no one has signed in they will be redirected to the Index page in HomeController
            {
                return RedirectToAction("Index", "Home");
            }
           // Dictionary<string,object> user = DbConnector.Query($"SELECT * FROM users WHERE id = {HttpContext.Session.GetInt32("id")}").FirstOrDefault();
            
        
           string query = @"SELECT messages.id AS message_id, messages.message, messages.created_at, users.first_name, users.last_name 
                             FROM messages JOIN users ON messages.users_id = users.id";
          

           IndexView model = new IndexView()
           {
               
               Messages = DbConnector.Query(query)
             
           };

           
            return View(model);

        }

        [HttpGet("comments/{id}")]
        public IActionResult Comment(string id)
        {
             if(HttpContext.Session.GetInt32("id") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            
            string query = $@"SELECT messages.id AS message_id, messages.message, messages.created_at, users.first_name, users.last_name 
                             FROM messages JOIN users ON messages.users_id = users.id WHERE messages.id = {id}";

            string comment_query = $@"SELECT messages.id AS message_id, comments.id AS comment_id, comments.messages_id, comments.comment, comments.created_at, users.first_name, users.last_name 
                            FROM comments JOIN messages ON comments.messages_id = messages.id
                            JOIN users ON comments.users_id = users.id";

            IndexView model = new IndexView()
            {
                 Message = DbConnector.Query(query),
                 Comments = DbConnector.Query(comment_query)
            };
            return View(model);
        }


        [HttpPost("create")]
        public IActionResult Create(IndexView wallModel)
        {
            
            if(ModelState.IsValid)
            {
                string insert_query = $@"INSERT INTO messages(message, users_id, created_at, updated_at) 
                                VALUES('{wallModel.NewMessage.message}', {(int)HttpContext.Session.GetInt32("id")}, NOW(), NOW())";
                DbConnector.Execute(insert_query);
                return RedirectToAction("Index");
            }
            
            return View("Index", wallModel);
        }

        [HttpPost("createComment")]
        public IActionResult CreateComment(IndexView commentModel)
        {
            //Comment comment = new Comment();
            
            if(ModelState.IsValid)
            {
                string insert_query = $@"INSERT INTO comments(comment, messages_id, users_id, created_at, updated_at) 
                                VALUES('{commentModel.NewComment.comment}',{commentModel.NewComment.messages_id},
                                 {(int)HttpContext.Session.GetInt32("id")}, NOW(), NOW())";
                DbConnector.Execute(insert_query);
                return RedirectToAction("Index");
            }
            
            return View("Index", commentModel);
        }


    
    
    }

}