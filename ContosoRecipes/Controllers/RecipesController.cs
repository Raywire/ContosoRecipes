using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoRecipes.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
        // GET: api/Recipes
        [HttpGet]
        public ActionResult GetRecipes([FromQuery] int count)
        {
            Recipe[] recipes = {
                new() { Title ="Oxtail"},
                new() { Title ="Curry Chicken"},
                new() { Title ="Dumplings" }
            };

            return Ok(recipes.Take(count));
        }

        // GET api/Recipes/:id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Recipes
        [HttpPost]
        public ActionResult CreateNewRecipes([FromBody] Recipe newRecipe)
        {
            bool badThingsHappened = false;
            if (badThingsHappened)
                return BadRequest();
            return Created("", newRecipe);
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
