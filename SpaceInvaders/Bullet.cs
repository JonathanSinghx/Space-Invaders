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
        public void Render(Game game)
        {
            SpriteBox = new PictureBox();
            SpriteBox.Size = new Size(5, 10);
            SpriteBox.SizeMode = PictureBoxSizeMode.Zoom;
            SpriteBox.BorderStyle = BorderStyle.None;
            //sprite.Visible = false;
            SpriteBox.BackColor = Color.Yellow;
            game.Controls.Add(SpriteBox);
            SpriteBox.Location = new Point(-10, -10);
        }
    }
}
