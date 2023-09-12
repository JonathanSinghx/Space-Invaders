using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Reward : Game
    {
        //PROPERTIES
        string type;

        //CONSTRUCTORS
        public Reward(string type)
        {
            this.Type = type;
        }

        //GETTERS AND SETTERS
        public string Type { get => type; set => type = value; }


        //METHODS
    }
}
