using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public partial class Game
    {
        //PROPERTIES
        Player player;
        //Round currentRound;
        bool initializeRound;

        //CONSTRUCTORS
        //public Game()
        //{
        //   this.InitializeRound = false;
        //}

        //GETTERS AND SETTERS
        public Player Player1 { get => player; set => player = value; }
        public bool InitializeRound { get => initializeRound; set => initializeRound = value; }

        //METHODS

        //Listening for which key is press
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.MoveLeft = true;
                player.MoveRight = false;
            }
            else if (e.KeyCode == Keys.Right) 
            { 
                player.MoveRight = true;
                player.MoveLeft = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.MoveLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                player.MoveRight = false;
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            player.move();
            this.playerBox.Location = player.Location;
        }


        private void initalizeGame()
        {
            this.player = new Player(100);
            this.player.Location = playerBox.Location;
        }

    }
}
