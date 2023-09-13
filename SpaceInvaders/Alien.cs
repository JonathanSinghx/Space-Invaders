using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Alien : GameObject
    {
        //PROPERTIES
        bool canShoot;
        bool collisionDamage;
        int fireRate;

        //CONSTRUCTORS
        public Alien() : base(new Point(0, 0), 1, 1)
        {
            this.CanShoot = false;
            this.CollisionDamage = false;
            this.FireRate = FireRate;
        }

        //GETTERS AND SETTERS
        public bool CanShoot { get => canShoot; set => canShoot = value; }
        public bool CollisionDamage { get => collisionDamage; set => collisionDamage = value; }
        public int FireRate { get => fireRate; set => fireRate = value; }

        //METHODS
    }
}
