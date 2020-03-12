using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurants
    {
        private List<string> RestaurantsToChoose { get; set; }

        public Restaurants()
        {
            RestaurantsToChoose.Add("Husk");
            RestaurantsToChoose.Add("Applebees");
            RestaurantsToChoose.Add("Panda Express");
            RestaurantsToChoose.Add("Whataburger");
        }
    }

}
