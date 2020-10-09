using System;
using System.Collections.Generic;
using System.Text;

namespace TeamRoster
{
    class Player
    {
        private string firstName;
        private string lastName;
        private int jerseyNumber;
        public bool HasTeam { get; set; }

        public Player(string firstName, string lastName, int jerseyNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.jerseyNumber = jerseyNumber;
            HasTeam = false;
        }


        public Player(string firstName, string lastName) : this(firstName, lastName, 100) { }


        public Player() : this("", "", 100) { }


        public string FirstName
        {
            get { return firstName; }
            set //custom setter
            {
                if (value.Length >= 2)
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set //custom setter
            {
                if (value.Length > 0)
                {
                    lastName = value;
                }
            }
        }

        public int JerseyNumber
        {
            get { return jerseyNumber; }
            set //custom setter
            {
                if (value >= 0)
                {
                    jerseyNumber = value;
                }
            }
        }

        //Override on ToString()
        public override string ToString()
        {
            return $"{this.jerseyNumber} - {this.LastName}, {this.FirstName}";
        }

    }
}
