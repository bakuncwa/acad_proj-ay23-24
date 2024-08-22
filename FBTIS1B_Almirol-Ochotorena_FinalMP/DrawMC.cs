using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    internal class DrawMC
    {
        public int xMC = 300;
        public int yMC = 400;

        public int Speed = 5;

        public int Level;
        public int LevelMax;
        public int HealthLevel;
        public int HealthMax;

        public bool IsMovingUp = false;
        public bool IsMovingDown = false;
        public bool IsMovingLeft = false;
        public bool IsMovingRight = false;

        // Parameters

        public void mainchara()
        {
            this.Level = 1;
            this.LevelMax = 2;
            this.HealthLevel = this.HealthMax = 100;
        }

        public void drawMC(Graphics g, Pen p) 
        {
            g.DrawLine(p, xMC, yMC - 25, xMC -25, yMC + 10);
            g.DrawLine(p, xMC - 25, yMC + 10, xMC + 25, yMC +10);
            g.DrawLine(p, xMC + 25, yMC = 10, xMC, yMC - 25);

            for (; IsMovingDown == true; yMC -= Speed)
            {
                HealthLevel += 5;

                if (HealthLevel > HealthMax)
                {
                    HealthLevel = HealthMax;
                }
            }

        }
    }
}
