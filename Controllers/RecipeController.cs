using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

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
       /* public async Task GetRecipes()
        {
            var recipes = new List<string> { "Pasta", "Pizza", "Salad" };
            await Clients.All.SendAsync("GetRecipe", recipes);
        }*/
    }
}
