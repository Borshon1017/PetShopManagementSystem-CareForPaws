using System;
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
        private DataAccess Sa { get; set; }
        public AddSellerUC()
        {
            InitializeComponent();
            this.Sa = new DataAccess();
        }

        

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpSellerDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpSellerDOB.Text = "Select date of birth";
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            string UID = "U-005";
            string fullName = txtFullName.Text;
            string userName = txtUserName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string reenterpassword = txtConfirmPassword.Text;
            string gender ="null";
            string role = "seller";
            string salary = txtSalary.Text;
            if (rdbFemale.Checked == true)
            {
                gender = "Female";
            }
            else if (rdbMale.Checked== true)
            {
               gender= "Male";
            }
          

            string dateofbirth = DateTime.ParseExact(dtpSellerDOB.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string joiningdate = DateTime.ParseExact(dtpJoiningDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

            var sql = "insert into UserInfo values ('" + UID  + "', '" + fullName + "', '" + userName + "', '" + password + "', '" + dateofbirth + "', '" + phoneNumber + "', '" + gender + "', '" + role + "', '" + salary + "', '" + joiningdate + "', 'Active',  ;";
            var ds = this.Sa.ExecuteQuery(sql);

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
    }
}
