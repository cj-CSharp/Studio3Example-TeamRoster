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

            StringBuilder guards = new StringBuilder();
            StringBuilder forwards = new StringBuilder();
            StringBuilder centers = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (Player individual in Players)
            {
                if (individual.Position == "guard")
                {
                    guards.Append("\n" + individual.ToString());
                }
                else if (individual.Position == "forward")
                {
                    forwards.Append("\n" + individual.ToString());
                }
                else if (individual.Position == "center")
                {
                    centers.Append("\n" + individual.ToString());
                } 
                else
                {
                    others.Append("\n" + individual.ToString());
                }
            }

            result.Append("Guards" + guards.ToString() + "\n\nForwards" + forwards.ToString() + "\n\nCenters"+ centers.ToString());
            if(others.Length > 0)
            {
                result.Append("\n\nOthers" +others.ToString());
            }
            result.Append($"\nLast Updated: {LastUpdate}\n**********\n");
            return result.ToString();
        }

        public bool AddPlayer(Player playerToAdd)
        {
            if(Players.Contains(playerToAdd))
            {
                return false;
            }
            Players.Add(playerToAdd);
            LastUpdate = DateTime.Now;
            return true;
        }

        public bool RemovePlayer(Player playerToRemove)
        {
            if(Players.Contains(playerToRemove))
            {
                Players.Remove(playerToRemove);
                LastUpdate = DateTime.Now;
                return true;
            }
            return false;
        } 

    }
}
