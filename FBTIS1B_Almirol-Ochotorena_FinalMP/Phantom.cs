using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    internal class Phantom
    {

        // Declaration

        public int AttackPower = 15;

        // Parameter Construction

        public void defPhantom(int defAttackPower) 
        {
            defAttackPower = AttackPower;
        }

        // Methods

        public void Attack(ref Character target) 
        {
  
            target.HealthLvl -= AttackPower;

        }

        




    }
}
