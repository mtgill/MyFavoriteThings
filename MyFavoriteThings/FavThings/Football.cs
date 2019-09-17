using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavThings
{
    class Football
    {
        public string TeamName { get; set; }

        string _record;
        public Football(string teamName, string record)
        {
            TeamName = teamName;
            _record = record;
        }

        public void CheckRecord()
        {
            Console.WriteLine($"Your team is currently {_record}");
        }

        public void BandWagon()
        {
            Console.WriteLine("So you've decided to jump on the bandwagon, who is your new team??");
            var newTeam = Console.ReadLine();
            TeamName = newTeam;
            Console.WriteLine($"Congrats on being a {TeamName} fan");
        }
    }
}
