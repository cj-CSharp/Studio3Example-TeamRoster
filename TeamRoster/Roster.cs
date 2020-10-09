using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeamRoster
{
    class Roster
    {
        //Getters, Setters, Properties using default getters and setters
        public string TeamName { get; set; } 
        public List<Player> Players { get; set; }
        public DateTime LastUpdate { get; set; }

        //Constructors
        public Roster(string teamName, DateTime lastUpdate, List<Player> players)
        {
            TeamName = teamName;
            Players = players;
            LastUpdate = lastUpdate;
        }

        //Constructor without list of players
        public Roster(string teamName, DateTime lastUpdate) : this(teamName, lastUpdate, new List<Player>()) { }
        //Constructor without date and list of players
        public Roster(string teamName) : this(teamName, DateTime.Now, new List<Player>()) { }
        //No argument constructor
        public Roster() : this("", DateTime.Now, new List<Player>()) { }

    }
}
