using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavThings
{
    class Dog
    {
        public string Name { get; set; }

        string _breed;

        public Dog(string breed, string name)
        {
            _breed = breed;
            Name = name;
        }

        public void Walk()
        {
            Console.WriteLine($"Time to walk {Name}");
        }

        public void Brag()
        {
            Console.WriteLine($"Look everyone, I have a {_breed}");
        }
    }
}
