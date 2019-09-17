using System;
using System.Collections.Generic;
using MyFavoriteThings.FavThings;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of candy are you eating?");
            var candyName = Console.ReadLine();

            Console.WriteLine("How many are you going to eat?");
            var amount = int.Parse(Console.ReadLine());

            var candy = new Candy(candyName, amount);

            candy.Eat();

            candy.Share();


            Console.WriteLine("What would you like on your pizza?");
            var myToppings = Console.ReadLine();
            var toppingList = myToppings.Split(",");

            Console.WriteLine("What kind of crust would you like?");
            var crust = Console.ReadLine();

            var myPizza = new Pizza(16, crust);

            myPizza.AddToppings(toppingList);
            myPizza.CrustSelector(crust);

            var myDog = new Dog("Golden Retriever", "Woofles");

            myDog.Walk();

            myDog.Brag();

            var myFavTeam = new Football("Packers", "1-0");

            myFavTeam.CheckRecord();

            myFavTeam.BandWagon();
        }
    }
}
