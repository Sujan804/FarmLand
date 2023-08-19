using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSimulation
{
     internal class Chicks : Animal
    {

        public Chicks Mother;
        Random random = new Random();
   
        public Chicks(int left, int right, int top, int down)
        {
            img = Properties.Resources.chick;
            posX = random.Next(left, right);
            posY = random.Next(top, down);
            height = 100;
            width = 100;
            speed = 10;
            eggPeriod = 0;
            isRoot = true;
            isMother = true;
            age = 100;
            
        }
        public Chicks(Chicks mother)
        { 
            Mother = mother;
            img = Properties.Resources.egg;
            posX = random.Next(mother.posX-5, mother.posX + 5);
            posY = random.Next(mother.posY-5, mother.posY + 5);
            height = 30;
            width = 30;
            speed = 10;
            age = 0;
            isRoot = false;
            isMother = false;
        } 
        public void EatChicks()
        {

        }
        public void GrowChicks()
        {

        }
        public void ConvertToMother()
        {

        }
    }
}
