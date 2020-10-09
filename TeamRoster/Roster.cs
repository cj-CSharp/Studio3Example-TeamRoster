using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeamRoster
{
    class Roster
    {
        //Properties
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

        public Roster(string teamName, DateTime lastUpdate) : this(teamName, lastUpdate, new List<Player>()) { }

        public Roster(string teamName) : this(teamName, DateTime.Now, new List<Player>()) { }

        public Roster() : this("", DateTime.Now, new List<Player>()) { }

        //Override on ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"\n**********\n{TeamName} Roster\nNumber of Players: {Players.Count}\n\n");
            foreach(Player individual in Players)
            {
                result.Append(individual.ToString() + "\n");
            }
            result.Append($"\nLast Updated: {LastUpdate}\n**********\n");
            return result.ToString();
        }

        public bool AddPlayer(Player playerToAdd)
        {
            if(playerToAdd.HasTeam)
            {
                return false;
            }
            Players.Add(playerToAdd);
            playerToAdd.HasTeam = true ;
            LastUpdate = DateTime.Now;
            return true;
        }

        public bool RemovePlayer(Player playerToRemove)
        {
            if(Players.Contains(playerToRemove))
            {
                Players.Remove(playerToRemove);
                playerToRemove.HasTeam = false;
                LastUpdate = DateTime.Now;
                return true;
            }
            return false;
        } 

    }
}
