using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Reward : GameObject
    {
        //PROPERTIES
        string type;

        //CONSTRUCTORS
        public Reward(string type) : base(new Point(0, 0), 1, 1)
        {
            this.Type = type;
        }

        //GETTERS AND SETTERS
        public string Type { get => type; set => type = value; }


        //METHODS
    }
}
