using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    public partial class PhantomOdyssey_Minigame2 : Form
    {
        System.Timers.Timer t;
        int secs = 10;

        public PhantomOdyssey_Minigame2()
        {
            InitializeComponent();
        }

        Character hero = new Character();
        Phantom phantom = new Phantom();


        private void PhantomOdyssey_Minigame2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pBtnRetaliate_Click(object sender, EventArgs e)
        {

      
            phantom.Attack(ref hero);
 
            lblHealthLvl.Text = "Health: " + hero.HealthLvl.ToString();


            if (hero.HealthLvl <= 0)
            {
                lblHealthLvl.Text = "Health: 0";
                MessageBox.Show("Game Over.");
            }

            
            
            picPhantom.Left -= 30;



        }

        private void pBtnRun_Click(object sender, EventArgs e)
        {


            hero.Run();

            picMC.Left -= 20;

            lblHealthLvl.Text = "Health: " + hero.HealthLvl.ToString();

            if (hero.HealthLvl > hero.HealthMax)
            {
                hero.HealthLvl = hero.HealthMax;
            }



        }

        private void PhantomOdyssey_Minigame2_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;

            t.Elapsed += OnTimeEvent;
            t.Start();
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {       

            Invoke(new Action(() =>
            {
                secs -= 1;

                lblTimer.Enabled = true;
                lblTimer.Text = "Time: " + secs.ToString();

                if (secs == 0 || secs <= 0)
                {
                    lblTimer.Enabled = false;
                }

                if (secs == 0) 
                {
                    MessageBox.Show("Time is up, game over!");
                    // NextForms.ShowDialog();
                }
            }));

        }

        private void picPhantom_Click(object sender, EventArgs e)
        {
          

        }

        // if (GameOver == true) 
        // { MessageBox.Show("You won!"); // ShowDialog
        //   picHallway.Visible = true;
        //   picUpstairs.Visible = true;
        //
        // ]

    }
}
