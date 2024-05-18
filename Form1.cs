using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public class PlayerInfo
        {
            public string Name;
            public byte Score;
            public Image PlayerImage;
            public checks mychecks;
            public  class checks
            {
                public bool chk1 = false;
                public bool chk2 = false;
                public bool chk3 = false;
                public bool chk4 = false;
                public bool chk5 = false;
                public bool chk6 = false;
                public bool chk7 = false;
                public bool chk8 = false;
                public bool chk9 = false;
                    
            }

            
            public PlayerInfo(string name, byte score, Image playerImage)
            {
                Name = name;
                Score = score;
                PlayerImage = playerImage;
                mychecks = new checks();
            }
        }

        PlayerInfo player1 = new PlayerInfo("Player 1", 0, Properties.Resources.x);
        PlayerInfo player2 = new PlayerInfo("Player 2", 0, Properties.Resources.o);
        PlayerInfo ActivePlayer = new PlayerInfo("", 0, Properties.Resources.questionmark);

        private void Form1_Load(object sender, EventArgs e)
        {
            ActivePlayer = getActivePlayer();
            displayActivePlayerName(ActivePlayer);

        }


        void reset()
        {
            lbactiveplayer.Tag = "Player 1";
            ActivePlayer = getActivePlayer();
            displayActivePlayerName(ActivePlayer);
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
            pb9.Enabled = true;
            pb1.Image = Resources.questionmark;
            pb2.Image = Resources.questionmark;
            pb3.Image = Resources.questionmark;
            pb4.Image = Resources.questionmark;
            pb5.Image = Resources.questionmark;
            pb6.Image = Resources.questionmark;
            pb7.Image = Resources.questionmark;
            pb8.Image = Resources.questionmark;
            pb9.Image = Resources.questionmark;

            player1.mychecks.chk1 = false;
            player1.mychecks.chk2 = false;
            player1.mychecks.chk3 = false;
            player1.mychecks.chk4 = false;
            player1.mychecks.chk5 = false;
            player1.mychecks.chk6 = false;
            player1.mychecks.chk7 = false;
            player1.mychecks.chk8 = false;
            player1.mychecks.chk9 = false;

            player2.mychecks.chk1 = false;
            player2.mychecks.chk2 = false;
            player2.mychecks.chk3 = false;
            player2.mychecks.chk4 = false;
            player2.mychecks.chk5 = false;
            player2.mychecks.chk6 = false;
            player2.mychecks.chk7 = false;
            player2.mychecks.chk8 = false;
            player2.mychecks.chk9 = false;

            groupBox2.Visible = Enabled;


        }

        void endGame()
        {
            groupBox2.Visible = false;
        }


        void displayActivePlayerName(PlayerInfo ActivePlayer)
        {
            lbactiveplayer.Text = ActivePlayer.Name;
        }


        void displayPlayersScore()
        {   

            lbscorep1.Text = player1.Score.ToString();
        
            lbscorep2.Text = player2.Score.ToString();
            
            
        }


        void displayActivePlayerPlayingImage(PlayerInfo ActivePlayer, PictureBox pbox)
        {

            pbox.Image = ActivePlayer.PlayerImage;

        }


        PlayerInfo getActivePlayer()
        {
            if (lbactiveplayer.Tag.ToString() == "Player 1")
            {
                return player1;
            }
            else
            {
                return player2;
            }
        }


        void switchActivePlayer()
        {

            if(lbactiveplayer.Tag.ToString() == "Player 1")
            {
                lbactiveplayer.Tag = "Player 2";
                ActivePlayer = player2;
            }

            else
            {
                lbactiveplayer.Tag = "Player 1";
                ActivePlayer = player1;
            }

        }


        void play(PictureBox pbbox)
        {
            
            displayPlayersScore();
            displayActivePlayerPlayingImage(ActivePlayer, pbbox);
            pbbox.Enabled = false;
            switchActivePlayer();
            displayActivePlayerName(ActivePlayer);



        }


        bool draw()
        {
            if(pb1.Enabled == false && pb2.Enabled == false && pb3.Enabled == false &&
                pb4.Enabled == false && pb5.Enabled == false && pb6.Enabled == false &&
                pb7.Enabled == false && pb8.Enabled == false && pb9.Enabled == false) {

                return true;  
            }

            return false;
        }

        bool decideWinner()
        {
            if(ActivePlayer.mychecks.chk1 == true && ActivePlayer.mychecks.chk2 == true 
                && ActivePlayer.mychecks.chk3 == true) {

                ActivePlayer.Score++;
               
                MessageBox.Show( ActivePlayer.Name + " wins", "Winner", MessageBoxButtons.OK);

                endGame();
          
                return true;              
            }

            if (ActivePlayer.mychecks.chk4 == true && ActivePlayer.mychecks.chk5 == true
                && ActivePlayer.mychecks.chk6 == true)
            {

                ActivePlayer.Score++;
                MessageBox.Show(ActivePlayer.Name + " wins", "Winner", MessageBoxButtons.OK);
                endGame();
                return true;
            }

            if (ActivePlayer.mychecks.chk7 == true && ActivePlayer.mychecks.chk8 == true
                && ActivePlayer.mychecks.chk9 == true)
            {

                ActivePlayer.Score++;
                MessageBox.Show(ActivePlayer.Name + " wins", "Winner", MessageBoxButtons.OK);
                endGame();
                return true;
            }

            if (ActivePlayer.mychecks.chk1 == true && ActivePlayer.mychecks.chk4 == true
                && ActivePlayer.mychecks.chk7 == true)
            {

                ActivePlayer.Score++;
                MessageBox.Show(ActivePlayer.Name + " wins", "Winner", MessageBoxButtons.OK);
                endGame();
                return true;
            }

            if (ActivePlayer.mychecks.chk2 == true && ActivePlayer.mychecks.chk5 == true
                && ActivePlayer.mychecks.chk8 == true)
            {

                ActivePlayer.Score++;
                MessageBox.Show(ActivePlayer.Name + " wins", "Winner", MessageBoxButtons.OK);
                endGame();
                return true;
            }

            if (ActivePlayer.mychecks.chk3 == true && ActivePlayer.mychecks.chk6 == true
                && ActivePlayer.mychecks.chk9 == true)
            {

                ActivePlayer.Score++;
                MessageBox.Show(ActivePlayer.Name + " wins", "Winner", MessageBoxButtons.OK);
                endGame();
                return true;
            }

            if (ActivePlayer.mychecks.chk1 == true && ActivePlayer.mychecks.chk5 == true
                && ActivePlayer.mychecks.chk9 == true)
            {

                ActivePlayer.Score++;
                MessageBox.Show(ActivePlayer.Name + " wins", "Winner", MessageBoxButtons.OK);
                endGame();
                return true;
            }

            if (ActivePlayer.mychecks.chk3 == true && ActivePlayer.mychecks.chk5 == true
                && ActivePlayer.mychecks.chk7 == true)
            {

                ActivePlayer.Score++;
                MessageBox.Show(ActivePlayer.Name + " wins", "Winner", MessageBoxButtons.OK);
                endGame();
                return true;
            }

            return false;
        }


        private void pb1_Click(object sender, EventArgs e)
        {
            
            ActivePlayer.mychecks.chk1 = true;
            decideWinner();
            play(pb1);

            if (draw())
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
            }

        }

        private void pb2_Click(object sender, EventArgs e)
        {
            ActivePlayer.mychecks.chk2 = true;
            decideWinner();
            play(pb2);
            if (draw())
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
            }

        }

        private void pb3_Click(object sender, EventArgs e)
        {
            ActivePlayer.mychecks.chk3 = true;
            decideWinner();
            play(pb3);
            if (draw())
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
            }

        }

        private void pb4_Click(object sender, EventArgs e)
        {
            ActivePlayer.mychecks.chk4 = true;
            decideWinner();
            play(pb4);
            if (draw())
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
            }

        }

        private void pb5_Click(object sender, EventArgs e)
        {
            ActivePlayer.mychecks.chk5 = true;
            decideWinner();
            play(pb5);
            if (draw())
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
            }

        }

        private void pb6_Click(object sender, EventArgs e)
        {
            ActivePlayer.mychecks.chk6 = true;
            decideWinner();
            play(pb6);
            if (draw())
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
            }

        }

        private void pb7_Click(object sender, EventArgs e)
        {
            ActivePlayer.mychecks.chk7 = true;
            decideWinner();
            play(pb7);
            if (draw())
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
            }


        }

        private void pb8_Click(object sender, EventArgs e)
        {
            ActivePlayer.mychecks.chk8 = true;
            decideWinner();
            play(pb8);
            if (draw())
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
            }

        }

        private void pb9_Click(object sender, EventArgs e)
        {
            ActivePlayer.mychecks.chk9 = true;
            decideWinner();
            play(pb9);
            if (draw())
            {
                MessageBox.Show("Draw", "Winner", MessageBoxButtons.OK);
            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }



        //--------------------------------------------------------------------------------------









        //--------------------------------------------------------------------------------------
    }
}
