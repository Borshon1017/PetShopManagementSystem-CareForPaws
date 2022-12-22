using Guna.UI2.WinForms.Suite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareForPaws
{
    public partial class AddSellerUC : UserControl
    {
        public int totalFilled=0;
        private DataAccess Da { get; set; }
        public AddSellerUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
              
            if(String.IsNullOrEmpty(txtFullName.Text)==false)
            {
                btnAddSeller.Enabled = true;
            }


        }




        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpSellerDOB_ValueChanged(object sender, EventArgs e)
        {

        }


        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            string UID = "U-" + this.AutoId();
            string fullName = txtFullName.Text;
            string userName = txtUserName.Text;

            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string reenterpassword = txtConfirmPassword.Text;
            string gender = "null";
            string role = "seller";
            string salary = txtSalary.Text;
            if (rdbFemale.Checked == true)
            {
                gender = "Female";
            }
            else if (rdbMale.Checked == true)
            {
                gender = "Male";
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                icoCrossPassword.Visible = true;
                lblPasswordError.Visible = true;
                return;

            }
            else
            {
                icoCrossPassword.Visible = false;
                lblPasswordError.Visible = false;
            }
            if (txtPassword.Text.Length < 4 ||  txtConfirmPassword.Text.Length <4)
                    {

                icoCrossPassword.Visible = true;
                lblPasswordLength.Visible = true;

            }
            else
            {
                icoCrossPassword.Visible = false;
                lblPasswordLength.Visible = false;

            }    

                var sql = "select * from UserInfo where username = '"+userName+"';";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                icoCrossUsername.Visible = true;
                lblUsernameError.Visible = true;
                return;

            }
            else
            {
                icoCrossUsername.Visible = false;
                lblUsernameError.Visible = false;
            }






            string dateofbirth = dtpSellerDOB.Value.ToString();
            string joiningdate = dtpJoiningDate.Value.ToString();


            sql = "insert into UserInfo values ('" + UID + "', '" + fullName + "', '" + userName + "', '" + password + "', '" + dateofbirth + "', '" + phoneNumber + "', '" + gender + "', '" + role + "', " + salary + ", '" + joiningdate + "', 'Active')  ;";
            ds = this.Da.ExecuteQuery(sql);
            DialogResult res = MessageBox.Show("Account added sucessfully", "Ok", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
        private string AutoId()
        {
            var dt = Da.ExecuteQueryTable(@"Select * from UserInfo order by U_ID Desc;");
            string lastId = dt.Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            return (++newIdNum).ToString("d3");
        }


        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (this.txtFullName.Text == "Full Name")
            {

                this.txtFullName.Text = "";
                this.txtFullName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (this.txtFullName.Text == "")
            {

                this.txtFullName.Text = "Full Name";
                this.txtFullName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == "Username")
            {

                this.txtUserName.Text = "";
                this.txtUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == "")
            {

                this.txtUserName.Text = "Username";
                this.txtUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (this.txtPhoneNumber.Text == "Phone Number")
            {

                this.txtPhoneNumber.Text = "";
                this.txtPhoneNumber.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (this.txtPhoneNumber.Text == "")
            {

                this.txtPhoneNumber.Text = "Phone Number";
                this.txtPhoneNumber.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Password")
            {

                this.txtPassword.Text = "";
                this.txtPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {

                this.txtPassword.Text = "Password";
                this.txtPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtConfirmPassword.Text == "Confirm Password")
            {

                this.txtConfirmPassword.Text = "";
                this.txtConfirmPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtConfirmPassword.Text == "")
            {

                this.txtConfirmPassword.Text = "Confirm Password";
                this.txtConfirmPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            if (this.txtSalary.Text == "Salary")
            {

                this.txtSalary.Text = "";
                this.txtSalary.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            if (this.txtSalary.Text == "")
            {

                this.txtSalary.Text = "Salary";
                this.txtSalary.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtFullName_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string test = DateTime.ParseExact(dtpSellerDOB.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtConfirmPassword.Clear();
            txtSalary.Clear();
            txtPassword.Clear();
            txtPhoneNumber.Clear();
            txtUserName.Clear();
            dtpJoiningDate.Value = DateTime.Today;
            dtpSellerDOB.Value = DateTime.Today;
            rdbFemale.Checked = false;
            rdbMale.Checked = false;

        }

        private void lblPasswordError_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
