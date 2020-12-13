﻿using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants; 

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.French},
                new Restaurant {Id = 1, Name = "Ruchi's", Cuisine = CuisineType.Indian},
                new Restaurant {Id = 1, Name = "Olive Garden", Cuisine = CuisineType.Italian}

            }; 
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name); 
        }
    }
}
