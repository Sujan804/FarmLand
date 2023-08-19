using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSimulation
{
    internal class Food
    {
        public int posX;
        public int posY;
        public Image img;
        public int hight;
        public int width;
        Random random = new Random();
        int lifeTime = 200;
        public bool expired = false;

        public Food()
        {
            img = Properties.Resources.food;
            posX = random.Next(600, 1000);
            posY = random.Next(0, 700);
            hight = 10;
            width = 10;
        }
        public void checkLifetime()
        {
            lifeTime -= 1;
            if(lifeTime <= 0)
            {
                expired = true;
            }
        }
    }
}
