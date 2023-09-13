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
        PictureBox[] aliens;
        int alienSpeed;


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
            MoveAliens(aliens, alienSpeed);
        }


        private void initalizeGame()
        {
            this.player = new Player(100);
            this.player.Location = playerBox.Location;
        }

        private void Load_aliens()
        {
            alienSpeed = 4;

            //allow for the alien images to load from the image folder
            Image alien1 = Image.FromFile("..\\images\\alien1.png");
            Image alien2 = Image.FromFile("..\\images\\alien2.png");
            Image alien3 = Image.FromFile("..\\images\\alien3.png");
            Image alien4 = Image.FromFile("..\\images\\alien4.png");

            //create arrary for 10 picture boxes 
            aliens = new PictureBox[14];

            //Initialize the alien picture box
            for (int i = 0; i < aliens.Length; i++)
            {
                aliens[i] = new PictureBox();
                aliens[i].Size = new Size(40, 40);
                aliens[i].SizeMode = PictureBoxSizeMode.Zoom;
                aliens[i].BorderStyle = BorderStyle.None;
                aliens[i].Visible = false; // ensure that the aliens doesn't show up on the start screen
                this.Controls.Add(aliens[i]);
                aliens[i].Location = new Point((i + 1) * 50, -50); //arrange the aliens on the screen
            }

            aliens[0].Image = alien1;
            aliens[1].Image = alien2;
            aliens[2].Image = alien3;
            aliens[3].Image = alien4;
            aliens[4].Image = alien2;
            aliens[5].Image = alien3;
            aliens[6].Image = alien3;
            aliens[7].Image = alien2;
            aliens[8].Image = alien4;
            aliens[9].Image = alien1;
            aliens[10].Image = alien4;
            aliens[11].Image = alien2;
            aliens[12].Image = alien3;
            aliens[13].Image = alien1;

        }
        private void moveAliensTimer1_Tick(object sender, EventArgs e)
        {
            MoveAliens(aliens, alienSpeed);
        }

        // access the alien array and display aliens moving from top to bottom
        private void MoveAliens(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }


            }
        }

    }
}
