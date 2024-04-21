namespace RoutingExample.Models
{
    public static class CountryInfoCreator
    {
        private static readonly Country[] CountriesArray = new[]
        {
            new Country()
            {
                Name = "China", Population="1.412 billion",
                Cities=new List<City>()
                {
                    new City() {Name="Beijing", Population="21.54 million"}
                }
            },
            new Country()
            {
                Name="Italy", Population="54,94 million",
                Cities=new List<City>()
                {
                    new City() { Name="Rome", Population="2.873 million" },
                    new City() {Name = "Venice", Population = "261.905"}
                }
            }
        };

        public static string GetCounrtyPopulation(string country)
        {
            foreach (Country country1 in CountriesArray)
            {
                if (country == country1.Name) return country1.Population;
            }
            return "";
        }

        public static string GetCityPopulation(string country, string city)
        {
            string population = "";
            foreach (Country country1 in CountriesArray)
            {
                if (country == country1.Name)
                {
                    foreach (City city1 in country1.Cities)
                    {
                        if (city1.Name==city)
                            population= city1.Population;
                    }
                }
            }
            return population;
        }
    }
}
