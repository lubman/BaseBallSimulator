using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BaseballSimulator1
{


   public class GameController
    {
       //public DataTable dtPlayerScores;
       //public DataTable dtTeamScores;
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



       public void initializeGame(String HomeTeamName, String AwayTeamName)
       {

           TodayGame = new Game();
                      
           HomeTeam =  TodayGame.PopulateTeam(Team.TeamType.Home);
           HomeTeam.Name = HomeTeamName;
           AwayTeam = TodayGame.PopulateTeam(Team.TeamType.Away);
           AwayTeam.Name = AwayTeamName;
           
           //assign teams to the game reference pointers
           TodayGame.HomeTeam = HomeTeam;
           TodayGame.AwayTeam = AwayTeam;
       }

       public void PlayGame()
       { 
            
       
       }

       public void PlayHalfInning()

       {
           Team CurrentTeam;
           int Outs = 0;
           //check if it is top or the bottom of the inning
           //for simplicity sake batting order will be done in the sequential order

           if (TodayGame.inning.ToString().Substring(TodayGame.inning.ToString().Length - 1) == "5")
           {
               CurrentTeam = AwayTeam;
           }
           else
           {
               CurrentTeam = HomeTeam;
           }

           foreach (Player Batter in CurrentTeam.TeamPlayers)
           {
               //get truly random value               
               Random rnd = new Random(Guid.NewGuid().GetHashCode());
               double ballpct = rnd.NextDouble();
               double ballStruckPct = rnd.NextDouble();
               SimpleBatter SB = new SimpleBatter(ballpct, ballStruckPct);

               AtBat AtBatNow = new AtBat();

               AtBat.AtBatResult AtBatResultNow = AtBatNow.SimulateAtBat(SB);
               Batter.AtBat++;
               
               if (AtBatResultNow == AtBat.AtBatResult.Hit)
               {
               Batter.Hits++;
               }
               if (AtBatResultNow == AtBat.AtBatResult.Out)
               {
                   Outs++;
                   if (Outs == 3)
                    {break;}     
                   // three times and you're team is out of the Inning
               }
               if (AtBatResultNow == AtBat.AtBatResult.Walk)
               {
                   Batter.Walks++;
               }
               Batter.BattingAVG = (double)Batter.Hits/(double)Batter.AtBat;
           }
           //calculate running Batting Average
           
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

