using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace newSimulation
{
    internal class Animal
    {
        public Image img;
        public int posX;
        public int posY;
        public double width;
        public double height;
        public double speed;
        public int speedX, speedY, limit, moveLimit;
        public Random rand = new Random();
        public bool toRotate = false;
        public int eggPeriod;
        public int age;
        public bool isRoot;
        public bool isMother;
        public void MoveAnimal()
        {
            moveLimit--;
            if (moveLimit < 0)
            {
                toRotate = !true;
                if (speedX < 0)
                {
                    speedX = rand.Next(2, 5);
                }
                else
                {
                    speedX = rand.Next(-5, -2);
                }
                if (speedY < 0)
                {
                    speedY = rand.Next(2, 5);
                }
                else
                {
                    speedY = rand.Next(-5, -2);
                }
                moveLimit = rand.Next(200, 400);
            }
        }
    }
}
