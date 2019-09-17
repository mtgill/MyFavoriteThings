using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavThings
{
    class Candy
    {
        public string Name { get; set; }
        public int HowManyToEat { get; set; }

        public Candy(string name, int amountEaten)
        {
            Name = name;
            HowManyToEat = amountEaten;
        }

        public void Eat()
        {
            if (Name == "tootsie rolls")
            {
                Console.WriteLine("Hard pass, no tootsie rolls for me");
                return;
            }
            Console.WriteLine($"You are enjoying {HowManyToEat} {Name}");
        }

        public void Share()
        {
            if (Name == "Snickers")
            {
                Console.WriteLine($"Sorry, I will not be sharing my {Name} with you");
                return;
            }
            Console.WriteLine("How many would you like to share?");
            var amountToShare = int.Parse(Console.ReadLine());
            Console.WriteLine($"I will share {amountToShare} of my {Name}");
        }
    }
}
