using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    internal class DrawMonster
    {
        public int xMonst = 600;
        public int yMonst = 800;

        public void drawMC(Graphics g, Pen p)
        {
            g.DrawLine(p, xMonst, yMonst - 25, xMonst - 25, yMonst + 10);
            g.DrawLine(p, xMonst - 25, yMonst + 10, xMonst + 25, yMonst + 10);
            g.DrawLine(p, xMonst + 25, yMonst = 10, xMonst, yMonst - 25);

        }

    }
}
