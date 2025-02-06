using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRecipes()
        {
            var recipes = new List<string> { "Pasta", "Pizza", "Salad" };
            return Ok(recipes);
        }
    }
}
