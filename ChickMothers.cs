using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSimulation
{
    internal class ChickMothers : Animal
    {
        Random random = new Random();
        
        public ChickMothers(int left, int right, int top, int down)
        {
            img = Properties.Resources.chick;
            posX = random.Next(left, right);
            posY = random.Next(top , down);
            height = 100;
            width = 100;
            speed = 50;
            eggPeriod = 0;
        }
        public ChickMothers()
        {
            img = Properties.Resources.chick;
            height = 100;
            width = 100;
            speed = 50;

            //FOR SPEED
            limit = random.Next(200, 400);
            moveLimit = limit;
            speedX = random.Next(-5, 5);
            speedY = random.Next(-5, 5);
        }

       
        public void MakeEegg()
        {

        }

    }
}
