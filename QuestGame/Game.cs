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
        public Bat MyBat;

        private List<IGameObject> gameObjects;

        public Game(PictureBox playerBox, PictureBox batBox)
        {
            MyPlayer = new Player(playerBox);
            MyBat = new Bat(batBox);

        }

        public void MakeTurn(Direction direction)
        {
           MyPlayer.Move(direction);
           MyBat.Move(MyBat.Think(MyPlayer));
        }
    }
}
