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
    public partial class menuScreen : UserControl
    {
        public menuScreen()
        {
            InitializeComponent();
        }

        private void leaderboardLabel_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new leaderboard());
        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new instructions());
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new gameScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
