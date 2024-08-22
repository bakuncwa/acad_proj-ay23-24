using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPRGG2_FXTIS1B_MMP_ALMIROL_OCHOTORENA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnConPanel_Click(object sender, EventArgs e)
        {
            ContactsPanel newForm = new ContactsPanel();
            this.Hide();
            newForm.Show();
        }

        private void btnPwdSet_Click(object sender, EventArgs e)
        {
            Verification newForm = new Verification();
            this.Hide();
            newForm.Show();
        }
    }
}
