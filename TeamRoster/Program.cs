using System;
using System.Collections.Generic;
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

            Roster seattleStorm = new Roster("Seattle Storm", DateTime.Now);

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

            

            string mainMenu = "Please choose Menu Selection:\n1-View Rosters\n2-Edit Rosters\n0-Exit";
            string viewRostersMenu = "Please choose number regarding menu option: \n1-All";
            int menuSelection = int.Parse(Console.ReadLine());
            while(menuSelection > 0)
            {
                Console.WriteLine(mainMenu);
                
                if(menuSelection == 1)
                {
                    StringBuilder listOfTeamsForSelection = new StringBuilder();
                    for (int i = 0; i < league.Count; i++)
                    {
                        listOfTeamsForSelection.Append($"\n{i + 2}-{league[i].TeamName}");
                    }
                    Console.WriteLine(viewRostersMenu + listOfTeamsForSelection.ToString());
                    int teamSelection = int.Parse(Console.ReadLine());
                    if(teamSelection == 1)
                    {
                        foreach(Roster team in league)
                        {
                            Console.WriteLine("\n**********\n" + team + "\n**********\n");
                        }
                    }

                }
            }

            

            
        }
    }
}
