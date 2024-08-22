using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    internal class House
    {
        // house shake vfx
        // sound house shake vfx

        public int _xh;
        public int _yh;
        public bool ObjectHitMC = false;
        public bool GameOver = false;

        // Parameters

        public House(ref CharacterAttributes target)
        {
            _xh = 0;
            _yh = 0;

            if (this.ObjectHitMC == true)
            {
                target.HealthLevel -= 10;

                if (target.HealthLevel <= 0)
                {
                    _xh = target.Speed;
                    _yh = target.Speed;

                    // intersection with the MC = HP level decrements
                    // while loop => if it doesnt intersect with the MC; ObjectHitMC.Visible = false;

                    this.GameOver = true;
                    MessageBox.Show("You've lost." + "\nReturn to homescreen?");
                }
            }
        }
    }
}
