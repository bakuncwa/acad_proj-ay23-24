using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    public partial class PhantomOdyssey_Minigame1 : Form
    {
        public PhantomOdyssey_Minigame1()
        {
            InitializeComponent();

        }

        DrawMC mainchara = new DrawMC();
        Graphics gfx;
        Pen pen;

        private void PhantomOdyssey_Minigame1_Load(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
            pen = new Pen(Color.Black, 4.0f);

        }

        private void tRender1_Tick(object sender, EventArgs e)
        {
            gfx.Clear(this.BackColor);
            mainchara.drawMC(gfx, pen);


        }

    }
}
