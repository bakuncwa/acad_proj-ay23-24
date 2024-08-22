using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    internal class Monster
    {
        public int _x;
        public int _y;

        public bool MonsterHitMC = false;
        public bool GameOver = false;

        // timer render
        // target = MainCharacter()
        // Continuous movement toward MC co-ordinates; HealthLevel continuously decrements in While-Loop
        // If MainCharacter (once instantiated) moves ASD => either monster follows or stops, which helps the MC regen

        // Parameters

        public Monster()
        {
            _x = 200;
            _y = 200;
        }


        // Automized Attack on MC 
        public void Attack(ref CharacterAttributes target)
        {
            if (MonsterHitMC == true)
            {
                while (target.HealthLevel > 0)
                {
                    _x += (2 * target.Speed);
                    if (target.x == this._x)
                    {
                        target.HealthLevel -= 10;

                    }

                    // timer function for attacks
                    // sound fx for MC target dying
                }

            }

            if (target.HealthLevel <= 0)
            {
                _x = target.Speed;
                _y = target.Speed;

                this.GameOver = true;
                MessageBox.Show("You've lost." + "\nReturn to homescreen?");

            }
        }
        }
}
