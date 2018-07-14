using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP1.Models;


namespace ASP1.Controllers
{
    
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            User userguy = new User
            {
                first_name = "freddy",
                last_name = "kruger",
                age = 45


            };
           
            return View(userguy);
            //return View("About", userguy);
        }
        [HttpGet("new")]
        public IActionResult New()
        {
            return View(new User());
        }

        [HttpGet("friend")]
        public IActionResult AnotherForm()
        {
            return View();
        }

        [HttpGet("animal")]
        public IActionResult Animal()
        {
            return View();
        }

        [HttpGet("movie")]
        public IActionResult Movie()
        {
            return View();
        }

        [HttpGet("actor")]
        public IActionResult Actor()
        {
            return View();
        }

        [HttpGet("dog")]
        public IActionResult Dog()
        {
            return View();
        }

        [HttpGet("fruit")]
        public IActionResult Fruit()
        {
            return View();
        }

        [HttpGet("veggie")]
        public IActionResult Veggie()
        {
            return View();
        }

        // All HTTP-POSTS BELOW. These are the routes when a form is submitted
        [HttpPost("create")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                  return Json(user);
            }
            
            return View("New", user);
          
        }
        [HttpPost("createFriend")]
        public IActionResult CreateFriend(Friend friend)
        {
            if(ModelState.IsValid)
            {
                return Json(friend);
            }
            return View("AnotherForm", friend);

        }

        [HttpPost("createAnimal")]
        public IActionResult CreateAnimal(Animal animal)
        {
            if(ModelState.IsValid)
            {
                return Json(animal);
            }
            return View("Animal", animal);
        }

        [HttpPost("addMovie")]
        public IActionResult AddMovie(Movie movie)
        {
            if(ModelState.IsValid)
            {
                return Json(movie);
            }
            return View("Movie", movie);
        }

        [HttpPost("addActor")]
        public IActionResult AddActor(Actor actor)
        {
            if(ModelState.IsValid)
            {
                return Json(actor);
            }
            return View("Actor", actor);
        }

        [HttpPost("addDog")]
        public IActionResult AddDog(Dog dog)
        {
            if(ModelState.IsValid)
            {
                return Json(dog);
            }
            return View("Dog", dog);
        }

        [HttpPost("addFruit")]
        public IActionResult AddFruit(Fruit fruit)
        {
            if(ModelState.IsValid)
            {
                return Json(fruit);
            }
            return View("Fruit", fruit);
        }

        [HttpPost("addVeggie")]
        public IActionResult AddVeggie(Veggie veggie)
        {
            if(ModelState.IsValid)
            {
                return Json(veggie);
            }
            return View("Veggie", veggie );
        }

      
    }
}
