using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace galaga
{
    public class bossLaser
    {
        public int x, y;
        public int xSize = 20;
        public int ySize = 200;
        int speed = 4;

        public bossLaser(int _x, int _y, int _xSize, int _ySize, int _speed)
        {
            x = _x;
            y = _y;
            xSize = _xSize;
            ySize = _ySize;
            speed = _speed;
        }

        public void move(int width, int height)
        {
            x -= speed;
        }

        public bool Collision(Hero h)
        {
            Rectangle beamRec = new Rectangle(x, y, xSize, ySize);
            Rectangle heroRec = new Rectangle(h.x, h.y, h.width, h.height);

            if (beamRec.IntersectsWith(heroRec))
            {
                return true;
            }
            return false;
        }
    }
}
