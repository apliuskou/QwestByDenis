using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestGame
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
            game = new Game(playerPictureBox, batPictureBox);
        }

        private void Form1_Load(object sender, EventArgs e)//Unuseful method
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            game.MakeTurn(Direction.Up);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            game.MakeTurn(Direction.Down);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            game.MakeTurn(Direction.Left);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            game.MakeTurn(Direction.Right);
        }
    }
}
