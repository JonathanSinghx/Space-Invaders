﻿using System;
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
        int level;
        bool killed;
        static int BASE_MOVEMENT_SPEED = 3;

        //CONSTRUCTORS
        public Alien() : base(new Point(0, 0), BASE_MOVEMENT_SPEED, 1)
        {
            this.CanShoot = false;
            this.CollisionDamage = false;
            this.FireRate = FireRate;
        }
        public void initSprite() {
            this.SpriteBox = new PictureBox();
            this.SpriteBox.Size = new Size(40, 40);
            this.SpriteBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.SpriteBox.BorderStyle = BorderStyle.None;
            //aliens[i].Visible = false; // ensure that the aliens doesn't show up on the start screen
            //this.Controls.Add(aliens[i]);
            //aliens[i].Location = new Point((i + 1) * 60, -60); //arrange the aliens on the screen
        }

        //GETTERS AND SETTERS
        public bool CanShoot { get => canShoot; set => canShoot = value; }
        public bool CollisionDamage { get => collisionDamage; set => collisionDamage = value; }
        public int FireRate { get => fireRate; set => fireRate = value; }
        public bool Killed { get => killed; set => killed = value; }

        //METHODS
        public void kill()
        {
            this.Killed = true;
            this.SpriteBox.Visible = false;
        }

        public void recycle()
        {
            this.Killed = false;
            this.SpriteBox.Visible = true;
        }

    }
}
