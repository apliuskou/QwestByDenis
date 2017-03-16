using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuestGame
{
    public class Mover
    {
        public PictureBox Box { get; private set; }
        public int HP { get; private set; }

        public Mover(PictureBox myBox)
        {
            Box = myBox;
        }

        void Attack(Mover target)
        {
            
        }

        public virtual void Move(Direction direction)
        {
            Point currentPoint = Box.Location;
            Point newPoint = new Point();

            switch (direction)
            {
                case Direction.Up:
                    newPoint.X = currentPoint.X;
                    newPoint.Y = currentPoint.Y - 10;
                    Box.Location = newPoint;
                    break;


                case Direction.Down:
                    newPoint.X = currentPoint.X;
                    newPoint.Y = currentPoint.Y + 10;
                    Box.Location = newPoint;
                    break;



            }
        }
    }
}