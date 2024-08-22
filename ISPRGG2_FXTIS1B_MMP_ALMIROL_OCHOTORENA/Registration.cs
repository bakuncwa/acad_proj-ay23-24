using BusinessLogic;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtUsername.Clear(); txtPwd.Clear();
        }

        private BLL User = new BLL();

        private void pbxHomepage_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 newForm = new Form1();
                this.Hide();
                newForm.Show();
            }

            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Source + "\n" + exemp.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User.Username = txtUsername.Text;
                User.Password = txtPwd.Text;
                User.userRegValid(txtUsername.Text);
            }
            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Source + "\n" + exemp.Message);
            }
        }

        private void cboxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShowPwd.Checked)
            {
                txtPwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtPwd.UseSystemPasswordChar = true;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
