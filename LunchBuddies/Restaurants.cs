using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurants
    {
        List<string> restaurantGroup = new List<string>();
        public Restaurants()
        {
            restaurantGroup.Add("Husk");
            restaurantGroup.Add("Waffle House");
            restaurantGroup.Add("Taco Bell");
            restaurantGroup.Add("Lockeland Table");
            restaurantGroup.Add("Whataburger");
        }

        public string RandomRestaurant()
        {
            var random = new Random();
            var list = restaurantGroup;
            int index = random.Next(list.Count);
            return list[index];
        }
    }
}
