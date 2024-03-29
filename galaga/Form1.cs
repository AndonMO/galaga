﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;
using System.Xml;

namespace galaga
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            loadScores();
            ChangeScreen(this, new menuScreen());
        }

        public void loadScores()
        {
            string highscores;
            XmlReader reader = XmlReader.Create("Resources/scoreFile.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    highscores = reader.ReadString();
                    gameScreen.highscores.Add(new Highscore(Convert.ToInt32(highscores)));
                }
            }
            reader.Close();
        }

        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f;

            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            next.Focus();
        }
    }
}
