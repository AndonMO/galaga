using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace galaga
{
    internal class bomberEnemy
    {
        public int X, Y, Speed, Health;
        public int XSize = 30;
        public int YSize = 35;

        public bomberEnemy(int _X, int _Y, int _XSize, int _YSize, int _Speed, int _Health)
        {
            X = _X;
            Y = _Y;
            XSize = _XSize;
            YSize = _YSize;
            Speed = _Speed;
            Health = _Health;
        }

        public void move(int Width, int Height)
        {
            Y += Speed;
        }

        public bool Collision(Hero h)
        {
            Rectangle bomberRec = new Rectangle(X, Y, XSize, YSize);
            Rectangle heroRec = new Rectangle(h.x, h.y, h.width, h.height);

            if (bomberRec.IntersectsWith(heroRec))
            {
                return true;
            }
            return false;
        }
    }
}
