namespace SpaceInvaders
{
    public class Player : Game
    {
        //PROPERTIES
        int hitPoints;

        //CONSTRUCTORS
        public Player(int hitPoints)
        {
            this.HitPoints = hitPoints;
        }

        //GETTERS AND SETTERS
        public int HitPoints { get => hitPoints; set => hitPoints = value; }

        
        //METHODS
    }
}