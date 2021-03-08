using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoRecipes.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/recipes")]
    public class RecipesController : Controller
    {
        // GET: api/Recipes
        [HttpGet]
        public ActionResult GetDishes()
        {
            string[] recipes = { "Oxtail", "Curry Chicken", "Dumplings" };

            if (!recipes.Any())
                return NotFound();
            return Ok(recipes);
        }

        // GET api/Recipes/:id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Recipes
        [HttpPost]
        public void CreateNewRecipes([FromBody] string value)
        {
        }

        // PUT api/Recipes/:id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Recipes/:id
        [HttpDelete("{id}")]
        public ActionResult DeleteRecipes(int id)
        {
            bool badThingsHappened = false;
            if (badThingsHappened)
                return BadRequest();
            return NoContent();
        }
    }
}
