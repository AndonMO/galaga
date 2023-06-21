using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galaga
{
    internal class Boss
    {
        public int x = 200, y = 0;
        public int speed = 3;
        public int health = 300;
        public int width = 550;
        public int height = 300;

        public Boss(int _x, int _y, int _speed, int _health, int _width, int height)
        {
            x = _x;
            y = _y;
            speed = _speed;
            health = _health;
            width = width;
            height = height;

        }

        public void Move(int width, int height)
        {
            y += speed;
        }

    }
}
