using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace galaga
{
    internal class hearts
    {
        public int x, y, Speed;
        public int Size = 10;

        public hearts(int _x, int _y, int _Size, int _Speed)
        {
            x = _x;
            y = _y;
            Size = _Size;
            Speed = _Speed;
        }

        public void Move()
        {
            y += Speed;
        }

        public bool Collision(Hero h)
        {
            Rectangle heartRec = new Rectangle(x, y, Size, Size);
            Rectangle heroRec = new Rectangle(h.x, h.y, h.width, h.height);

            if (heartRec.IntersectsWith(heroRec))
            {
                return true;
            }
            return false;
        }
    }
}
