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
    }
}