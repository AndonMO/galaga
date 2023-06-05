using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galaga
{
    public class Hero
    {
        public int x = 600, y = 700;
        public int speed = 5;
        public int fireAnimation = 1;
        public int health = 3;
        public int width = 55;
        public int height = 75;

        public Hero(int _x, int _y, int _speed, int _health, int _width, int _height)
        {
            x = _x;
            y = _y;
            speed = _speed;
            health = _health;
            width = _width;
            height = _height;

        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
        }
    }
}
