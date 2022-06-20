using System;
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

namespace galaga
{
    public partial class Form1 : Form
    {
        //player variables
        Rectangle hero = new Rectangle(360, 520, 55, 75);
        int heroSpeed = 5;
        int fireAnimation = 1;
        int playerHealth = 3;

        bool hittable = true;
        int hittableCounter = 0;

        //hearts
        int heartSpeed = 4;
        int heartYSize = 10;
        int heartXSize = 10;

        List<Rectangle> hearts = new List<Rectangle>();

        //boss variables
        Rectangle boss = new Rectangle(150, -300, 550, 300);
        int bossSpeed = 3;
        int bossHealth = 100;
        int bossMoveTimer = 0;

        //boss rocket variables
        bool rocketShooting = true;
        int bossRocketSpeed = 10;
        int bossRocketXSize = 22;
        int bossRocketYSize = 50;
        List<Rectangle> leftBossRocket = new List<Rectangle>();
        List<Rectangle> rightBossRocket = new List<Rectangle>();

        //boss laser variables
        bool laserShooting = true;
        int bossLaserSpeed = 4;
        int bossLaserXSize = 20;
        int bossLaserYSize = 200;
        int laserFlickOnTimer = 0;
        bool laserOn = true;
        List<Rectangle> leftBossLaser = new List<Rectangle>();
        List<Rectangle> rightBossLaser = new List<Rectangle>();

        //movement variables
        bool ADown = false;
        bool DDown = false;
        bool shiftDown = false;

        //laser variables
        List<Rectangle> playerLaser = new List<Rectangle>();
        int playerLaserXSize = 3;
        int playerLaserYSize = 8;
        int laserSpeed = 15;
        int laserCounter = 0;

        //background variables
        List<Rectangle> movingBackgrounds = new List<Rectangle>();
        int backgroundSpeed = 1;
        int backgroundCounter = 599;
        int backgroundXSize = 800;
        int backgroundYSize = 600;

        //round variables
        int score = 0;
        int round = 1;
        double timeClock = -1;
        int timeClockCounter = 0;
        int roundStartTimer = 0;

        //enemy variables
        
        //bomber enemy
        List<Rectangle> bomberEnemy = new List<Rectangle>();
        List<int> bomberSpeeds = new List<int>();
        List<int> bomberHealth = new List<int>();
        int bomberXSize = 30;
        int bomberYSize = 35;
        
        //soldier enemy
        List<Rectangle> soldierEnemy = new List<Rectangle>();
        List<Rectangle> soldierLaser = new List<Rectangle>();
        List<int> soldierSpeeds = new List<int>();
        List<int> soldierHealth = new List<int>();
        int soldierXSize = 45;
        int soldierYSize = 47;
        int soldierLaserXSize = 3;
        int soldierLaserYSize = 8;
        int soldierLaserSpeed = 7;
        int soldierLaserCounter = 0;

        //chaser enemy
        List<Rectangle> chaserEnemy = new List<Rectangle>();
        List<int> chaserSpeeds = new List<int>();
        List<int> chaserHealth = new List<int>();
        int chaserXSize = 10;
        int chaserYSize = 10;

        Random randGen = new Random();
        int randValue = 0;

        //misc variables
        int temp;

        //game initialize
        string gameState = "waiting";

        //paint tools
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        Image playerImage1 = Properties.Resources.playerShip1;
        Image playerImage2 = Properties.Resources.playerShip2;
        Image playerImage3 = Properties.Resources.playerShip3;

        Image soldierImage1 = Properties.Resources.soldierShip1;
        Image bomberImage1 = Properties.Resources.bomber1;
        Image chaserImage1 = Properties.Resources.chaserShip1;

        Image bossImage1 = Properties.Resources.boss1;
        Image bossRocket1 = Properties.Resources.rocket1;

        Image resizeHeart = Properties.Resources.heart;

        Image background = Properties.Resources.GameBackground;

        //sound players
        System.Windows.Media.MediaPlayer bossMedia = new System.Windows.Media.MediaPlayer();

        public Form1()
        {
            InitializeComponent();
            movingBackgrounds.Add(new Rectangle(0, 0, backgroundXSize, backgroundYSize));

            bossMedia.Open(new Uri(Application.StartupPath + "/Resources/bossMusic.mp3"));
            bossMedia.MediaEnded += new EventHandler(bossMedia_MediaEnded);
        }

