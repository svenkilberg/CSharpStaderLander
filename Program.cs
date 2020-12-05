using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSharpStaderLander
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the JSON file from hard drive and store it in variable.
            string countryJson = System.IO.File.ReadAllText(@"land.json");

            // Use Json.NET from Newtonsoft.Json nuget package to deserialize JSON to .NET objects.
            // Store the objects in an list.
            List<Country> countryList = JsonConvert.DeserializeObject<List<Country>>(countryJson);

            // Same handling as above for the next JSON file
            string cityJson = System.IO.File.ReadAllText(@"stad.json");

            List<City> cityList = JsonConvert.DeserializeObject<List<City>>(cityJson);

            // Prints the result
            string countryName;

            foreach (var city in cityList)
            {
                if(city.Countryid == 1) countryName = "Sverige";
                else if(city.Countryid == 2) countryName = "Finland";
                else countryName = "Norge";
                

                Console.WriteLine($"{city.Stadname} är en stad som ligger i {countryName} och har {city.Population} innvånare.");
                Console.WriteLine();
            }
 


        }
    }
}
