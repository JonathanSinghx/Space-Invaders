using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Bullet : Game
    {
        //PROPERTIES
        bool damage;

        //CONSTRUCTORS
        public Bullet()
        {
            this.Damage = false;
        }

        //GETTERS AND SETTERS
        public bool Damage { get => damage; set => damage = value; }


        //METHODS
    }
}
