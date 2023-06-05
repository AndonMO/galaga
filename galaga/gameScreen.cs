using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace galaga
{
    public partial class gameScreen : UserControl
    {
        //player variables
        Hero hero;
        Boolean aDown, dDown;
        ////Rectangle hero = new Rectangle(600, 700, 55, 75);
        ////int heroSpeed = 5;
        int fireAnimation = 1;
        ////int playerHealth = 3;

        bool hittable = true;
        int hittableCounter = 0;

        //hearts
        ////int heartSpeed = 4;
        ////int heartYSize = 10;
        ////int heartXSize = 10;

        List<hearts> hearts = new List<hearts>();

        //boss variables
        //Rectangle boss = new Rectangle(300, -300, 550, 300);
        Boss boss;
        int bossSpeed = 3;
        int bossHealth = 100;
        int bossMoveTimer = 0;
        Rectangle bossHealthbar = new Rectangle(300, 20, 500, 20);

        //boss rocket variables
        bool rocketShooting = true;
        List<bossRocket> leftBossRocket = new List<bossRocket>();
        List<bossRocket> rightBossRocket = new List<bossRocket>();

        //boss laser variables
        bool laserShooting = true;
        int bossLaserSpeed = 4;
        int bossLaserXSize = 20;
        int bossLaserYSize = 200;
        int laserFlickOnTimer = 0;
        bool laserOn = true;
        List<bossLaser> leftBossLaser = new List<bossLaser>();
        List<bossLaser> rightBossLaser = new List<bossLaser>();


        //movement variables
        bool ADown = false;
        bool DDown = false;
        bool shiftDown = false;

        //laser variables
        List<playerLaser> pLasers = new List<playerLaser>();
        int playerLaserXSize = 3;
        int playerLaserYSize = 8;
        int laserSpeed = 15;
        int laserCounter = 0;

        //background variables
        List<Rectangle> movingBackgrounds = new List<Rectangle>();
        int backgroundSpeed = 1;
        int backgroundCounter = 599;
        int backgroundXSize = 1051;
        int backgroundYSize = 751;

        //round variables
        int score = 0;
        int round = 1;
        double timeClock = -1;
        int timeClockCounter = 0;
        int roundStartTimer = 0;

        //enemy variables

        //bomber enemy
        List<bomberEnemy> bombers = new List<bomberEnemy>();
        List<int> bomberSpeeds = new List<int>();
        List<int> bomberHealth = new List<int>();
        int bomberXSize = 30;
        int bomberYSize = 35;

        //soldier enemy
        List<soldierEnemy> soldiers = new List<soldierEnemy>();
        List<soldierLaser> sLasers = new List<soldierLaser>();
        List<int> soldierSpeeds = new List<int>();
        List<int> soldierHealth = new List<int>();
        int soldierXSize = 45;
        int soldierYSize = 47;
        int soldierLaserXSize = 3;
        int soldierLaserYSize = 8;
        int soldierLaserSpeed = 7;
        int soldierLaserCounter = 0;

        //chaser enemy
        List<chaserEnemy> chasers = new List<chaserEnemy>();
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

        System.Windows.Media.MediaPlayer bossMedia = new System.Windows.Media.MediaPlayer();


        public gameScreen()
        {
            InitializeComponent();

            movingBackgrounds.Add(new Rectangle(0, 0, backgroundXSize, backgroundYSize));
            bossMedia.Open(new Uri(Application.StartupPath + "/Resources/bossMusic.mp3"));
            bossMedia.MediaEnded += new EventHandler(bossMedia_MediaEnded);

            GameInitialize();
        }

        public void GameInitialize()
        {
            hero = new Hero(600, 700, 5, 3, 55, 75);
            bossMedia.Play();

            gameState = "running";

            gameEngine.Enabled = true;
            soldiers.Clear();
            bombers.Clear();
            chasers.Clear();
            timeLabel.Visible = true;
            roundLabel.Visible = true;
            scoreLabel.Visible = true;
            heart1.Visible = true;
            heart2.Visible = true;
            heart3.Visible = true;

            score = 0;
            ///playerHealth = 3; 
            round = 10;

            bossHealth = 100;
            bossHealthbar.Width = 500;

            ////hero.X = 526;
            ////hero.Y = 600;

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
            if (aDown && hero.x > 0)
            {
                hero.Move("left");
            }
            if (dDown && hero.x < this.Width - hero.width)
            {
                hero.Move("right");
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

            foreach (hearts h in hearts)
            {
                h.Move();
            }
            //create hearts

            randValue = randGen.Next(0, 201);
            for (int i = 0; i < 1; i++)
            {
                hearts newHearts = new hearts(randGen.Next(0, this.Width - 10), 0, 10, 4);
                hearts.Add(newHearts);

            }
            #endregion

            //shooting
            #region Shooting Code
            laserCounter++;

            //create lasers
            if (shiftDown == true && laserCounter > 5)
            {
                for (int i = 0; i < 1; i++)
                {
                    playerLaser newLaser = new playerLaser(hero.x + 18, hero.y, 3, 8, 15);
                    pLasers.Add(newLaser);
                    laserCounter = 0;

                    var laserSound = new System.Windows.Media.MediaPlayer();

                    laserSound.Open(new Uri(Application.StartupPath + "/Resources/laserSound.wav"));

                    laserSound.Play();
                }
            }

            //move lasers
            foreach (playerLaser p in pLasers)
            {
                p.Move(this.Width, this.Height);
                ////find the new postion of y based on speed 
                //int y = playerLaser[i].Y - laserSpeed;

                ////replace the rectangle in the list with updated one using new y 
                //playerLaser[i] = new Rectangle(playerLaser[i].X, y, playerLaserXSize, playerLaserYSize);
            }

            //Check is laser touches top of the form and remove if it is
            for (int i = 0; i < pLasers.Count; i++)
            {
                if (pLasers[i].y <= 0)
                {
                    pLasers.RemoveAt(i);
                }
            }


            //check if laser touches soldier enemy
            for (int i = 0; i < pLasers.Count(); i++)
            {
                for (int j = 0; j < soldiers.Count(); j++)
                {
                    if (pLasers[i].Collision(soldiers[j]))
                    {
                        soldierHealth[j] -= 10;
                        pLasers.RemoveAt(i);

                        if (soldierHealth[j] <= 0)
                        {
                            soldiers.RemoveAt(j);
                            soldierHealth.RemoveAt(j);
                            soldierSpeeds.RemoveAt(j);

                            score += 100;

                            scoreLabel.Text = $"{score}";
                        }
                    }
                }
            }

            //check if laser touches bomber enemy
            for (int i = 0; i < pLasers.Count(); i++)
            {
                for (int j = 0; j < bombers.Count(); j++)
                {
                    if (pLasers[i].Collision(bombers[j]))
                    {
                        bomberHealth[j] -= 10;
                        //playerLaser.RemoveAt(i);

                        if (bomberHealth[j] <= 0)
                        {
                            bombers.RemoveAt(j);
                            bomberHealth.RemoveAt(j);
                            bomberSpeeds.RemoveAt(j);

                            score += 50;

                            scoreLabel.Text = $"{score}";
                        }
                    }
                }
            }

            //check if laser touches chaser enemy
            for (int i = 0; i < pLasers.Count(); i++)
            {
                for (int j = 0; j < chasers.Count(); j++)
                {
                    if (pLasers[i].Collision(chasers[j]))
                    {
                        chaserHealth[j] -= 10;
                        //playerLaser.RemoveAt(i);

                        if (chaserHealth[j] <= 0)
                        {
                            chasers.RemoveAt(j);
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

            if (timeClockCounter == 30)
            {


                timeClock -= 1;
                timeClockCounter = 0;
                timeLabel.Text = $"Time left: {timeClock}";
            }

            if (timeClock == 0)
            {
                soldiers.Clear();
                bombers.Clear();
                chasers.Clear();

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
                foreach (soldierEnemy S in soldiers)
                {
                    S.Move(this.Width, this.Height);
                }
                ////find the new postion of x based on speed 
                //int soldierX = soldiers[i].X + soldierSpeeds[i];

                ////replace the rectangle in the list with updated one using new y 
                //soldiers[i] = new Rectangle(soldierX, soldiers[i].Y, soldierXSize, soldierYSize);

                //bounce enemy back the other direction if they hit the edge of form
                for (int i = 0; i < soldiers.Count; i++)
                {
                    if (soldiers[i].X > 800 - soldierXSize)
                    {
                        soldierSpeeds[i] *= -1;

                        temp = soldiers[i].Y + 45;
                        soldierEnemy newSoldiers = new soldierEnemy(soldiers[i].X, temp, soldierXSize, soldierYSize, 3, 20);

                    }
                    else if (soldiers[i].X < 0)
                    {
                        soldierSpeeds[i] *= -1;

                        temp = soldiers[i].Y + 45;
                        soldierEnemy newsoldiers = new soldierEnemy(soldiers[i].X, temp, soldierXSize, soldierYSize, 3, 20);
                    }
                }


                foreach (bomberEnemy B in bombers)
                {
                    B.move(this.Width, this.Height);
                }

                foreach (chaserEnemy C in chasers)
                {
                    C.Move(this.Width, this.Height);
                }


                //create enemies
                randValue = randGen.Next(0, 151);

                if (round <= 4)
                {
                    if (randValue < 1) //1% chance of soldier 
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            int x = randGen.Next(10, this.Width - soldierXSize * 2);
                            soldierEnemy newsoldiers = new soldierEnemy(x, 10, soldierXSize, soldierYSize, 3, 20);
                            soldiers.Add(newsoldiers);
                            //soldierHealth.Add(20);
                            //soldierSpeeds.Add(3);
                        }

                    }

                    else if (randValue < 3) //5% chance of bomber 
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            int x = randGen.Next(10, this.Width - bomberXSize * 2);
                            bomberEnemy newbombers = new bomberEnemy(x, 10, bomberXSize, bomberYSize, 5, 10);
                            bombers.Add(newbombers);
                            //bomberHealth.Add(10);
                            //bomberSpeeds.Add(5);
                        }
                    }

                    else if (randValue < 5) //5% change of chaser 
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            int x = randGen.Next(10, this.Width - chaserXSize * 2);
                            chaserEnemy newChaserEnemy = new chaserEnemy(x, 10, chaserXSize, chaserYSize, 3, 10);
                            chasers.Add(newChaserEnemy);
                            //chaserHealth.Add(10);
                            //chaserSpeeds.Add(3);
                        }
                    }
                }

                if (round >= 5)
                {
                    if (randValue < 3) //1% chance of soldier 
                    {
                        for (int i = 0; i < 0; i++)
                        {
                            int x = randGen.Next(10, this.Width - soldierXSize * 2);
                            soldierEnemy newsoldiers = new soldierEnemy(x, 10, soldierXSize, soldierYSize, 3, 20);
                            soldiers.Add(newsoldiers);
                            //soldierHealth.Add(20);
                            //soldierSpeeds.Add(3);
                        }
                    }

                    else if (randValue < 5) //5% chance of bomber 
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            int x = randGen.Next(10, this.Width - bomberXSize * 2);
                            bomberEnemy newbombers = new bomberEnemy(x, 10, bomberXSize, bomberYSize, 5, 10);
                            bombers.Add(newbombers);
                            bomberHealth.Add(10);
                            bomberSpeeds.Add(5);
                        }
                    }

                    else if (randValue < 7) //5% change of chaser 
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            int x = randGen.Next(10, this.Width - chaserXSize * 2);
                            chaserEnemy newChaserEnemy = new chaserEnemy(x, 10, chaserXSize, chaserYSize, 3, 10);
                            chasers.Add(newChaserEnemy);
                            chaserHealth.Add(10);
                            chaserSpeeds.Add(3);
                        }
                    }
                }

                //check if  soldier enemy is below play area and remove if it is
                for (int i = 0; i < soldiers.Count(); i++)
                {
                    if (soldiers[i].Y > this.Height - soldiers[i].YSize)
                    {
                        soldiers.RemoveAt(i);
                        soldierSpeeds.RemoveAt(i);
                        soldierHealth.RemoveAt(i);
                    }
                }

                // check if bomber enemy is below play area and remove if it is
                for (int i = 0; i < bombers.Count(); i++)
                {
                    if (bombers[i].Y > this.Height - bombers[i].YSize)
                    {
                        bombers.RemoveAt(i);
                        bomberSpeeds.RemoveAt(i);
                        bomberHealth.RemoveAt(i);
                    }
                }

                //check if chaser enemy is below play area and remove if it is
                for (int i = 0; i < chasers.Count(); i++)
                {
                    if (chasers[i].Y > this.Height - chasers[i].YSize)
                    {
                        chasers.RemoveAt(i);
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
            for (int i = 0; i < hearts.Count; i++)
            {
                if ((hearts[i].Collision(hero) == true) && hittable == true)
                {
                    hero.health += 1;
                    hittable = false;
                }

            }
            for (int i = 0; i < soldiers.Count; i++)
            {
                if ((soldiers[i].Collision(hero)) && hittable == true)
                {
                    hero.health -= 1;
                    hittable = false;
                }
            }

            for (int i = 0; i < bombers.Count; i++)
            {
                if ((bombers[i].Collision(hero)) && hittable == true)
                {
                    hero.health -= 1;
                    hittable = false;
                }
            }

            for (int i = 0; i < chasers.Count(); i++)
            {
                if (chasers[i].Collision(hero) && hittable == true)
                {
                    hero.health -= 1;
                    hittable = false;
                }
            }

            if (hero.health == 3)
            {
                heart3.Visible = true;
                heart2.Visible = true;
                heart1.Visible = true;
            }

            else if (hero.health == 2)
            {
                heart3.Visible = false;
                heart2.Visible = true;
                heart1.Visible = true;
            }

            else if (hero.health == 1)
            {

                heart3.Visible = false;
                heart2.Visible = false;
                heart1.Visible = true;
            }

            else if (hero.health == 0)
            {

                heart3.Visible = false;
                heart2.Visible = false;
                heart1.Visible = false;
                gameState = "over";
            }

            if (hero.health == 4)
            {
                hero.health = 3;
            }
            #endregion

            //soldier enemy lasers
            #region Soldier Lasers
            soldierLaserCounter++;

            //create lasers
            if (soldierLaserCounter > 20)
            {
                for (int i = 0; i < soldiers.Count(); i++)
                {
                    soldierLaser newSoldierLaser = new soldierLaser(soldiers[i].X + 18, soldiers[i].Y + soldiers[i].Y, soldierLaserXSize, soldierLaserYSize, 7);
                    sLasers.Add(newSoldierLaser);
                }
                soldierLaserCounter = 0;
            }

            foreach (soldierLaser s in sLasers)
            {
                s.Move(this.Width, this.Height);
                //find the new postion of y based on speed 
                //int y = sLasers[j].y + soldierLaserSpeed;

                ////replace the rectangle in the list with updated one using new y 
                //sLasers[j] = new Rectangle(sLasers[j].x, y, soldierLaserXSize, soldierLaserYSize);
            }

            //remove soldierLaser if it touches the bottom of the form
            for (int i = 0; i < sLasers.Count(); i++)
            {
                sLasers.RemoveAt(i);
            }

            //check if laser touches player
            for (int i = 0; i < sLasers.Count(); i++)
            {
                if (sLasers[i].Collision(hero))
                {
                    hero.health -= 1;
                    sLasers.RemoveAt(i);
                }
            }
            #endregion

            //gameState code
            #region GameStates
            if (gameState == "over")
            {
                soldiers.Clear();
                soldierHealth.Clear();
                soldierSpeeds.Clear();
                bombers.Clear();
                bomberHealth.Clear();
                bomberSpeeds.Clear();
                chasers.Clear();
                chaserHealth.Clear();
                chaserSpeeds.Clear();
                pLasers.Clear();
                sLasers.Clear();
                leftBossRocket.Clear();
                rightBossRocket.Clear();
                leftBossLaser.Clear();
                rightBossLaser.Clear();

                hearts.Clear();


                bossMedia.Stop();

                shiftDown = false;
                ADown = false;
                DDown = false;

                roundLabel.Visible = false;
                timeLabel.Visible = false;
                scoreLabel.Visible = false;
            }

            if (gameState == "win")
            {
                soldiers.Clear();
                soldierHealth.Clear();
                soldierSpeeds.Clear();
                bombers.Clear();
                bomberHealth.Clear();
                bomberSpeeds.Clear();
                chasers.Clear();
                chaserHealth.Clear();
                chaserSpeeds.Clear();
                pLasers.Clear();
                sLasers.Clear();
                leftBossRocket.Clear();
                rightBossRocket.Clear();
                leftBossLaser.Clear();
                rightBossLaser.Clear();
                hearts.Clear();

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
                bossMedia.Volume = 100;
                //healthbar
                timeClock = 1000000000;
                timeLabel.Text = $"Time left: ---";
                boss = new Boss(1, 1, 1, 1, 1, 1);
                if (boss.y >= -300)
                {
                    boss.y += bossSpeed;
                }
                if (boss.y >= 0)
                {
                    bossSpeed = 0;
                }

                //damage code
                #region damage
                for (int i = 0; i < pLasers.Count; i++)
                {
                    if (pLasers[i].Collision(boss))
                    {
                        bossHealth -= 1;
                        bossHealthbar.Width -= 5;
                        pLasers.RemoveAt(i);
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
                    bossRocket newLeftRocket = new bossRocket(boss.x + 18, boss.y + 280, 22, 50, 10);
                    bossRocket newRightRocket = new bossRocket(boss.x + 420, boss.y + 280, 22, 50, 10);
                    leftBossRocket.Add(newLeftRocket);
                    rightBossRocket.Add(newRightRocket);
                    randValue = 0;

                }

                //move left rockets
                foreach (bossRocket r in leftBossRocket)
                {
                    r.move(this.Width, this.Height);
                }

                //move right rockets
                foreach (bossRocket r in rightBossRocket)
                {
                    r.move(this.Width, this.Height);
                }

                //boss rocket damage
                for (int i = 0; i < leftBossRocket.Count(); i++)
                {
                    if (leftBossRocket[i].Collision(hero) && hittable == true && laserOn == true)
                    {
                        hero.health -= 1;
                        hittable = false;
                    }
                }

                for (int i = 0; i < rightBossRocket.Count(); i++)
                {
                    if (rightBossRocket[i].Collision(hero) && hittable == true && laserOn == true)
                    {
                        hero.health -= 1;
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
                    if (rightBossLaser[i].Collision(hero) && laserOn == true && hittable == true)
                    {
                        hero.health -= 1;
                        hittable = false;
                    }
                }

                for (int i = 0; i < leftBossLaser.Count(); i++)
                {
                    if (leftBossLaser[i].Collision(hero) && laserOn == true && hittable == true)
                    {
                        hero.health -= 1;
                        hittable = false;
                    }
                }

                //Create right Laser Sweep
                if (randValue == 2)
                {
                    bossLaser newRightLaser = new bossLaser(800, 500, 20, 200, 4);
                    rightBossLaser.Add(newRightLaser);
                    randValue = 0;
                }

                //move right laser
                foreach (bossLaser l in rightBossLaser)
                {
                    l.move(this.Width, this.Height);
                }

                //create left laser sweep
                if (randValue == 3)
                {
                    bossLaser newLeftLaser = new bossLaser(0, 500, 20, 200, 4);
                    leftBossLaser.Add(newLeftLaser);
                    randValue = 0;
                }

                //move right laser
                foreach (bossLaser l in leftBossLaser)
                {
                    l.move(this.Width, this.Height);
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
                    e.Graphics.DrawImage(playerImage1, hero.x, hero.y);
                }

                if (fireAnimation < 10 && fireAnimation > 4)
                {
                    e.Graphics.DrawImage(playerImage2, hero.x, hero.y);

                }

                if (fireAnimation < 15 && fireAnimation > 9)
                {
                    e.Graphics.DrawImage(playerImage3, hero.x, hero.y);
                }

                //draw hearts
                for (int i = 0; i < hearts.Count; i++)
                {
                    e.Graphics.DrawImage(resizeHeart, hearts[i].x, hearts[i].y);
                }

                //draw boss
                if (bossHealth > 0)
                {
                    e.Graphics.DrawImage(bossImage1, boss.x, boss.y);
                }

                //boss rockets
                for (int i = 0; i < leftBossRocket.Count; i++)
                {
                    e.Graphics.DrawImage(bossRocket1, leftBossRocket[i].x, leftBossRocket[i].y);
                }

                for (int i = 0; i < rightBossRocket.Count; i++)
                {
                    e.Graphics.DrawImage(bossRocket1, rightBossRocket[i].x, rightBossRocket[i].y);
                }

                //boss laser
                for (int i = 0; i < rightBossLaser.Count; i++)
                {
                    if (laserOn == true)
                    {
                        e.Graphics.FillRectangle(redBrush, rightBossLaser[i].x, rightBossLaser[i].y, rightBossLaser[i].xSize, rightBossLaser[i].ySize);
                    }
                }

                //left boss laser
                for (int i = 0; i < leftBossLaser.Count; i++)
                {
                    if (laserOn == true)
                    {
                        e.Graphics.FillRectangle(redBrush, leftBossLaser[i].x, leftBossLaser[i].y, leftBossLaser[i].xSize, leftBossLaser[i].ySize);
                    }
                }

                ///draw lasers
                //player lasers
                for (int i = 0; i < pLasers.Count; i++)
                {
                    e.Graphics.FillRectangle(greenBrush, pLasers[i].x, pLasers[i].y, pLasers[i].xSize, pLasers[i].ySize);
                }

                //soldier lasers
                for (int i = 0; i < sLasers.Count; i++)
                {
                    e.Graphics.FillRectangle(redBrush, sLasers[i].x, sLasers[i].y, sLasers[i].xSize, sLasers[i].ySize);
                }

                Font testFont = new Font("Arial", 12);

                //draw enemies
                for (int i = 0; i < soldiers.Count(); i++)
                {
                    e.Graphics.DrawImage(soldierImage1, soldiers[i].X, soldiers[i].Y);
                    //e.Graphics.DrawString(soldierHealth[i] + "", testFont, greenBrush, soldiers[i]);
                }

                for (int i = 0; i < bombers.Count(); i++)
                {
                    e.Graphics.DrawImage(bomberImage1, bombers[i].X, bombers[i].Y);
                    //e.Graphics.DrawString(bomberHealth[i] + "", testFont, greenBrush, bombers[i]);
                }

                for (int i = 0; i < chasers.Count(); i++)
                {
                    e.Graphics.DrawImage(chaserImage1, chasers[i].X, chasers[i].Y);
                    //e.Graphics.DrawString(bomberHealth[i] + "", testFont, greenBrush, bombers[i]);
                }
            }



            else if (gameState == "over")
            {

                Form1.ChangeScreen(this, new gameOver());
            }

            else if (gameState == "win")
            {
                Form1.ChangeScreen(this, new gameOver());
            }

            if (round == 10)
            {
                e.Graphics.FillRectangle(redBrush, bossHealthbar);
                bossNameLabel.Visible = true;
            }
        }
    }


}
