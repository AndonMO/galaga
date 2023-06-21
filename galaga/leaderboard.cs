using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galaga
{
    public partial class leaderboard : UserControl
    {
        public leaderboard()
        {
            InitializeComponent();

            scoresLabel.Text = "";
            gameScreen.highscores = gameScreen.highscores.OrderByDescending(x => x.score).ToList();

            foreach (Highscore newScore in gameScreen.highscores)
            {
                
                scoresLabel.Text += $"{newScore.score}\n";
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new menuScreen());
        }
    }
}
