using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutingExample.Models;

namespace RoutingExample.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult GetPopulation(string country, string city) 
        {
            string[] cityArray;
            if (city != null)
            {
                cityArray = city.Split('/');
            }
            else cityArray = null;
            return View(new PopulationViewModel(country, cityArray));
        } 
    }
}
