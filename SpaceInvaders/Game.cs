using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpaceInvaders
{
    public partial class Game
    {
        //PROPERTIES
        Player player;
        Alien[] aliens;
        private bool isGamePaused = false;
        int currentLevel;


        //GETTERS AND SETTERS
        public Player Player1 { get => player; set => player = value; }

        //METHODS

        /// <summary>
        ///  Listening for which key is press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                player.MoveLeft = true;
                player.MoveRight = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                player.MoveRight = true;
                player.MoveLeft = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                player.MoveLeft = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                player.MoveRight = false;
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            player.move();
            this.player.SpriteBox.Location = player.Location;
            MoveAliens(aliens);
            this.player.fireBullet();
            this.scoreLabel.Text = "SCORE: " + this.player.Score;
        }


        private void initalizeGame()
        {
            this.currentLevel = 1;
            this.BackColor = Color.FromArgb(19, 35, 86); 
            this.player = new Player(100);
            this.player.Location = player.SpriteBox.Location;
            this.player.Bullet.Render(this);
            Controls.Add(player.SpriteBox);
        }

        public void Load_aliens()
        {

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


        // access the alien array and display aliens moving from top to bottom

        /// <summary>
        /// Moves an array of PictureBoxes downward by a specified speed.
        /// Moves a collection of PictureBoxes horizontally across the screen.
        /// Moves a collection of PictureBoxes horizontally across the screen in the opposite direction (left).
        /// </summary>
        /// <param name="array">The array of PictureBoxes to move.</param>
        /// <param name="speed">The speed at which to move the PictureBoxes.</param>
        public void MoveAliens(Alien[] aliens)
        {
            if(this.player.Score > 50 && this.player.Score % 50 == 0)
            {
                this.currentLevel += 1; 
            }
            
            for (int i = 0; i < aliens.Length; i++)
            {
                if (this.player.Bullet.SpriteBox.Bounds.IntersectsWith(aliens[i].SpriteBox.Bounds))
                {
                    aliens[i].kill();
                    this.player.Score += 10;
                    break;
                }
                //array[i].Visible = true;
                aliens[i].SpriteBox.Top += (aliens[i].MovementSpeed * this.currentLevel);

                if (aliens[i].SpriteBox.Top > this.Height)
                {
                    if (aliens[i].Killed)
                    {
                        aliens[i].recycle();
                    }
                    aliens[i].SpriteBox.Location = new Point((i + 1) * 50, -200);
                }
            }

            /*// Move the alien across the screen
            // * // Loop through the PictureBox array.
            for (int i = 0; i < aliens.Length; i++)
            {
               aliens[i].Visible = true;

                // Move the PictureBox horizontally (to the right) by the specified speed.
                aliens[i].Left += speed;

                // Check if the PictureBox has moved beyond the right edge of the screen.
                if (aliens[i].Right > this.Width)
                {
                    // Reset the PictureBox's location to the left edge, just outside the screen.
                    aliens[i].Location = new Point(-array[i].Width, aliens[i].Location.Y); 
                 
                }
                // Check if the PictureBox has moved beyond the left edge of the screen.
                else if (aliens[i].Left + aliens[i].Width < 0)
                {
                    // Reset the PictureBox's location to the right edge, just outside the screen.
                    aliens[i].Location = new Point(this.Width, aliens[i].Location.Y);

                }
            }*/

            // Loop through the PictureBox array.
            for (int i = 0; i < aliens.Length; i++)
            {

                // Move the PictureBox horizontally (to the left) by the specified speed.
                aliens[i].SpriteBox.Left -= aliens[i].MovementSpeed;
                // Check if the PictureBox has moved completely out of the screen on the left side.
                if (aliens[i].SpriteBox.Right < 0)
                {
                    // Reset the PictureBox's location to the right edge, at a new vertical position.
                    aliens[i].SpriteBox.Location = new Point(this.Width, (i + 1)* 50); 
                 
                }

                if (player.IsColliding(aliens[i].SpriteBox))
                {
                    player.Kill();
                    if (player.Lives <= 0)
                    {
                        //GameOver();
                    }
                    else
                    {
                        // reset alien locations
                        this.resetAlienLocations();
                        this.pause();
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

        private void unPause()
        {
            timer1.Enabled = true;
            mainTimer.Enabled = true;
            button1.Text = "Pause";
            isGamePaused = false;
        }

        private void pause()
        {
            timer1.Enabled = false;
            mainTimer.Enabled = false;
            button1.Text = "Play";
            isGamePaused = true;
        }

        void resetAlienLocations()
        {
            for(int i = 0; i < aliens.Length; i++)
            {
                this.aliens[i].SpriteBox.Location = new Point((i + 1) * 60, -60);
            }
        }
    }
}
