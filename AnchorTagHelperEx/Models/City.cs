using System;
using System.Collections.Generic;

namespace AnchorTagHelperEx.Models
{
	public class City
	{
		public Int64	CityID { get; set; }
		public string CityName { get; set; }
		public static List<City> GetCities()
		{ 
		  List<City> cities = new List<City>();
		  cities.Add(new City() { CityID = 1, CityName = "Pune" });
		  cities.Add(new City() { CityID = 2, CityName = "Mumbai" });
		  cities.Add(new City() { CityID = 3, CityName = "Delhi" });
		  cities.Add(new City() { CityID = 4, CityName = "Noida" });
		  cities.Add(new City() { CityID = 5, CityName = "Chennai" });

			return cities;
		}
	}
}
