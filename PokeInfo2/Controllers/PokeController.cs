using Microsoft.AspNetCore.Mvc;

namespace PokeInfo
{
    public class PokeController : Controller
    {
        [HttpGet]
        [Route("")]  //localhost/5000
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        [Route("pokeinfo/{id}")] //http://localhost:5000/pokeinfo/77  
        public IActionResult GetInfo(int id)
        {
            var PokeObject = new Pokemon();

            WebRequest.GetPokemonDataAsync(id, PokeResponse => {
                PokeObject = PokeResponse;
            }).Wait();
            ViewBag.Pokemon = PokeObject;
            return View();
        }
       
    }
}