using System;
using System.Collections.Generic;
using System.Text;

namespace TeamRoster
{
    class Player
    {
        //private properties, not using  shortcut to create getters and setters because we have a custom setter
        private string firstName;
        private string lastName;
        private int jerseyNumber;

        //Constructor
        public Player(string firstName, string lastName, int jerseyNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.jerseyNumber = jerseyNumber;
        }

        //constructor in case jersey number hasn't been assigned
        public Player(string firstName, string lastName) : this(firstName, lastName, 100) { } 

        //No argument constructor
        public Player() : this("", "", 100) { } 

        //getters and setters
        public string FirstName
        {
            get { return firstName; }
            set //custom setter
            {
                if(value.Length >= 2)
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
                if(value.Length > 0)
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
                if(value >= 0 )
                {
                    jerseyNumber = value;
                }
            }
        }



    }
}
