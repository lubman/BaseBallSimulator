using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace BaseballSimulator1
{

    public enum FieldingPosition {Pitcher=1,Catcher=2,FirstBase=3,SecondBase=4,ThirdBase=5,ShortStop=6,LeftField=7,CenterField=8,RightField=9,DesignatedHitter=10,PinchHitter=11,PinchRuner=12};

    
    public class Player
    {
        /* 	batting stats */
        public double G, PA, AB, Run, bHit, singles, doubles, triples, HR, RBI, BB, SO, SB, CS, GDP, HBP;
        public double speedScore, singleAVG, doubleAVG, tripleAVG, HRAVG, BBAVG, SOAVG, HBPAVG;

        /* 	piching stats (if applicaple) */
        public double W, L, BF, IP, pHit, pHR, pBB, pSO, SAV, pG, GS, pHBP;
        public double pSingleAVG, pDoubleAVG, pTripleAVG, pHRAVG, pBBAVG, pSOAVG, pHBPAVG;

        /* 	fielding stats */
        public double PO, ASS, ERR;
        public double fldPCT;

        /* 	game stats */
        public double ab, r, hit, rbi, e, ip, h, er, bb, so, hbp, to, pitchCount;

        public String Name { get; set; }
        public int Hits { get; set; }
        public int Walks { get; set; }
        public int AtBat { get; set; }
        public double BattingAVG { get; set; }
        public double OBP { get; set; }
        public FieldingPosition FieldingPositionNow {get;set;}       
        public int HittingPositionNow {get;set;}
       
        

    
        public void clearGameStats()
        {
            pitchCount = ab = r = hit = rbi = e = ip = h = er = bb = hbp = to = so = 0;
        }
        public String toString()
        {
            return Name.ToString() + " (" + FieldingPositionNow.ToString() + ")";
        } 
                        
    }

    public class Team
    {
        public enum TeamType { Home, Away };
        public  TeamType TypeOfTeam;
        public List<Player> TeamPlayers {get; set;}

        public String name;
        public int year;
                
        Player[] currentOrder=new Player[10];
        Player[] currentFielders = new Player[12];
                
        public void StartPlayer(Player player,int battingPosition, FieldingPosition position){

            player.HittingPositionNow = battingPosition;
            player.FieldingPositionNow = position;
            currentFielders[(int)position] = player;
            currentOrder[(int)battingPosition - 1] = player;
        }



        public void SubPlayer(Player player, int battingPosition , FieldingPosition position)
        {
            Player replaced = currentOrder[battingPosition];

            player.HittingPositionNow = battingPosition;
            player.FieldingPositionNow = position;
            currentFielders[(int)position - 1] = player;
            currentOrder[(int)battingPosition - 1] = player;
        }
        
    }
  
  



  public class Game
    {
      public Team HomeTeam;
      public Team AwayTeam;

      public Player[] homeOrder, awayOrder, homeField, awayField;
      public Player homeP, awayP;
      public int outsBefore, hRuns, aRuns, hSpot, aSpot, outs, strikes, balls;
      public double inning;

      //constructor
      public Game()
      {
          inning = 1;
          outs = 0;
          strikes = 0;
          balls = 0;

      }

      public Team PopulateTeam (Team.TeamType cType) 
      {
          //read roster from JSON file and populate team objects with players
          try
          {
              Team iTeam = new Team();
              iTeam.TypeOfTeam = cType;
              StreamReader Reader = new StreamReader("c:\\temp\\" + cType.ToString() + ".json");
              string json = Reader.ReadToEnd();              
              List<String> PlayersList = JsonConvert.DeserializeObject<List<String>>(json);
              iTeam.TeamPlayers = new List<Player>();
              
              FieldingPosition fp = FieldingPosition.Pitcher;
              foreach (String PlayerName in PlayersList)
              {

                  Player Pl = new Player();
                  Pl.Name = PlayerName.ToString();
                  Pl.FieldingPositionNow = fp;
                  iTeam.TeamPlayers.Add(Pl);
                  fp++;
              }
              return iTeam;
          }
          catch (Exception e)
          {
              Console.WriteLine(e.Message);
              return null;
          }
            
                              
      }

      public class GameId
      {
          public enum GameInDay { Only=0, FirstInDoubleHeader=1, SecondInDoubleHeader=2 };
          
          String homeTeam;
          DateTime dt;
          GameInDay gameInDay;
          public GameId(String idStr){
              if (idStr.StartsWith("id,")){
                  idStr=idStr.Substring(3);
              }

              homeTeam = idStr.Substring(0, 3);
              dt = new DateTime(int.Parse(idStr.Substring(3, 4)), int.Parse(idStr.Substring(7, 2)), int.Parse(idStr.Substring(9, 2)));

              gameInDay=(GameInDay) int.Parse(idStr.Substring(11, 1));
          
          }
          
      }

      public class GameInfo
      {
          Dictionary<String, String> _infoDB = new Dictionary<string, string>();

          public void AddInfoField(String key, String val)
          {
              if (!_infoDB.ContainsKey(key))
              {
                  _infoDB.Add(key, val);
              }
              else
              {
                  _infoDB[key] = val;
              }
          }

      }





    }


    
}
