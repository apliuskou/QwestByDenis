using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestGame
{
    public class Game
    {
        public Player MyPlayer;
        private List<IGameObject> gameObjects;

        public Game(PictureBox playerBox)
        {
            MyPlayer = new Player(playerBox);


        }

        public void MakeMove(Direction direction)
        {
           MyPlayer.Move(direction);
        }
    }
}
