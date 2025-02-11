namespace server.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Served { get; set; }
        public Ingredient() { }
    }
}
