using Microsoft.AspNetCore.SignalR;
using server.Data;
using server.Models;

namespace server.messageHub
{
    public class MessageHub : Hub
    {
        private readonly ServerContext _context;

        public MessageHub(ServerContext context)
        {
            _context = context;
        }
        
        public async Task GetRecipes()
        {
            var recipes = _context.Recipes.ToList();
            foreach (var recipe in recipes)
            {
                Console.WriteLine(recipe.Name);
            }
            await Clients.All.SendAsync("GetRecipes", recipes);
        }

        public async Task PostRecipe(string name, int prepTime, int CookTime, string Description)
        {
            var newRecipe = new Recipe { Name = name, PrepTime = prepTime, CookTime = CookTime, Description = Description };
            try
            {
                Console.WriteLine("Received recipe: " + newRecipe.Name);  // This should be printed
                _context.Recipes.Add(newRecipe);
                await _context.SaveChangesAsync();
                await Clients.All.SendAsync("UpdateRecipes", name, prepTime, CookTime, Description);  // Broadcast the new recipe
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in PostRecipe: " + ex.Message);  // Log any errors
            }
        }
    }
}
