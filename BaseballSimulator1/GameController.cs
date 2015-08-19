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
       public DataTable dtPlayerScores;
       public DataTable dtTeamScores;
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
           dtPlayerScores = new DataTable("PlayerScores");
           dtPlayerScores.Columns.Add("Name",System.Type.GetType("System.String"));
           dtPlayerScores.Columns.Add("AB", System.Type.GetType("System.Int32"));
           dtPlayerScores.Columns.Add("Hits", System.Type.GetType("System.Int32"));
           dtPlayerScores.Columns.Add("Walks", System.Type.GetType("System.Int32"));
           dtPlayerScores.Columns.Add("Avg", System.Type.GetType("System.Double"));
           dtTeamScores = new DataTable("TeamScores");
           dtTeamScores.Columns.Add("Name", System.Type.GetType("System.String"));
           dtTeamScores.Columns.Add("Inning", System.Type.GetType("System.String"));
           dtTeamScores.Columns.Add("Score", System.Type.GetType("System.Int32"));

       }

       public void PlayGame()
       { 
            
       
       }

       public void PlayHalfInning()

       {
           Team CurrentTeam;
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
                   //
               }
               if (AtBatResultNow == AtBat.AtBatResult.Walk)
               {
                   Batter.Walks++;
               }
           }
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

