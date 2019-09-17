using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavThings
{
    class Pizza
    {
        public string Crust { get; set; }

        int _size;

        public Pizza(int size, string crust)
        {
            _size = size;
            Crust = crust;
        }

        public void AddToppings(string[] toppings)
        {

            Console.WriteLine("These are your current toppings");
            for (var i = 0; i < toppings.Length; i++)
            {
                if (toppings[i] == " pineapple")
                {
                    Console.WriteLine("There will be no pineapple on this pizza");
                    i++;
                }
                Console.WriteLine(toppings[i]);
            }
        }

        public void CrustSelector(string crustChoice)
        {
            if (crustChoice == "deep dish")
            {
                Console.WriteLine("Deep dish pizza isn't pizza, it's cheese casserole");
                Crust = "thin crust";
                Console.WriteLine($"I fixed it for you, your pizza is now {Crust}");
                return;
            }
            Console.WriteLine($"Good choice, {crustChoice} is the best");
        }

    }
}
