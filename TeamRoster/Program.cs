using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace TeamRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player sBird = new Player("Sue", "Bird", 10);
            Player jCanada = new Player("Jordin", "Canada", 21);
            Player aClark = new Player("Alysha", "Clark", 32);
            Player nHoward = new Player("Natasha", "Howard", 6);
            Player cLanghorne = new Player("Crystal", "Langhorne", 1);
            Player jLoyd = new Player("Jewell", "Loyd", 24);
            Player eMagbegor = new Player("Ezi", "Magbegor", 13);
            Player ePrince = new Player("Epiphanny", "Prince", 11);
            Player mRussell = new Player("Mercedes", "Russell", 2);
            Player bStewart = new Player("Breanna", "Stewart", 30);
            Player mTuck = new Player("Morgan", "Tuck", 3);
            Player sWhitcomb = new Player("Sami", "Whitcomb", 33);

            Roster seattleStorm = new Roster("Seattle Storm", new DateTime(2020, 06, 30));

            seattleStorm.Players.Add(sBird);
            seattleStorm.Players.Add(jCanada);
            seattleStorm.Players.Add(aClark);
            seattleStorm.Players.Add(nHoward);
            seattleStorm.Players.Add(cLanghorne);
            seattleStorm.Players.Add(jLoyd);
            seattleStorm.Players.Add(eMagbegor);
            seattleStorm.Players.Add(ePrince);
            seattleStorm.Players.Add(mRussell);
            seattleStorm.Players.Add(bStewart);
            seattleStorm.Players.Add(mTuck);
            seattleStorm.Players.Add(sWhitcomb);

            Console.WriteLine(seattleStorm);

            List<Roster> league = new List<Roster> { seattleStorm };
            List<Player> playersWaitingForTeam = new List<Player>();

            

            
            int menuSelection = 200;
            while(menuSelection > 0)
            {
                string mainMenu = "\nPlease choose Menu Selection:\n1-View Rosters\n2-Edit Rosters\n0-Exit Application";
                Console.WriteLine(mainMenu);
                menuSelection = int.Parse(Console.ReadLine());
                switch (menuSelection)
                {
                    case 0:
                        break;
                    case 1: //view roster menu
                        
                        StringBuilder listOfTeamsForSelection = new StringBuilder();
                        for (int i = 0; i < league.Count; i++)
                        {
                            listOfTeamsForSelection.Append($"\n{i + 2}-{league[i].TeamName}");
                        }

                        string viewRostersMenuHeading = "\nPlease choose number regarding menu option: \n1-All";
                        string viewRosterMenu = viewRostersMenuHeading + listOfTeamsForSelection.ToString() + "\n0-Exit Menu";
                        
                        int teamSelection = 100;
                        while (teamSelection > 0)
                        {
                            Console.WriteLine(viewRosterMenu);
                            teamSelection = int.Parse(Console.ReadLine());

                            switch (teamSelection)
                            {
                                case 0: //back
                                    break;
                                case 1: //view all team rosters
                                    foreach (Roster team in league)
                                    {
                                        Console.WriteLine(team);
                                    }
                                    break;
                                default: //valid or invalid selection
                                    if (teamSelection - 2 > league.Count - 1) //invalid selection
                                    {
                                        Console.WriteLine("\nInvalid Selection");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n" + league[teamSelection - 2].ToString() + "\n\n");
                                    }
                                    break;
                            }
                        }
                        break;
                    case 2: //edit roster menu
                        int rosterMenuSelection = 200;
                        while (rosterMenuSelection > 0)
                        {
                            Console.WriteLine("Please choose menu selection:\n1-Add Player\n2-Remove Player\n3-Create Player\n4-Edit Player\n0-Exit Menu");
                            rosterMenuSelection = int.Parse(Console.ReadLine());
                            switch (rosterMenuSelection)
                            {
                                case 0: //back
                                    break;
                                case 1: //add player to roster
                                    int addPlayerSelection = 200;
                                    while (addPlayerSelection > 0)
                                    {
                                        Console.WriteLine("Please choose select player by number (not jersey number):");
                                        for(int i = 0; i < playersWaitingForTeam.Count; i++)
                                        {
                                            Console.WriteLine((i+1) + " - " + playersWaitingForTeam[i].ToString());
                                        }
                                        Console.WriteLine("0 - Exit Add Player");
                                        addPlayerSelection  = int.Parse(Console.ReadLine());
                                        if(addPlayerSelection <= 0)
                                        {
                                            break;
                                        }
                                        else if(addPlayerSelection > playersWaitingForTeam.Count)
                                        {
                                            Console.WriteLine("Invalid Selection");
                                        } else
                                        {
                                            Player playerSelected = playersWaitingForTeam[addPlayerSelection - 1];
                                            int selectedTeamNum = 200;
                                            
                                            while(selectedTeamNum > 0)
                                            {
                                                Console.WriteLine(playerSelected + "\nPlease choose team by number:");
                                                for(int i = 0; i < league.Count; i++)
                                                {
                                                    Console.WriteLine((i + 1) + $"-{league[i].TeamName}");
                                                }
                                                Console.WriteLine("0-Exit Menu");
                                                selectedTeamNum = int.Parse(Console.ReadLine());
                                                if(selectedTeamNum < 0)
                                                {
                                                    break;
                                                }
                                                else if(selectedTeamNum > league.Count)
                                                {
                                                    Console.WriteLine("Invalid Selection");
                                                } else
                                                {
                                                    bool playerAdded = league[selectedTeamNum - 1].AddPlayer(playerSelected);
                                                    if(playerAdded)
                                                    {
                                                        playersWaitingForTeam.Remove(playerSelected);
                                                        Console.WriteLine("Player added to " + league[selectedTeamNum - 1].TeamName);
                                                        break;
                                                    } else
                                                    {
                                                        Console.WriteLine("Player could not be added.");
                                                        break;
                                                    }
                                                }
                                            }
                                            
                                        }

                                    }
                                    break;
                                case 2: //remove player from roster
                                    Console.WriteLine("Not implemented yet");
                                    break;
                                case 3: //Create Player
                                    Console.WriteLine("Enter Player's First Name:");
                                    string newFirstName = Console.ReadLine();
                                    Console.WriteLine("Enter Player's Last Name:");
                                    string newLastName = Console.ReadLine();
                                    Console.WriteLine("Enter Player's Jersey Number");
                                    int newJerseyNumber = int.Parse(Console.ReadLine());
                                    Player newPlayer = new Player(newFirstName, newLastName, newJerseyNumber);
                                    playersWaitingForTeam.Add(newPlayer);
                                    Console.WriteLine("Player has been created");
                                    break;
                                case 4: //Edit Player
                                    Console.WriteLine("Not implemented yet");
                                    break;
                                default:
                                    Console.WriteLine("Invalid Selection");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }  
        }
    }
}
