using Greed.Properties;
using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Greed
{
    public partial class GreedGame : Form
    {
        #region PUBLIC VARIABLES
        public static SpeechSynthesizer synth = new SpeechSynthesizer();  //enable speech synth
        /*
            round              each player rolls 10 times, starting at 1
            diff               difference between scores
            RollNum           number of dice rolls this turn
            FDA, FDB         first roll dice
            CDA, CDB         subsequent dice rolls
            FTotal, CTotal  first, and current roll dice totals  
            turn            keeps track of which player is rolling
            RoundScore      score for current round
            RNG             random number generator
            */
        public static int Round, Diff, RollNum, FDA, FDB, CDA, CDB, FTotal, CTotal, Turn, RoundScore;
        public static uint seed = (uint)Math.Pow(System.DateTime.Now.TimeOfDay.TotalMilliseconds, 11.0 / 7.0);
        public static Random RNG = new Random((int) seed);  //create random number generator
        public static System.Timers.Timer CPUDelay;  //delay between computer rolls

        struct PInfo  //stores player data
        {
            public string Name;  //player name
            public string PlayerType;  //human or computer
            public int Score;  //current score
        }

        PInfo[] PlayerData = new PInfo[2];  //a 2 element array of playerinfo
        #endregion

        private void GameLogRTB_TextChanged(object sender, EventArgs e)
        {
            GameLogRTB.SelectionStart = GameLogRTB.Text.Length;
            GameLogRTB.ScrollToCaret();  //scroll rich text box when new lines are added
        }  //game log text change

        public GreedGame()
        {
            InitializeComponent(); }
        
        void RollBTN_Click(object sender, EventArgs e)      //roll button
        {

        }

        void GreedGame_Load(object sender, EventArgs e)
        {
            PlayerData[0].Name = PlayerSettings.p1Name;  //populate with settings form info
            PlayerData[0].PlayerType = PlayerSettings.P1Type;
            PlayerData[1].Name = PlayerSettings.p2Name;
            PlayerData[1].PlayerType = PlayerSettings.P2Type;

        GameLoop();  //start main game
        }

        void StopBTN_Click(object sender, EventArgs e)  //stop button
        {

        }

        void WriteLog(string msg="")  //write to game log  default is blank line
        {
            GameLogRTB.AppendText (msg + "\n");  //write to rich text box, starting new line after each line

            if (PlayerSettings.SpeechToggle == true)  //if speech is on
            {
                synth.SpeakAsync(msg);  //speak logged lines
            }
        }
    
        void ScoreBlock ()  //print score data to log
        {
            WriteLog("Round " + Round + " of 10"); //wanna go 10 rounds? :)
            WriteLog(PlayerData[0].Name + ": " + PlayerData[0].Score + ", " +  //write names and scores
                PlayerData[1].Name + ": " + PlayerData[1].Score);
        
        if (PlayerData[0].Score > PlayerData[1].Score )  //determine who is leading
            {
                Diff = PlayerData[0].Score - PlayerData[1].Score;  //p1>p2
                WriteLog(PlayerData[0].Name + " up by " + Diff);
            }
        else if (PlayerData[1].Score > PlayerData[0].Score )  //p2>p1
            {
                Diff = PlayerData[1].Score - PlayerData[0].Score;
                WriteLog(PlayerData[1].Name + " up by " + Diff);
            }
            else 
            {
                WriteLog("Tie Game!");  //tie game
            }
        }

        void HumanRoll()  //takes inputs for a human player
        {

      }

    void ComputerRoll ()  //performs computer rolls
        {
            FDA = RNG.Next(1, 7);
            FDB = RNG.Next(1, 7);  //roll first 2 dice
            FTotal = FDA + FDB;  //first roll total
            RoundScore = FTotal;  //each successful dice roll total adds to score including first
            

        WriteLog("Roll 1: " + FDA + " & " + FDB + " - Total " + FTotal);

            for (RollNum = 2; RollNum <= FTotal; RollNum++)
            {
                CDA = RNG.Next(1, 7);
                CDB = RNG.Next(1, 7);
                CTotal = CDA + CDB;
                WriteLog("Roll " + RollNum + ":  " + CDA + " & " + CDB + " - Total " + CTotal);
                

                if (CTotal == FTotal)  //if first roll = other dice roll, turn over
                {
                    WriteLog("BUSTED!  No points scored.");
                    CurScoreNUD.Value = 0;
                    return;  //end function immediately
                }
                else 
                {
                    RoundScore += CTotal;  //each successful dice roll total adds to score including first
                    CurScoreNUD.Value= RoundScore;  //display current score in numeric control
                }  //end if
                
            }  //end for
            PlayerData[Turn].Score += RoundScore;
            WriteLog(PlayerData[Turn].Name + " scored " + RoundScore + " points.");
        }

        void GameLoop()  //main game loop
        {
            for (Round = 1; Round < 11; Round++)  //each player gets 10 turns
            {
                Turn = 0;   //first player up  (get the zero turn John Deer mower)
                ScoreBlock();  //display scores
                WriteLog();  //blank line
                WriteLog(PlayerData[0].Name + "'s Turn");

                //run the appropriate function for human or computer input
                if (PlayerData[0].PlayerType == "Computer")
                {
                    ComputerRoll();  //first player is a computer  (KITT, HAL9000)
                }
                else
                {
                    HumanRoll(); //first player is human
                }

                Turn = 1;  //second player
                WriteLog();
                WriteLog(PlayerData[1].Name + "'s Turn");
                
                if (PlayerData[1].PlayerType == "Computer")
                {
                    ComputerRoll();  //Second player is a computer  (ENIAC, Apple IIe Platinum)
                }
                else
                {
                    HumanRoll(); //second player is human
                }

                WriteLog();
                WriteLog("----- End of Round " + Round + " -----");
                WriteLog();
            }
            EndGame();
        }

        void EndGame() //end ofgame tasks
        {
            WriteLog("FINAL SCORES:");
            WriteLog();
            
            WriteLog(PlayerData[0].Name + ": " + PlayerData[0].Score + ", " +  //write names and scores
                PlayerData[1].Name + ": " + PlayerData[1].Score);

            if (PlayerData[0].Score > PlayerData[1].Score)  //determine who is leading
            {
                Diff = PlayerData[0].Score - PlayerData[1].Score;  //p1>p2
                WriteLog(PlayerData[0].Name + " won by " + Diff + " points.");
            }
            else if (PlayerData[1].Score > PlayerData[0].Score)  //p2>p1
            {
                Diff = PlayerData[1].Score - PlayerData[0].Score;
                WriteLog(PlayerData[1].Name + " won by " + Diff + " points.");
            }
            else
            {
                WriteLog("Tie Game!");  //tie game
            }
        }

    } //end class
}  //end namespace 