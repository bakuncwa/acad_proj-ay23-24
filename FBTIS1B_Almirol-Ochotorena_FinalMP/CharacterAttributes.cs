using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    internal class CharacterAttributes
    {

        
        
            // Declaration
            public int Level;
            public int LevelMax;
            public int HealthLevel;
            public int HealthMax;

            public int x;
            public int y;
            public int Speed;

            public bool IsMovingUp = false;
            public bool IsMovingDown = false;
            public bool IsMovingLeft = false;
            public bool IsMovingRight = false;

            // Parameters
            public void MainCharacter()
            {
                this.Level = 1;
                this.LevelMax = 2;
                this.HealthLevel = this.HealthMax = 100;

                this.y = 200;
                this.x = 200;
                this.Speed = 5;
            }

            // Retaliate Method
            public void Retaliate()
            {
                HealthLevel -= 10;
                if (HealthLevel < 0) HealthLevel = HealthMax;
                {
                    MessageBox.Show("You've died. " +
                      "\n Would you like to start over?");
                }

                // implement target
            }

            // Run Method
            public void Run()
            {

                if (IsMovingDown == true)
                {
                    x -= Speed;
                    HealthLevel += 5;

                    if (HealthLevel > HealthMax)
                    {
                        HealthLevel = HealthMax;
                    }
                }

                for (; IsMovingUp == true; y += Speed)
                {
                    HealthLevel -= 5;

                    if (HealthLevel < 0)
                    {
                        // return to home screen
                    }
                }

                for (; IsMovingUp == true; y += Speed)
                {
                    HealthLevel -= 5;

                    if (HealthLevel > HealthMax)
                    {
                        HealthLevel = HealthMax;
                    }
                }


                for (; IsMovingDown == true; y -= Speed)
                {
                    HealthLevel += 5;

                    if (HealthLevel > HealthMax)
                    {
                        HealthLevel = HealthMax;
                    }
                }

                for (; IsMovingLeft == true; x -= Speed)
                {
                    HealthLevel += 5;

                    if (HealthLevel > HealthMax)
                    {
                        HealthLevel = HealthMax;
                    }
                }

                for (; IsMovingRight == true; x += Speed)
                {
                    HealthLevel += 5;

                    if (HealthLevel > HealthMax)
                    {
                        HealthLevel = HealthMax;
                    }
                }

                if (HealthLevel == HealthMax)
                {
                    Level += 1;
                }

                // Max-Level Reached: Beat the Game

                if (Level == LevelMax)
                {
                    MessageBox.Show("Triumph.");
                }

                // MC.UpdateStats(); => Move on to next level




            }

        }
    }
