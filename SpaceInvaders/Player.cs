using System.Windows.Forms;

namespace SpaceInvaders
{
    public class Player : GameObject
    {
        //PROPERTIES
        int hitPoints;
        bool moveLeft;
        bool moveRight;
        private PictureBox playerSpriteBox;
        static int BASE_MOVEMENT_SPEED = 3;

        //CONSTRUCTORS
        public Player(int hitPoints): base(new Point(0,0), BASE_MOVEMENT_SPEED, 1)
        {
            this.HitPoints = hitPoints;
            this.MoveLeft = false;
            this.MoveRight = false;
        }

        //GETTERS AND SETTERS
        public int HitPoints { get => hitPoints; set => hitPoints = value; }
        public bool MoveRight { get => moveRight; set => moveRight = value; }
        public bool MoveLeft { get => moveLeft; set => moveLeft = value; }


        //METHODS

        //moves the player when the move_ properties are set. 
        //The amount of movement is determined by the movement speed property.
        public void move() 
        {
            if (this.MoveLeft)
            {
                this.Location = new Point(this.Location.X - this.MovementSpeed, this.Location.Y);
            }else if (this.MoveRight)
            {
                this.Location = new Point(this.Location.X + this.MovementSpeed, this.Location.Y);
            }
        }

        public void increaseSpeed(int increment)
        {
            this.MovementSpeed = this.MovementSpeed + (Player.BASE_MOVEMENT_SPEED * increment);
        } 


    }
}