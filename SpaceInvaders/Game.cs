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
        Alien[] aliens;
        int alienSpeed;
        //int frameCount;


        //CONSTRUCTORS
        //public Game()
        //{
        //   this.InitializeRound = false;
        //}

        //GETTERS AND SETTERS
        public Player Player1 { get => player; set => player = value; }
        public bool InitializeRound { get => initializeRound; set => initializeRound = value; }


        //METHODS

        /// <summary>
        ///  Listening for which key is press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.player.SpriteBox.Location = player.Location;
            MoveAliens(aliens, alienSpeed);
            this.player.fireBullet();
            this.scoreLabel.Text = "SCORE: " + this.player.Score;
        }


        private void initalizeGame()
        {
            this.BackColor = Color.FromArgb(19, 35, 86); //
            this.player = new Player(100);
            this.player.Location = player.SpriteBox.Location;
            this.player.Bullet.Render(this);
            Controls.Add(player.SpriteBox);
        }

        public void Load_aliens()
        {
            alienSpeed = 4;

            //allow for the alien images to load from the image folder
            Image[] images = new Image[4];
            for(int i = 0; i <4; i++)
            {
                images[i] = Image.FromFile("..\\images\\alien"+(i+1)+".png");
            }


            //create arrary for 10 picture boxes 
            aliens = new Alien[14];

            //Initialize the alien picture box
            for (int i = 0; i < aliens.Length; i++)
            {
                aliens[i] = new Alien();
                aliens[i].initSprite();
                //aliens[i].Visible = false; // ensure that the aliens doesn't show up on the start screen
                this.Controls.Add(aliens[i].SpriteBox);
                aliens[i].SpriteBox.Location = new Point((i + 1) * 60, -60); //arrange the aliens on the screen
                aliens[i].SpriteBox.Image = images[3];
            }

        }

        //private void moveAliensTimer1_Tick(object sender, EventArgs e)
        //{
        //    MoveAliens(aliens, alienSpeed);
        //}

        // access the alien array and display aliens moving from top to bottom
        public void MoveAliens(Alien[] aliens, int speed)
        {
            
            for (int i = 0; i < aliens.Length; i++)
            {
                if (this.player.Bullet.SpriteBox.Bounds.IntersectsWith(aliens[i].SpriteBox.Bounds))
                {
                    aliens[i].SpriteBox.Visible = false;
                    this.player.Score += 10;
                    break;
                }
                //array[i].Visible = true;
                aliens[i].SpriteBox.Top += speed;

                if (aliens[i].SpriteBox.Top > this.Height)
                {
                    aliens[i].SpriteBox.Location = new Point((i + 1) * 50, -200);
                }
            }

            /*// Move the alien across the screen
            for (int i = 0; i < aliens.Length; i++)
            {
               aliens[i].Visible = true;

               // Use the left property to move right
                aliens[i].Left += speed;
   
                if (aliens[i].Right > this.Width)
                {
                    aliens[i].Location = new Point(-array[i].Width, aliens[i].Location.Y); 
                 
                }
                else if (aliens[i].Left + aliens[i].Width < 0)
                {
                    aliens[i].Location = new Point(this.Width, aliens[i].Location.Y);
                }

            }*/

            // Move the alien across the screen
            for (int i = 0; i < aliens.Length; i++)
            {
                //aliens[i].Visible = true;

                // Use the left property to move right
                aliens[i].SpriteBox.Left -= speed;
   
                if (aliens[i].SpriteBox.Right < 0)
                {
                    aliens[i].SpriteBox.Location = new Point(this.Width, (i + 1)* 50); 
                 
                }

                if (player.IsColliding(aliens[i].SpriteBox))
                {
                    player.Kill();
                    if (player.Lives <= 0)
                    {
                        GameOver();

                    }
                    else
                    {   
                        player.Respawn();
                    }
                }

            }
        }
        private void GameOver()
        {
            mainTimer.Stop();
            MessageBox.Show("Game Over!");
            Close();
        }


    }
}
