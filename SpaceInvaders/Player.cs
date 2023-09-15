using System.Numerics;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public class Player : GameObject
    {
        //PROPERTIES
        int hitPoints;
        int score;
        bool moveLeft;
        bool moveRight;
        Bullet bullet;
        int lives;
        //int nextBullet;
        static int BASE_MOVEMENT_SPEED = 3;
        public static int DEFAULT_WIDTH = 75;

        //CONSTRUCTORS
        public Player(int hitPoints): base(new Point(362, 517), BASE_MOVEMENT_SPEED, 1)
        {
            this.HitPoints = hitPoints;
            this.score = 0;
            this.Lives = 3;
            this.MoveLeft = false;
            this.MoveRight = false;
            this.Bullet = new Bullet();
            initPlayerSpriteBox();
            //this.NextBullet = 0;
            //for (int i = 0; i < this.Bullets.Length; i++)
            //{
            //    this.Bullets[i] = new Bullet();
            //this.Bullets[i].Render(this);
            //}
        }

        //GETTERS AND SETTERS
        public int HitPoints { get => hitPoints; set => hitPoints = value; }
        public bool MoveRight { get => moveRight; set => moveRight = value; }
        public bool MoveLeft { get => moveLeft; set => moveLeft = value; }
        public Bullet Bullet { get => bullet; set => bullet = value; }
        public int Score { get => score; set => score = value; }
        public int Lives { get => lives; set => lives = value; }

        //public int NextBullet { get => nextBullet; set => nextBullet = value; }


        //METHODS

        void initPlayerSpriteBox()
        {
            this.SpriteBox = new PictureBox();
            this.SpriteBox.BackColor = SystemColors.Highlight;
            this.SpriteBox.Location = new Point(362, 517);
            this.SpriteBox.Name = "playerBox";
            this.SpriteBox.Size = new Size(75, 46);
            this.SpriteBox.TabIndex = 0;
            this.SpriteBox.TabStop = false;
        }

        /// <summary>
        ///  moves the player when the move_ properties are set. 
        ///  The amount of movement is determined by the movement speed property.
        /// </summary>
        public void move() 
        {
            if (this.MoveLeft && this.Location.X > 12)
            {
                this.Location = new Point(this.Location.X - this.MovementSpeed, this.Location.Y);
            }else if (this.MoveRight && this.Location.X < 731)
            {
                this.Location = new Point(this.Location.X + this.MovementSpeed, this.Location.Y);
            }
        }

        public void increaseSpeed(int increment)
        {
            this.MovementSpeed = this.MovementSpeed + (Player.BASE_MOVEMENT_SPEED * increment);
        } 

        public void calculateBulletOrigin()
        {
            int x = this.Location.X + (DEFAULT_WIDTH / 2);
            int y = this.Location.Y;
            this.Bullet.Location = new Point(x, y);
            //this.Bullets[this.NextBullet].Location = new Point(x, y);
        }

        
        public void fireBullet()
        {
            //for (int i = 0; i <= this.NextBullet; i++)
            //{
                if (this.Bullet.Location.Y < 0)
                {
                    //this.Bullets[this.NextBullet].Sprite.Visible = false;
                    calculateBulletOrigin();
                }
                //if (this.NextBullet == i)
                //{
                //    this.Bullets[this.NextBullet].Sprite.Visible = true;
                //}
                this.Bullet.Location = new Point(this.Bullet.Location.X, this.Bullet.Location.Y - 30);
                this.Bullet.SpriteBox.Location = this.Bullet.Location;
            //}

        }
        public bool IsColliding(PictureBox alien)
        {
            if(alien.Visible == true)
            {
                return this.SpriteBox.Bounds.IntersectsWith(alien.Bounds);
            }
            return false;
        }

        public void Kill() { 
            this.Lives--; 
        }

        public void Respawn()
        {
            this.Location = this.SpriteBox.Location = new Point(362, 517);
        }

    }
}