using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuestGame
{
    public abstract class Enemy : Mover
    {
        public Enemy(PictureBox myBox) : base(myBox)
        {
        }

        public Direction Think(Player anyPlayer)
        {
            int x = anyPlayer.Box.Location.X;
            int y = anyPlayer.Box.Location.Y;

            if (this.Box.Location.X > x )
            { return Direction.Left; }

            if (this.Box.Location.X < x)
            { return Direction.Right; }

            if (this.Box.Location.Y > y)
            { return Direction.Up; }

            if (this.Box.Location.Y < y)
            { return Direction.Down; }

            return Direction.Up;

        }




    }
}