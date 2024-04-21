namespace RoutingExample.Models
{
    public class PopulationViewModel
    {
        public PopulationViewModel(string country, string[] cities)
        {
            if (country != null)
            { 
            CountryInformation=new List<string>();
                if (cities == null)
                    CountryInformation.Add("Population of " + country + " - " + CountryInfoCreator.GetCounrtyPopulation(country));
                else { foreach (string city in cities) 
                    {
                        CountryInformation.Add("Population of " + city + " - " + CountryInfoCreator.GetCityPopulation(country, city)); 
                    } 
                }
            }
        }

        public List<string> CountryInformation { get;  set; }
    }
}
