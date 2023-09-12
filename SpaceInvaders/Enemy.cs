using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Enemy : Game
    {
        //PROPERTIES
        bool canShoot;
        bool collisionDamage;
        int fireRate;

        //CONSTRUCTORS
        public Enemy()
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
