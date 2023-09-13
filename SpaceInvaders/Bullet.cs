using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Bullet : GameObject
    {
        //PROPERTIES
        bool damage;

        //CONSTRUCTORS
        public Bullet() : base(new Point(0, 0), 1, 1)
        {
            this.Damage = false;
        }

        //GETTERS AND SETTERS
        public bool Damage { get => damage; set => damage = value; }


        //METHODS
    }
}
