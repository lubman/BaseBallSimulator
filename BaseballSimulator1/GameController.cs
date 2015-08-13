using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballSimulator1
{


   public class GameController
    {

       public Game TodayGame;
       public Team HomeTeam;
       public Team AwayTeam;

       public void simMany()
       {
           using (System.IO.StreamWriter sw = new System.IO.StreamWriter("c:\\temp\\obp.csv", true))
           {
               double ballPct = 0.3;
               double ballStruckPct = 0.1;

               double obp = this.simulateOBP(ballPct, ballStruckPct, 10000);
               sw.WriteLine(ballPct + "," + ballStruckPct + "," + obp);
           }
       }



       public void initializeGame()
       {

           TodayGame = new Game();
                      
           HomeTeam =  TodayGame.PopulateTeam(Team.TeamType.Home);
           AwayTeam = TodayGame.PopulateTeam(Team.TeamType.Away);
           TodayGame.HomeTeam = HomeTeam;
           TodayGame.AwayTeam = AwayTeam;
       }

       public void PlayGame()
       { 
            
       
       }

       public void PlayHalfInning()

       {
           
           
           
           
           TodayGame.inning = TodayGame.inning + 0.5; 
           
       
       }
             
       public double simulateOBP(double ballPct, double ballStruckPct, int nmSims)
       {

           int nmWalks = 0;
           int nmHits = 0;
           int nmOuts = 0;

           for (int i = 0; i < nmSims; i++)
           {

               AtBat bt = new AtBat();

               //SimpleBatter SimpleBatter = new SimpleBatter(0.35, 0.35);
               SimpleBatter SimpleBatter = new SimpleBatter(ballPct,ballStruckPct);

               AtBat.AtBatResult res = bt.SimulateAtBat(SimpleBatter);
               if (res == AtBat.AtBatResult.Hit)
               {
                   nmHits++;
               }
               if (res == AtBat.AtBatResult.Walk)
               {
                   nmWalks++;
               }
               if (res == AtBat.AtBatResult.Out)
               {
                   nmOuts++;
               }
           }

           double obp=((double)(nmHits+nmWalks))/((double)nmSims);
           return obp;
       }
    }



   }

