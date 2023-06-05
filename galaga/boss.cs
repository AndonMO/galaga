using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galaga
{
    internal class Boss
    {
        public int x, y;
        public int speed = 3;
        public int health = 300;
        public int xSize = 550;
        public int ySize = 300;

        public Boss(int _x, int _y, int _speed, int _health, int _xSize, int _ySize)
        {
            x = _x;
            y = _y;
            speed = _speed;
            health = _health;
            xSize = _xSize;
            ySize = _ySize;

        }

        public void Move(int width, int height)
        {
            y += speed;
        }

    }
}
