using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballSimulator1
{
    public partial class Form1 : Form
    {

        public GameController GameCtl;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            //sim1.simMany();

            //AtBat bt = new AtBat();

            //SimpleBatter SimpleBatter = new SimpleBatter(0.35, 0.35);

            //AtBat.AtBatResult res = bt.SimulateAtBat(SimpleBatter, new GameState());
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please place Home.json and Away.json files in c:\\temp folder");
                GameCtl = new GameController();
                GameCtl.initializeGame();

                lstAwayTeam.DataSource = GameCtl.AwayTeam.TeamPlayers;
                lstAwayTeam.DisplayMember = "Name";
                
                lstHomeTeam.DataSource = GameCtl.HomeTeam.TeamPlayers;
                lstHomeTeam.DisplayMember = "Name";
            }

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnPlayHalf_Click(object sender, EventArgs e)
        {
            GameCtl.PlayHalfInning();
            txtInning.Text = GameCtl.TodayGame.inning.ToString();
            //update form dataview grids with the info and results from half inning
            dtHomeScores.DataSource = GameCtl.HomeTeam.TeamPlayers;
            dtAwayTeamScores.DataSource = GameCtl.AwayTeam.TeamPlayers;

            dtHomeScores.Update();
            dtHomeScores.Refresh();
            dtAwayTeamScores.Update();
            dtAwayTeamScores.Refresh();

        }

    }
}
