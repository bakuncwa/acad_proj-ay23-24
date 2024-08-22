using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    internal class Character
    {

        // Declaration

        public int HealthLvl = 100;
        public int HealthMax = 100;
        public int RunPower = 10;


        // Parameterless Construction

        public void Hero()
        {
            this.HealthLvl = this.HealthMax = 100;
            this.RunPower = 10;

        }

        // Conditions

        public void Run() 
        {
            HealthLvl += RunPower;

            if (this.HealthLvl > this.HealthMax) 
            {
                HealthLvl = HealthMax;
            }
        }


    }
}
