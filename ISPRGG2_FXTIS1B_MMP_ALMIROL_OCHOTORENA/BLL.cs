using DataAccess;
using ISPRGG2_FXTIS1B_MMP_ALMIROL_OCHOTORENA;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using MMP.ConnectionSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLL
    {
        public int ContactID { get; set; }
        public string ContactNo { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string CurrentPassword { get; set; } = string.Empty;





        private DAL dataAccessObj = new(connectionStrings.onlineConnect);


        public void loginAdd()

        {
            this.logValidate();

            dataAccessObj.SetSql("INSERT INTO Logins VALUES " +
                "(@lid, @lpwd)");
            dataAccessObj.addParameters("@lid", this.Username);
            dataAccessObj.addParameters("@lpwd", this.Password);

            dataAccessObj.Execute(true);


        }

        public void loginAdd(string userID, string userPwd)
        {
            this.Username = userID;
            this.Password = userPwd;

            this.loginAdd(userID, userPwd);
        }

        public void loginEdit(string olduserPwd)
        {
            this.pwdValidate();

            dataAccessObj.SetSql("UPDATE Logins SET " +
                "Password = @nlpwd WHERE Username = @lid");
            dataAccessObj.addParameters("@nlpwd", this.Password);
            dataAccessObj.addParameters("@lid", this.Username);
            dataAccessObj.addParameters("@olpwd", olduserPwd);

            dataAccessObj.Execute(true);

        }

        public void loginEdit(string newuserPwd, string userID, string olduserPwd)
        {
            this.Password = newuserPwd;
            this.Username = userID;
            this.CurrentPassword = olduserPwd;


            this.loginEdit(olduserPwd);
        }

        public DataTable reflectContactsTable()
        {
            dataAccessObj.SetSql("SELECT * FROM Contacts");
            return dataAccessObj.retrieveData(true);
        }

        public void contactAdd()
        {
            this.conValidate();

            dataAccessObj.SetSql("INSERT INTO Contacts VALUES " +
                "(@cid, @cname, @cno)");
            dataAccessObj.addParameters("@cid", this.ContactID);
            dataAccessObj.addParameters("@cname", this.Name);
            dataAccessObj.addParameters("@cno", this.ContactNo);

            dataAccessObj.Execute(true);
        }

        public void contactAdd(int contactID, string contactName, string contactNo)
        {
            this.ContactID = contactID;
            this.Name = contactName;
            this.ContactNo = contactNo;

            this.contactAdd();
        }


        public void contactDelete()
        {
            dataAccessObj.SetSql("DELETE Contacts WHERE ContactID = @cid");
            dataAccessObj.addParameters("@cid", this.ContactID);
            dataAccessObj.Execute(true);
        }

        public void contactDelete(int contactID)
        {
            this.ContactID = contactID;
            this.contactDelete();
        }


        public void contactEdit(int oldcontactID)
        {
            this.conValidate();

            dataAccessObj.SetSql("UPDATE Contacts SET ContactID = @ncid," +
                " Name = @ncname, ContactNo = @ncno WHERE ContactID = @oid");
            dataAccessObj.addParameters("@ncid", this.ContactID);
            dataAccessObj.addParameters("@ncname", this.Name);
            dataAccessObj.addParameters("@ncno", this.ContactNo);
            dataAccessObj.addParameters("@oid", oldcontactID);

            dataAccessObj.Execute(true);
        }

        public void contactEdit(int newcontactID, string newcontactName,
            string newContactNo, int oldcontactID)
        {
            this.ContactID = newcontactID;
            this.ContactNo = newContactNo;
            this.Name = newcontactName;
            this.ContactID = oldcontactID;

            this.contactEdit(oldcontactID);
        }

        public void conValidate()
        {

            // [Ext.] If Null Input

            if (this.ContactID.ToString().IsNullOrEmpty() || this.ContactNo.ToString().IsNullOrEmpty())
            {
                Exception exemp = new Exception("Contact details cannot be empty.");
                exemp.Source = "Contacts";
                throw exemp;
            }

            // Ensure that the ContactID is exactly 7 digits

            //if (!(this.ContactID < 1000000 || this.ContactID > 9999999))
            //if (!(this.ContactID.ToString().Length == 7))

            //int cidLen = Convert.ToInt32(Convert.ToString(this.ContactID).Substring(0, 8));
            //if (cidLen!= 7)
            if (this.ContactID < 1000000 || this.ContactID > 9999999)
            {
                Exception exemp = new Exception("Contact ID must be a 7 digit number.");
                exemp.Source = "Contacts";
                throw exemp;
            }

            // Ensure that the Name of the Contact is from 5-100 characters only

            if (this.Name.ToString().Length < 5 || this.Name.ToString().Length > 100)
            {
                Exception exemp = new("Contact name must be 5 to 100 characters only.");
                exemp.Source = "Contacts";
                throw exemp;
            }

            // Ensure that the ContactNo is either 7 or 11 digits only

            if (!(this.ContactNo.Length == 7 || this.ContactNo.Length == 11))
            {
                Exception exemp = new Exception("Contact No must be exactly 7 or 11 digits only.");
                exemp.Source = "Contacts";
                throw exemp;
            }

        }

        public void logValidate()

        {

            // [Ext.] If Null Input - WORKS

            if (this.Username.ToString().IsNullOrEmpty() || this.Password.ToString().IsNullOrEmpty())
            {
                Exception exemp = new Exception("Login details field cannot be empty.");
                exemp.Source = "Logins";
                throw exemp;
            }

            // [Ext.] Ensure that Username is composed of 5-25 characters only - WORKS

            if (this.Username.ToString().Length < 5 || this.Username.ToString().Length > 25)
            {
                Exception exemp = new("Login username must be 5 to 50 characters only.");
                exemp.Source = "Logins";
                throw exemp;
            }

            // [Ext.] Ensure that Password is composed of 10-50 characters only - WORKS

            if (this.Password.ToString().Length < 10 || this.Password.ToString().Length > 50)
            {
                Exception exemp = new("Login password must be 10 to 100 characters only.");
                exemp.Source = "Logins";
                throw exemp;
            }

        }

        public void veriValidate()

        {

            // [Ext.] If Null Input - WORKS

            if (this.Username.ToString().IsNullOrEmpty())
            {
                Exception exemp = new Exception("Username field cannot be empty.");
                exemp.Source = "Settings";
                throw exemp;
            }

            // [Ext.] Ensure that Username is composed of 5-50 characters only - WORKS

            if (this.Username.ToString().Length < 5 || this.Username.ToString().Length > 50)
            {
                Exception exemp = new("Existing username must be 5 to 50 characters only.");
                exemp.Source = "Settings";
                throw exemp;
            }

        }


        public void pwdValidate()
        {
            // [Ext.] If Null Input
            if (this.Password.IsNullOrEmpty() || this.CurrentPassword.IsNullOrEmpty())
            {
                Exception exemp = new Exception("Password field cannot be empty.");
                exemp.Source = "Settings";
                throw exemp;
            }

            // [Ext.] Ensure that Password is composed of 10-50 characters only

            if (this.Password.Length < 10 || this.Password.Length > 50)
            {
                Exception exemp = new("New password must be 10 to 50 characters only.");
                exemp.Source = "Settings";
                throw exemp;
            }

            // [Ext.] Ensure that Password is composed of 10-50 characters only

            if (this.CurrentPassword.Length < 10 || this.CurrentPassword.Length > 50)
            {
                Exception exemp = new("Current password must be 10 to 50 characters only.");
                exemp.Source = "Settings";
                throw exemp;
            }


        }


        public DataTable reflectLoginsTable()
        {
            dataAccessObj.SetSql("SELECT Username, Password FROM Logins WHERE " +
                "Username = @exid AND Password = @expwd");
            dataAccessObj.addParameters("@exid", this.Username);
            dataAccessObj.addParameters("@expwd", this.Password);

            dataAccessObj.Execute(true);

            return dataAccessObj.retrieveData(true);
        }

        public void logExist(string existUserID, string existUserPwd)
        {

            if (reflectLoginsTable().Rows.Count > 0)
            {
                this.Username = existUserID;
                this.Password = existUserPwd;

                MessageBox.Show("Login successful! \nRedirecting . . . ");

                Menu newForm = new Menu();
                newForm.Show();

            }

            else
            {
                MessageBox.Show("Invalid login credentials. \nPlease try again.");
            }
        }

        public void logVerify(string existUserID, string existUserPwd)
        {

            if (reflectLoginsTable().Rows.Count > 0)
            {
                this.Username = existUserID;
                this.Password = existUserPwd;

                MessageBox.Show("Login successful! \nRedirecting . . . ");

                Menu newForm = new Menu();
                newForm.Show();

            }

            else
            {
                MessageBox.Show("Invalid login credentials. \nPlease try again.");
            }
        }




        public DataTable readPwdRow()
        {
            dataAccessObj.SetSql("SELECT Password FROM Logins " +
                "WHERE Password = @expwd");
            //dataAccessObj.addParameters("@exid", this.Username);
            dataAccessObj.addParameters("@expwd", this.CurrentPassword);
            dataAccessObj.addParameters("@nwpwd", this.Password);


            dataAccessObj.Execute(true);

            return dataAccessObj.retrieveData(true);
        }


        public void pwdScan(string existUserPwd, string newUserPwd, string matchUserPwd)
        {
            try
            {
                if (readPwdRow().Rows.Count > 0 && (this.CurrentPassword == this.Password))
                {
                    this.CurrentPassword = existUserPwd;
                    this.Password = newUserPwd;

                    MessageBox.Show("New password must not be the same as the previous password.");
                }
                else if (readPwdRow().Rows.Count > 0 && (!(this.CurrentPassword == this.CurrentPassword)))
                {
                    this.CurrentPassword = existUserPwd;
                    this.CurrentPassword = matchUserPwd;

                    MessageBox.Show("Current password is incorrect.");
                }
                //else if (readPwdRow().Rows.Count > 0 && (!(this.CurrentPassword != null && this.Username != null) ))
                //{
                //    this.CurrentPassword=existUserPwd;
                //    this.Username = existUsername;

                //    MessageBox.Show("Username and password must exist.");
                //}
                //this.Username = existUserID;
                //if (reflectUsersRow().Rows.Count > 0 && (!(this.Username == existUserID)))
                //{
                //    //this.Username = existUserID;

                //    MessageBox.Show("Username was not inputted correctly.");

                //}
                else
                {
                    this.veriValidate();
                    this.pwdValidate();
                    this.loginEdit(this.CurrentPassword);
                    MessageBox.Show("Updated password successfully!");

                    Menu newForm = new Menu();
                    newForm.Show();
                }

            }
            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Message + "\n" + exemp.Source);
            }
        }



        public DataTable reflectUsersRow()
        {
            dataAccessObj.SetSql("SELECT Username FROM Logins WHERE " +
                "Username = @exid");
            dataAccessObj.addParameters("@exid", this.Username);

            dataAccessObj.Execute(true);

            return dataAccessObj.retrieveData(true);
        }

        public void userRegValid(string existUserID)
        {
            try
            {
                if (reflectUsersRow().Rows.Count > 0)
                {
                    this.Username = existUserID;

                    MessageBox.Show("Username already exists.\n Please choose another username. ");

                }

                else
                {
                    this.loginAdd();
                    MessageBox.Show("Added admin user successfully!");
                    Form1 newForm = new Form1();
                    newForm.Show();
                }
            }
            catch (Exception exemp)
            {
                MessageBox.Show(exemp.Message + "\n" + exemp.Source);
            }
        }

    }
}


