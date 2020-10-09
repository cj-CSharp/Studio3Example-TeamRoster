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

        public Roster(string teamName, DateTime lastUpdate, List<Player> players)
        {
            TeamName = teamName;
            Players = players;
            LastUpdate = lastUpdate;
        }
        public Roster(string teamName, DateTime lastUpdate) : this(teamName, lastUpdate, new List<Player>()) { }
        public Roster(string teamName) : this(teamName, DateTime.Now, new List<Player>()) { }
        public Roster() : this("", DateTime.Now, new List<Player>()) { }

    }
}
