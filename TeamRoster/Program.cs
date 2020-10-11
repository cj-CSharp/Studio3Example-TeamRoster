using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace TeamRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player sBird = new Player("Sue", "Bird", 10, "guard");
            Player jCanada = new Player("Jordin", "Canada", 21, "guard");
            Player aClark = new Player("Alysha", "Clark", 32, "forward");
            Player nHoward = new Player("Natasha", "Howard", 6, "forward");
            Player cLanghorne = new Player("Crystal", "Langhorne", 1, "forward");
            Player jLoyd = new Player("Jewell", "Loyd", 24, "guard");
            Player eMagbegor = new Player("Ezi", "Magbegor", 13, "center");
            Player ePrince = new Player("Epiphanny", "Prince", 11, "guard");
            Player mRussell = new Player("Mercedes", "Russell", 2, "center");
            Player bStewart = new Player("Breanna", "Stewart", 30, "forward");
            Player mTuck = new Player("Morgan", "Tuck", 3, "forward");
            Player sWhitcomb = new Player("Sami", "Whitcomb", 33, "guard");

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

            List<Player> playersWaitingForTeam = new List<Player>();

            

            
            int menuSelection = 200;
            while(menuSelection > 0)
            {
                string mainMenu = "\nPlease choose Menu Selection:\n1-View Rosters\n2-Edit Rosters\n0-Exit Application";
                Console.WriteLine(mainMenu);
                menuSelection = int.Parse(Console.ReadLine());
                switch (menuSelection)
                {
                    case 0://Exit program
                        break;

                    case 1: //view roster menu
                        Console.WriteLine(seattleStorm.ToString());
                        break;

                    case 2: //edit roster menu
                        int editMenuSelection = 100;
                        while(editMenuSelection > 0)
                        {
                            Console.WriteLine("Please choose edit menu selection: \n1-Create Player \n2-Add Player \n3-Remove Player \n0-Exit Edit Menu");
                            editMenuSelection = int.Parse(Console.ReadLine());
                            switch(editMenuSelection)
                            {
                                case 0: //Exit Edit Menu
                                    break;
                                case 1: //Create Player
                                    break;
                                case 2: //Add Player
                                    break;
                                case 3: //Remove Player
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input");
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
