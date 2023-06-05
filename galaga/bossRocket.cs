using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace galaga
{
    public  class bossRocket
    {
        public int x, y;
        int xSize = 22;
        int ySize = 50;
        int speed = 10;

        public bossRocket(int _x, int _y, int _xSize, int _ySize, int _speed)
        {
            x = _x;
            y = _y;
            xSize = _xSize;
            ySize = _ySize;
            speed = _speed;
        }

        public void move(int width, int height)
        {
            y += speed;
        }

        public bool Collision(Hero h)
        {
            Rectangle rocketRec = new Rectangle(x, y, xSize, ySize);
            Rectangle heroRec = new Rectangle(h.x, h.y, h.width, h.height);

            if (rocketRec.IntersectsWith(heroRec))
            {
                return true;
            }
            return false;
        }
    }
}
