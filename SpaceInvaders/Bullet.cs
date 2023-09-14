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
        PictureBox sprite;

        //CONSTRUCTORS
        public Bullet() : base(new Point(0, 0), 1, 1)
        {
            this.Damage = false;
        }

        //GETTERS AND SETTERS
        public bool Damage { get => damage; set => damage = value; }
        public PictureBox Sprite { get => sprite; set => sprite = value; }


        //METHODS
        public void Render(Game game)
        {
            sprite = new PictureBox();
            sprite.Size = new Size(5, 10);
            sprite.SizeMode = PictureBoxSizeMode.Zoom;
            sprite.BorderStyle = BorderStyle.None;
            //sprite.Visible = false;
            sprite.BackColor = Color.Black;
            game.Controls.Add(sprite);
            sprite.Location = new Point(-10, -10);
        }
    }
}
