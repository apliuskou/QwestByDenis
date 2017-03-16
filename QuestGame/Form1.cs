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
            game = new Game(playerPictureBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            game.MakeMove(Direction.Up);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            game.MakeMove(Direction.Down);
        }
    }
}
