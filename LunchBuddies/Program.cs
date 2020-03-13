using System;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var rando = new LunchBuddy("Jamie", "Phillips");
            var friend1 = new LunchBuddy("Ronald", "Reagan");
            rando.Eating();
            friend1.eat("spaghetti");
            rando.Company();
            friend1.WhatToEat("Fried Chicken");
            var companion = new LunchBuddy("Jamie", "Phillips");
            Console.ReadLine();
        }

       
    }
}
