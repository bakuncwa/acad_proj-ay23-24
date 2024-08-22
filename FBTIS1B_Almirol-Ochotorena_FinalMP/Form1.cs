namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    public partial class formTitleScreen : Form
    {
        public formTitleScreen()
        {
            InitializeComponent();
        }

        private void picStart_Click(object sender, EventArgs e)
        {
            new PhantomOdyssey_Minigame2().ShowDialog();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?");
            
        }
    }
}
