using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class GameObject
    {
        //PROPERTIES
        Point location;
        int movementSpeed;
        int width;

        //CONSTRUCTORS
        public GameObject(Point location, int movementSpeed, int width)
        {
            this.Location = location;
            this.MovementSpeed = movementSpeed;
            this.Width = width;
        }

        //GETTERS AND SETTERS
        public Point Location { get => location; set => location = value; }
        public int MovementSpeed { get => movementSpeed; set => movementSpeed = value; }
        public int Width { get => width; set => width = value; }

        //METHODS
    }
}
