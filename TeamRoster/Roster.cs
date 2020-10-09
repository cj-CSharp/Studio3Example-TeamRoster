using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeamRoster
{
    class Roster
    {
        public string TeamName { get; set; }
        public List<Player> Players { get; set; }
        public DateTime LastUpdate { get; set; }

        public Roster(string teamName, List<Player> players, DateTime lastUpdate)
        {
            TeamName = teamName;
            Players = players;
            LastUpdate = lastUpdate;
        }
        public Roster(string teamName, DateTime lastUpdate) : this(teamName, new List<Player>(), lastUpdate) { }
        public Roster() : this("", new List<Player>(), DateTime.Now) { }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{TeamName} Roster\nNumber of Players: {Players.Count}\n\n");
            foreach(Player individual in Players)
            {
                result.Append($"{individual.JerseyNumber} {individual.LastName}, {individual.FirstName}\n");
            }
            result.Append($"\nLast Updated: {LastUpdate}");
            return result.ToString();
        }

    }
}
