using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace galaga
{
    public partial class gameOver : UserControl
    {
        public gameOver()
        {
            InitializeComponent();
            scoreLabel.Text = $"Your final score was {gameScreen.score}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            //Highscore newHighscore = new Highscore(gameScreen.score);
            gameScreen.highscores.Add(new Highscore(gameScreen.score));

            XmlWriter writer = XmlWriter.Create("Resources/scoreFile.xml", null);

            writer.WriteStartElement("Highscore");

            foreach (Highscore h in gameScreen.highscores)
            {
                writer.WriteStartElement("Highscore");

                writer.WriteElementString("score", h.score.ToString());

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();

            Form1.ChangeScreen(this, new menuScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