        public void GameInitialize()
        {
            titleLabel.Text = "";
            subtitleLabel.Text = "";

            gameState = "running";

            gameEngine.Enabled = true;
            soldierEnemy.Clear();
            bomberEnemy.Clear();
            chaserEnemy.Clear();
            timeLabel.Visible = true;
            roundLabel.Visible = true;
            scoreLabel.Visible = true;
            heart1.Visible = true;
            heart2.Visible = true;
            heart3.Visible = true;

            score = 0;
            playerHealth = 3;
            round = 10;

            hero.X = 360;
            hero.Y = 520;

            roundLabel.Text = "Round: 1";
            timeLabel.Text = "Time left: 30";
            scoreLabel.Text = "0";

            timeClock = 30;
        }

        private void bossMedia_MediaEnded(object sender, EventArgs e)
        {
            bossMedia.Stop();
            bossMedia.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    ADown = true;
                    break;
                case Keys.D:
                    DDown = true;
                    break;

                //shooting keys
                case Keys.ShiftKey:
                    shiftDown = true;
                    break;
                case Keys.Space:

                    if (gameState == "waiting" || gameState == "over" || gameState == "win")
                    {
                        GameInitialize();
                    }
                    break;

                case Keys.Escape:
                    if (gameState == "waiting" || gameState == "over" || gameState == "win")
                    {
                        Application.Exit();
                    }
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    ADown = false;
                    break;
                case Keys.D:
                    DDown = false;
                    break;

                //shooting key
                case Keys.ShiftKey:
                    shiftDown = false;
                    break;
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            //Move hero
            #region move Hero
            if (ADown == true && hero.X > 0)
            {
                hero.X -= heroSpeed;
            }

            if (DDown == true && hero.X < this.Width - hero.Width)
            {
                hero.X += heroSpeed;
            }
            #endregion

            //Fire animation for hero
            #region Fire Animation
            fireAnimation++;
            if (fireAnimation == 15)
            {
                fireAnimation = 1;
            }
            #endregion

            //hearts
            #region Hearts

            //move hearts
            for (int i = 0; i < hearts.Count(); i++)
            {
                //find the new postion of y based on speed
                int Y = hearts[i].Y + heartSpeed;

                //replace the rectangle in the list with updated one using new y
                hearts[i] = new Rectangle(hearts[i].X, Y, heartXSize, heartYSize);
            }

            //create hearts

            randValue = randGen.Next(0, 201);

            if (randValue < 1)
            {
                int heartx = randGen.Next(10, this.Width - bomberXSize * 2);
                hearts.Add(new Rectangle(heartx, 10, heartXSize, heartYSize));
            }

            
            
            #endregion

            //shooting
            #region Shooting Code
            laserCounter++;

            //create lasers
            if (shiftDown == true && laserCounter > 5)
            {
                playerLaser.Add(new Rectangle(hero.X + 18, hero.Y, playerLaserXSize, playerLaserYSize));
                laserCounter = 0;

                var laserSound = new System.Windows.Media.MediaPlayer();

                laserSound.Open(new Uri(Application.StartupPath + "/Resources/laserSound.wav"));

                laserSound.Play();
            }

            //move lasers
            for (int i = 0; i < playerLaser.Count(); i++)
            {
                //find the new postion of y based on speed 
                int y = playerLaser[i].Y - laserSpeed;

                //replace the rectangle in the list with updated one using new y 
                playerLaser[i] = new Rectangle(playerLaser[i].X, y, playerLaserXSize, playerLaserYSize);
            }

            //Check is laser touches top of the form and remove if it is
            for (int i = 0; i < playerLaser.Count(); i++)
            {
                if (playerLaser[i].Y <= 0)
                {
                    playerLaser.RemoveAt(i);
                }
            }


            //check if laser touches soldier enemy
            for (int i = 0; i < playerLaser.Count(); i++)
            {
                for(int j = 0; j < soldierEnemy.Count(); j++)
                {
                    if (playerLaser[i].IntersectsWith(soldierEnemy[j]))
                    {
                        soldierHealth[j] -= 10;
                        playerLaser.RemoveAt(i);

                        if (soldierHealth[j] <= 0)
                        {
                            soldierEnemy.RemoveAt(j);
                            soldierHealth.RemoveAt(j);
                            soldierSpeeds.RemoveAt(j);

                            score += 100;

                            scoreLabel.Text = $"{score}";
                        }
                    }
                }
            }

            //check if laser touches bomber enemy
            for (int i = 0; i < playerLaser.Count(); i++)
            {
                for (int j = 0; j < bomberEnemy.Count(); j++)
                {
                    if (playerLaser[i].IntersectsWith(bomberEnemy[j]))
                    {
                        bomberHealth[j] -= 10;
                        //playerLaser.RemoveAt(i);

                        if (bomberHealth[j] <= 0)
                        {
                            bomberEnemy.RemoveAt(j);
                            bomberHealth.RemoveAt(j);
                            bomberSpeeds.RemoveAt(j);

                            score += 50;

                            scoreLabel.Text = $"{score}";
                        }
                    }
                }
            }

            //check if laser touches chaser enemy
            for (int i = 0; i < playerLaser.Count(); i++)
            {
                for (int j = 0; j < chaserEnemy.Count(); j++)
                {
                    if (playerLaser[i].IntersectsWith(chaserEnemy[j]))
                    {
                        chaserHealth[j] -= 10;
                        //playerLaser.RemoveAt(i);

                        if (chaserHealth[j] <= 0)
                        {
                            chaserEnemy.RemoveAt(j);
                            chaserHealth.RemoveAt(j);
                            chaserSpeeds.RemoveAt(j);

                            score += 50;

                            scoreLabel.Text = $"{score}";
                        }
                    }
                }
            }
            #endregion

            //moving background
            #region Moving Background
            backgroundCounter++;

                //create background
                if (backgroundCounter == 600)
                {
                    movingBackgrounds.Add(new Rectangle(0, -600, backgroundXSize, backgroundYSize));
                    backgroundCounter = 0;
                }
                //move background
                for (int i = 0; i < movingBackgrounds.Count(); i++)
                {
                    //find the new postion of y based on speed 
                    int y = movingBackgrounds[i].Y + backgroundSpeed;

                    //replace the rectangle in the list with updated one using new y 
                    movingBackgrounds[i] = new Rectangle(movingBackgrounds[i].X, y, backgroundXSize, backgroundYSize);
                }
            #endregion

            //rounds
            #region Rounds
            timeClockCounter++;

                if (timeClockCounter == 20)
                {
                   

                    timeClock -= 1;
                    timeClockCounter = 0;
                    timeLabel.Text = $"Time left: {timeClock}";
                }
                
                if (timeClock == 0)
                {
                    soldierEnemy.Clear();
                    bomberEnemy.Clear();
                    chaserEnemy.Clear();

                    roundStartLabel.Text = "Next Round Starting";
                    
                    timeLabel.Text = $"Time left: {timeClock}";

                    timeClock = 30;
                    roundStartTimer = 1;
                }
                if (roundStartTimer >= 1)
                {
                    roundStartTimer++;
                    if (roundStartTimer == 30)
                    {
                        roundStartLabel.Text = "";
                        roundStartTimer = 0;
                        round++;
                        roundLabel.Text = $"Round: {round}";
                    }
                }
            #endregion

            //enemy spawning
            #region Enemy Spawning
            if (round < 10)
                {
                    //move enemies
                    for (int i = 0; i < soldierEnemy.Count(); i++)
                    {
                        //find the new postion of x based on speed 
                        int soldierX = soldierEnemy[i].X + soldierSpeeds[i];

                        //replace the rectangle in the list with updated one using new y 
                        soldierEnemy[i] = new Rectangle(soldierX, soldierEnemy[i].Y, soldierXSize, soldierYSize);

                        //bounce enemy back the other direction if they hit the edge of form
                        if (soldierEnemy[i].X > 800 - soldierXSize)
                        {
                            soldierSpeeds[i] *= -1;
                            
                            temp = soldierEnemy[i].Y + 45;
                            soldierEnemy[i] = new Rectangle(soldierEnemy[i].X, temp, soldierXSize, soldierYSize);

                        }
                        else if (soldierEnemy[i].X < 0)
                        {
                            soldierSpeeds[i] *= -1;

                            temp = soldierEnemy[i].Y + 45;
                            soldierEnemy[i] = new Rectangle(soldierEnemy[i].X, temp, soldierXSize, soldierYSize);
                        }
                    }

                    for (int i = 0; i < bomberEnemy.Count(); i++)
                    {
                        //find the new postion of y based on speed
                        int bomberY = bomberEnemy[i].Y + bomberSpeeds[i];

                        //replace the rectangle in the list with updated one using new y
                        bomberEnemy[i] = new Rectangle(bomberEnemy[i].X, bomberY, bomberXSize, bomberYSize);
                    }

                    for (int i = 0; i < chaserEnemy.Count(); i++)
                    {
                        //find the new postion of y based on speed
                        int chaserY = chaserEnemy[i].Y + chaserSpeeds[i];

                        //replace the rectangle in the list with updated one using new y
                        chaserEnemy[i] = new Rectangle(chaserEnemy[i].X, chaserY, bomberXSize, bomberYSize);
                    }



                    //create enemies
                    randValue = randGen.Next(0, 151);

                    if (round <= 4)
                    {
                        if (randValue < 1) //1% chance of soldier 
                        {
                            int x = randGen.Next(10, this.Width - soldierXSize * 2);
                            soldierEnemy.Add(new Rectangle(x, 10, soldierXSize, soldierYSize));
                            soldierHealth.Add(20);
                            soldierSpeeds.Add(3);

                        }

                        else if (randValue < 3) //5% chance of bomber 
                        {
                            int x = randGen.Next(10, this.Width - bomberXSize * 2);
                            bomberEnemy.Add(new Rectangle(x, 10, bomberXSize, bomberYSize));
                            bomberHealth.Add(10);
                            bomberSpeeds.Add(5);
                        }

                        else if (randValue < 5) //5% change of chaser 
                        {
                            int x = randGen.Next(10, this.Width - chaserXSize * 2);
                            chaserEnemy.Add(new Rectangle(x, 10, chaserXSize, chaserYSize));
                            chaserHealth.Add(10);
                            chaserSpeeds.Add(3);
                        }
                    }

                    if (round >= 5)
                    {
                        if (randValue < 3) //1% chance of soldier 
                        {
                            int x = randGen.Next(10, this.Width - soldierXSize * 2);
                            soldierEnemy.Add(new Rectangle(x, 10, soldierXSize, soldierYSize));
                            soldierHealth.Add(20);
                            soldierSpeeds.Add(3);

                        }

                        else if (randValue < 5) //5% chance of bomber 
                        {
                            int x = randGen.Next(10, this.Width - bomberXSize * 2);
                            bomberEnemy.Add(new Rectangle(x, 10, bomberXSize, bomberYSize));
                            bomberHealth.Add(10);
                            bomberSpeeds.Add(5);
                        }

                        else if (randValue < 7) //5% change of chaser 
                        {
                            int x = randGen.Next(10, this.Width - chaserXSize * 2);
                            chaserEnemy.Add(new Rectangle(x, 10, chaserXSize, chaserYSize));
                            chaserHealth.Add(10);
                            chaserSpeeds.Add(3);
                        }
                    }

                    //check if  soldier enemy is below play area and remove if it is
                    for (int i = 0; i < soldierEnemy.Count(); i++)
                    {
                        if (soldierEnemy[i].Y > this.Height - soldierYSize)
                        {
                            soldierEnemy.RemoveAt(i);
                            soldierSpeeds.RemoveAt(i);
                            soldierHealth.RemoveAt(i);
                        }
                    }

                    // check if bomber enemy is below play area and remove if it is
                    for (int i = 0; i < bomberEnemy.Count(); i++)
                    {
                        if (bomberEnemy[i].Y > this.Height - bomberYSize)
                        {
                            bomberEnemy.RemoveAt(i);
                            bomberSpeeds.RemoveAt(i);
                            bomberHealth.RemoveAt(i);
                        }
                    }

                    //check if chaser enemy is below play area and remove if it is
                    for (int i = 0; i < chaserEnemy.Count(); i++)
                    {
                        if (chaserEnemy[i].Y > this.Height - chaserYSize)
                        {
                            chaserEnemy.RemoveAt(i);
                            chaserSpeeds.RemoveAt(i);
                            chaserHealth.RemoveAt(i);
                        }
                    }
                }
            #endregion

            //enemy hitting player; player loses health
            #region Player collision
            if (hittable == false)
            {
                hittableCounter++;
            }

            if (hittableCounter == 20)
            {
                hittable = true;
                hittableCounter = 0;
            }

            //hearts
            for (int i = 0; i < hearts.Count(); i++)
            {
                if (hero.IntersectsWith(hearts[i]) && hittable == true)
                {
                    playerHealth += 1;
                    hittable = false;
                }
            }

            for (int i = 0; i < soldierEnemy.Count(); i++)
            {
                if (soldierEnemy[i].IntersectsWith(hero) && hittable == true)
                {
                    playerHealth -= 1;
                    hittable = false;
                }
            }

            for (int i = 0; i < bomberEnemy.Count(); i++)
            {
                if (bomberEnemy[i].IntersectsWith(hero) && hittable == true)
                {
                    playerHealth -= 1;
                    hittable = false;
                }
            }

            for (int i = 0; i < chaserEnemy.Count(); i++)
            {
                if (chaserEnemy[i].IntersectsWith(hero) && hittable == true)
                {
                    playerHealth -= 1;
                    hittable = false;
                }
            }

            if (playerHealth == 3)
            {
                heart3.Visible = true;
                heart2.Visible = true;
                heart1.Visible = true;
            }

            else if (playerHealth == 2)
            {
                heart3.Visible = false;
                heart2.Visible = true;
                heart1.Visible = true;
            }

            else if (playerHealth == 1)
            {

                heart3.Visible = false;
                heart2.Visible = false;
                heart1.Visible = true;
            }

            else if (playerHealth == 0)
            {

                heart3.Visible = false;
                heart2.Visible = false;
                heart1.Visible = false;
                gameState = "over";
            }

            if (playerHealth == 4)
            {
                playerHealth = 3;
            }
            #endregion

            //soldier enemy lasers
            #region Soldier Lasers
            soldierLaserCounter++;

                //create lasers
                if (soldierLaserCounter > 20)
                {
                    for (int i = 0; i < soldierEnemy.Count(); i++)
                    {
                        soldierLaser.Add(new Rectangle(soldierEnemy[i].X + 18, soldierEnemy[i].Y + soldierEnemy[i].Y, soldierLaserXSize, soldierLaserYSize));
                    }
                    soldierLaserCounter = 0;
                }
                
                for (int j = 0; j < soldierLaser.Count(); j++)
                {
                    //find the new postion of y based on speed 
                    int y = soldierLaser[j].Y + soldierLaserSpeed;

                    //replace the rectangle in the list with updated one using new y 
                    soldierLaser[j] = new Rectangle(soldierLaser[j].X, y, soldierLaserXSize, soldierLaserYSize);

                    //Check is laser touches top of the form and remove if it is
                    
                    if (soldierLaser[j].Y >= 600)
                    {
                        soldierLaser.RemoveAt(j);
                    }
                }
               

                //check if laser touches player
                for (int i = 0; i < soldierLaser.Count(); i++)
                {
                    if (soldierLaser[i].IntersectsWith(hero))
                    {
                        playerHealth -= 1;
                        soldierLaser.RemoveAt(i);
                    }
                }
            #endregion

            //gameState code
            #region GameStates
            if (gameState == "over")
            {
                soldierEnemy.Clear();
                bomberEnemy.Clear();
                chaserEnemy.Clear();
                playerLaser.Clear();
                soldierLaser.Clear();

                bossMedia.Stop();

                roundLabel.Visible = false;
                timeLabel.Visible = false;
                scoreLabel.Visible = false;
            }

            if (gameState == "win")
            {
                soldierEnemy.Clear();
                bomberEnemy.Clear();
                chaserEnemy.Clear();
                playerLaser.Clear();
                soldierLaser.Clear();
                leftBossRocket.Clear();
                rightBossRocket.Clear();
                leftBossLaser.Clear();
                rightBossLaser.Clear();

                bossMedia.Stop();

                roundLabel.Visible = false;
                timeLabel.Visible = false;
                scoreLabel.Visible = false;
            }
            #endregion

            //boss code
            #region Boss
            if (round == 10)
            {
                //music
                bossMedia.Play();

                timeClock = 1000000000;
                timeLabel.Text = $"Time left: ---";

                if (boss.Y >= -300)
                {
                    boss.Y += bossSpeed;
                }
                if (boss.Y >= 0)
                {
                    bossSpeed = 0;
                }

                //damage code
                #region damage
                for (int i = 0; i < playerLaser.Count; i++)
                {
                    if (boss.IntersectsWith(playerLaser[i]))
                    {
                        bossHealth -= 1;
                        playerLaser.RemoveAt(i);
                    }
                }

                if (bossHealth == 0)
                {
                    rocketShooting = false;
                    gameState = "win";
                }
                #endregion

                //attacks code
                #region Attacks
                bossMoveTimer++;
                if (bossMoveTimer == 150 && rocketShooting == true && laserShooting == true)
                {
                    randValue = randGen.Next(1, 4);
                    bossMoveTimer = 0;
                }

                //rockets code
                #region Boss rockets
                if (randValue == 1)
                {
                    //create rockets
                    leftBossRocket.Add(new Rectangle(boss.X + 70, boss.Y + 280, bossRocketXSize, bossRocketYSize));
                    rightBossRocket.Add(new Rectangle(boss.X + 420, boss.Y + 280, bossRocketXSize, bossRocketYSize));
                    randValue = 0;
                }
                        
                //move left rockets
                for (int i = 0; i < leftBossRocket.Count(); i++)
                {
                    //find the new postion of y based on speed 
                    int y = leftBossRocket[i].Y + bossRocketSpeed;

                    //replace the rectangle in the list with updated one using new y 
                    leftBossRocket[i] = new Rectangle(leftBossRocket[i].X, y, bossRocketXSize, bossRocketYSize);
                }

                //move right rockets
                for (int i = 0; i < rightBossRocket.Count(); i++)
                {
                    //find the new postion of y based on speed 
                    int y = rightBossRocket[i].Y + bossRocketSpeed;

                    //replace the rectangle in the list with updated one using new y 
                    rightBossRocket[i] = new Rectangle(rightBossRocket[i].X, y, bossRocketXSize, bossRocketYSize);
                }

                //boss rocket damage
                for (int i = 0; i < leftBossRocket.Count(); i++)
                {
                    if (hero.IntersectsWith(leftBossRocket[i]) && hittable == true && laserOn == true)
                    {
                        playerHealth -= 1;
                        hittable = false;
                    }
                }

                for (int i = 0; i < rightBossRocket.Count(); i++)
                {
                    if (hero.IntersectsWith(rightBossRocket[i]) && hittable == true && laserOn == true)
                    {
                        playerHealth -= 1;
                        hittable = false;
                    }
                }
                #endregion

                //sweep laser code
                #region Boss sweep lasers
                laserFlickOnTimer++;

                if (laserFlickOnTimer == 35)
                {
                    laserOn = !laserOn;
                    laserFlickOnTimer = 0;
                }

                //right sweep laser intersection
                for (int i = 0; i < rightBossLaser.Count(); i++)
                {
                    if (hero.IntersectsWith(rightBossLaser[i]) && laserOn == true && hittable == true)
                    {
                        playerHealth -= 1;
                        hittable = false;
                    }
                }

                for (int i = 0; i < leftBossLaser.Count(); i++)
                {
                    if (hero.IntersectsWith(leftBossLaser[i]) && laserOn == true && hittable == true)
                    {
                        playerHealth -= 1;
                        hittable = false;
                    }
                }

                //Create right Laser Sweep
                if (randValue == 2)
                {
                    rightBossLaser.Add(new Rectangle(800, 400, bossLaserXSize, bossLaserYSize));
                    randValue = 0;
                }

                //move right laser
                for (int i = 0; i < rightBossLaser.Count(); i++)
                {
                    //find the new postion of y based on speed 
                    int x = rightBossLaser[i].X - bossLaserSpeed;

                    //replace the rectangle in the list with updated one using new y 
                    rightBossLaser[i] = new Rectangle(x, rightBossLaser[i].Y, bossLaserXSize, bossLaserYSize); 
                }

                //create left laser sweep
                if (randValue == 3)
                {
                    leftBossLaser.Add(new Rectangle(0, 400, bossLaserXSize, bossLaserYSize));
                    randValue = 0;
                }

                //move right laser
                for (int i = 0; i < leftBossLaser.Count(); i++)
                {
                    //find the new postion of y based on speed 
                    int x = leftBossLaser[i].X + bossLaserSpeed;

                    //replace the rectangle in the list with updated one using new y 
                    leftBossLaser[i] = new Rectangle(x, leftBossLaser[i].Y, bossLaserXSize, bossLaserYSize);
                }
                #endregion
            }
            #endregion

            #endregion
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //title
            if (gameState == "waiting")
            {
                titleLabel.Text = "SKY BLASTER";

                subtitleLabel.Text = "Press Space Bar to Start or Escape to Exit";

                timeLabel.Visible = false;
                roundLabel.Visible = false;
                scoreLabel.Visible = false;

                heart1.Visible = false;
                heart2.Visible = false;
                heart3.Visible = false;
            }

            else if (gameState == "running")
            {
                //draw background
                for (int i = 0; i < movingBackgrounds.Count; i++)
                {
                    e.Graphics.DrawImage(background, movingBackgrounds[i]);
                }

                //draw player
                if (fireAnimation < 5 && fireAnimation > 0)
                {
                    e.Graphics.DrawImage(playerImage1, hero);
                }

                if (fireAnimation < 10 && fireAnimation > 4)
                {
                    e.Graphics.DrawImage(playerImage2, hero);

                }

                if (fireAnimation < 15 && fireAnimation > 9)
                {
                    e.Graphics.DrawImage(playerImage3, hero);
                }

                //draw hearts
                for (int i = 0; i < hearts.Count; i++)
                {
                    e.Graphics.DrawImage(resizeHeart, hearts[i]);
                    //e.Graphics.FillRectangle(greenBrush, hearts[i]);
                }

                //draw boss
                if (bossHealth > 0)
                {
                    e.Graphics.DrawImage(bossImage1, boss);
                }

                //boss rockets
                for (int i = 0; i < leftBossRocket.Count; i++)
                {
                    e.Graphics.DrawImage(bossRocket1, leftBossRocket[i]);
                }

                for (int i = 0; i < rightBossRocket.Count; i++)
                {
                    e.Graphics.DrawImage(bossRocket1, rightBossRocket[i]);
                }

                //boss laser
                for (int i = 0; i < rightBossLaser.Count; i++)
                {
                    if (laserOn == true)
                    {
                        e.Graphics.FillRectangle(redBrush, rightBossLaser[i]);
                    }
                }

                //left boss laser
                for (int i = 0; i < leftBossLaser.Count; i++)
                {
                    if (laserOn == true)
                    {
                        e.Graphics.FillRectangle(redBrush, leftBossLaser[i]);
                    }
                }

                ///draw lasers
                //player lasers
                for (int i = 0; i < playerLaser.Count; i++)
                {
                    e.Graphics.FillRectangle(greenBrush, playerLaser[i]);
                }

                //soldier lasers
                for (int i = 0; i < soldierLaser.Count; i++)
                {
                    e.Graphics.FillRectangle(redBrush, soldierLaser[i]);
                }

                Font testFont = new Font("Arial", 12);

                //draw enemies
                for (int i = 0; i < soldierEnemy.Count(); i++)
                {
                    e.Graphics.DrawImage(soldierImage1, soldierEnemy[i]);
                    //e.Graphics.DrawString(soldierHealth[i] + "", testFont, greenBrush, soldierEnemy[i]);
                }

                for (int i = 0; i < bomberEnemy.Count(); i++)
                {
                    e.Graphics.DrawImage(bomberImage1, bomberEnemy[i]);
                    //e.Graphics.DrawString(bomberHealth[i] + "", testFont, greenBrush, bomberEnemy[i]);
                }

                for (int i = 0; i < chaserEnemy.Count(); i++)
                {
                    e.Graphics.DrawImage(chaserImage1, chaserEnemy[i]);
                    //e.Graphics.DrawString(bomberHealth[i] + "", testFont, greenBrush, bomberEnemy[i]);
                }
            }

            else if (gameState == "over")
            {
                titleLabel.Text = $"You died! \nFinished with a score of {score}";
                subtitleLabel.Text = $"Press Space Bar to Start or Escape to Exit";

                timeLabel.Visible = false;
                roundLabel.Visible = false;
                scoreLabel.Visible = false;

                heart1.Visible = false;
                heart2.Visible = false;
                heart3.Visible = false;
            }

            else if (gameState == "win")
            {
                titleLabel.Text = $"You win! \nFinished with a score of {score}";
                subtitleLabel.Text = $"Press Space Bar to Start or Escape to Exit";

                timeLabel.Visible = false;
                roundLabel.Visible = false;
                scoreLabel.Visible = false;

                heart1.Visible = false;
                heart2.Visible = false;
                heart3.Visible = false;
            }
        }
    }
}
