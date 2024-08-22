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
    public partial class Verification : Form
    {
        public Verification()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtCurrentPwd.Clear(); txtUsername.Clear();
            txtConfirmPwd.Clear(); txtNewPwd.Clear();
        }

        private BLL User = new BLL();

        private void Verification_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void pbxHomepage_Click(object sender, EventArgs e)
        {
            try
            {
                Menu newForm = new Menu();
                this.Hide();
                newForm.Show();
            }

            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Source + "\n" + exemp.Message);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                User.Username = txtUsername.Text;
                User.Password = txtNewPwd.Text;
                User.CurrentPassword = txtCurrentPwd.Text;



                User.loginEdit(txtCurrentPwd.Text);
                User.pwdScan(txtCurrentPwd.Text, txtNewPwd.Text, 
                    txtCurrentPwd.Text);
                pwdControls();

                //User.loginEdit(txtCurrentPwd.Text);

                Reset();
            }

            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Source + "\n" + exemp.Message);
            }
        }
        private void pwdControls()
        {
            // [Ext.] Confirm password length

            if (txtConfirmPwd.ToString().Length < 10 || txtConfirmPwd.ToString().Length > 50)
            {
                Exception exemp = new("Confirmed must be 10 to 100 characters only.");
                exemp.Source = "Settings";
                throw exemp;
            }

            // [Ext.] if new password != confirm password, error Must be the same

            if (!(txtNewPwd.Text == txtConfirmPwd.Text))
            {
                Exception exemp = new("Must confirm new password.");
                exemp.Source = "Settings";
                throw exemp;
            }
        }
    }
}
