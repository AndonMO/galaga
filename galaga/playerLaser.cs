using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace galaga
{
    internal class playerLaser
    {
        public int x, y, speed;
        public int xSize = 3; 
        public int ySize = 8;

        public playerLaser(int _x, int _y, int _xSize, int _ySize, int _speed)
        {
            x = _x;
            y = _y;
            xSize = _xSize;
            ySize = _ySize;
            speed = _speed;
        }

        public void Move(int width, int height)
        {
            y -= speed;
        }

        public bool Collision (Hero h)
        {
            Rectangle laserRec = new Rectangle(x, y, xSize, ySize);
            Rectangle heroRec = new Rectangle(h.x, h.y, h.width, h.height);

            if (laserRec.IntersectsWith(heroRec))
            {
                return true;
            }
            return false;
        }
        public bool Collision(soldierEnemy s)
        {
            Rectangle laserRec = new Rectangle(x, y, xSize, ySize);
            Rectangle soldierRec = new Rectangle(s.X, s.Y, s.XSize, s.YSize);

            if (laserRec.IntersectsWith(soldierRec))
            {
                return true;
            }
            return false;
        }
        public bool Collision(chaserEnemy c)
        {
            Rectangle laserRec = new Rectangle(x, y, xSize, ySize);
            Rectangle chaserRec = new Rectangle(c.X, c.Y, c.XSize, c.YSize);

            if (laserRec.IntersectsWith(chaserRec))
            {
                return true;
            }
            return false;
        }
        public bool Collision(bomberEnemy b)
        {
            Rectangle laserRec = new Rectangle(x, y, xSize, ySize);
            Rectangle bomberRec = new Rectangle(b.X, b.Y, b.XSize, b.YSize);

            if (laserRec.IntersectsWith(bomberRec))
            {
                return true;
            }
            return false;
        }
        public bool Collision(Boss b)
        {
            Rectangle laserRec = new Rectangle(x, y, xSize, ySize);
            Rectangle bossRec = new Rectangle(b.x, b.y, b.xSize, b.ySize);

            if (laserRec.IntersectsWith(bossRec))
            {
                return true;
            }
            return false;
        }
    }
}
