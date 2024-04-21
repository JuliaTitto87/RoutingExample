namespace RoutingExample.Models
{
    public class Country
    {
        public required string Name { get; set; }
        public required string Population { get; set; }

        public List<City>? Cities { get; set; }
    }
}
