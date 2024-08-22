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
    public partial class ContactsPanel : Form
    {
        public ContactsPanel()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtContactID.Clear(); txtContactName.Clear(); txtContactNo.Clear();
            btnView_Click(this, new());
        }

        private BLL Customer = new BLL();

        private int CID = 0;

        private void ContactsPanel_Load(object sender, EventArgs e)
        {
            Reset();
            btnView_Click(this, new());
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CID = (int)dgv.SelectedRows[0].Cells[0].Value;
            txtContactID.Text = CID.ToString();
            txtContactName.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtContactNo.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void pbxHomepage_Click(object sender, EventArgs e)
        {
            Menu newForm = new Menu();
            this.Hide();
            newForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer.contactAdd(int.Parse(txtContactID.Text), txtContactName.Text,
                    txtContactNo.Text);

                MessageBox.Show("Customer contact information added successfully!");

                Reset();

                btnView_Click(this, new());
            }
            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Source + "\n" + exemp.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Customer.contactEdit(int.Parse(txtContactID.Text), txtContactName.Text,
                    txtContactNo.Text, CID);

                Reset();

                MessageBox.Show("Customer contact information edited successfully!");

                btnView_Click(this, new());
            }

            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Source + "\n" + exemp.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Customer.contactDelete(int.Parse(txtContactID.Text));

                Reset();

                MessageBox.Show("Customer contact information deleted successfully!");

                btnView_Click(this, new());
            }

            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Source + "\n" + exemp.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Customer.reflectContactsTable();
        }

        private void txtContactID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtContactID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a valid Contact ID number.");
                txtContactID.Text = txtContactID.Text.Remove(txtContactID.Text.Length - 1);
            }
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtContactNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a valid Contact Number.");
                txtContactNo.Text = txtContactNo.Text.Remove(txtContactNo.Text.Length - 1);
            }
        }
    }
}
