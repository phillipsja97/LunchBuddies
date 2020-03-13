using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
    {
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        List<string> Buddies = new List<string>();
        public LunchBuddy(string first, string last)
        {
        FirstName = first;
        LastName = last;
        Buddies.Add($"Filip Forsberg");
        Buddies.Add("Juuse Sarros");
        Buddies.Add("Ryan Johannson");
        }

        public void Eating()
        {
            var restaurant = new Restaurants();
            var location = restaurant.RandomRestaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating at {location}.");
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office today.");
        }

        public void Company()
        {
            string friends = string.Join(",", Buddies.ToArray());
            var restaurant = new Restaurants();
            var location = restaurant.RandomRestaurant();
            Console.WriteLine($"{FirstName} is eating at {location} with {friends}.");
        }

        public void WhatToEat(string food)
        {
            string friends = string.Join(",", Buddies.ToArray());
            var restaurant = new Restaurants();
            var location = restaurant.RandomRestaurant();
            Console.WriteLine($"{FirstName} is eating {food} at {location} with {friends}");
        }
            

    }
}
