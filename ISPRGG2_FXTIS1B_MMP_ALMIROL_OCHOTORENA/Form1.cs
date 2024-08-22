using BusinessLogic;

namespace ISPRGG2_FXTIS1B_MMP_ALMIROL_OCHOTORENA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtUsername.Clear(); txtPwd.Clear();
        }

        private BLL User = new BLL();

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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                User.Username = txtUsername.Text;
                User.Password = txtPwd.Text;

                User.logExist(txtUsername.Text, txtPwd.Text);
            }
            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Source + "\n" + exemp.Message);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                Registration newForm = new Registration();
                this.Hide();
                newForm.Show();
            }

            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Source + "\n" + exemp.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }
    }
}