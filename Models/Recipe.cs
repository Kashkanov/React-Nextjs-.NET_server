using System.Globalization;

namespace server.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
    }
}
