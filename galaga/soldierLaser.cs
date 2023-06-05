using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace galaga
{
    internal class soldierLaser
    {
        public int x, y, speed;
        public int xSize = 3;
        public int ySize = 8;

        public soldierLaser(int _x, int _y, int _xSize, int _ySize, int _speed)
        {
            x = _x;
            y = _y;
            xSize = _xSize;
            ySize = _ySize;
            speed = _speed;
        }

        public void Move(int width, int height)
        {
            y += speed;
        }

        public bool Collision(Hero h)
        {
            Rectangle laserRec = new Rectangle(x, y, xSize, ySize);
            Rectangle heroRec = new Rectangle(h.x, h.y, h.width, h.height);

            if (laserRec.IntersectsWith(heroRec))
            {
                return true;
            }
            return false;
        }
    }
}
