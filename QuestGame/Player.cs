using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuestGame
{
    public class Player : Mover, IGameObject
    {
        public Player(PictureBox myBox) : base(myBox)
        {

        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}