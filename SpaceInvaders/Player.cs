using System.Windows.Forms;

namespace SpaceInvaders
{
    public class Player : GameObject
    {
        //PROPERTIES
        int hitPoints;
        bool moveLeft;
        bool moveRight;
        Bullet bullet;
        //int nextBullet;
        private PictureBox playerSpriteBox;
        static int BASE_MOVEMENT_SPEED = 3;
        public static int DEFAULT_WIDTH = 75;

        //CONSTRUCTORS
        public Player(int hitPoints): base(new Point(0,0), BASE_MOVEMENT_SPEED, 1)
        {
            this.HitPoints = hitPoints;
            this.MoveLeft = false;
            this.MoveRight = false;
            this.Bullet = new Bullet();
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
        //public int NextBullet { get => nextBullet; set => nextBullet = value; }


        //METHODS

        //moves the player when the move_ properties are set. 
        //The amount of movement is determined by the movement speed property.
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
                this.Bullet.Sprite.Location = this.Bullet.Location;
            //}

        }

    }
}