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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CareForPaws
{
    public partial class AddSellerUC : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
        public int totalFilled = 0;
        private DataAccess Da { get; set; }
        public AddSellerUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            if (String.IsNullOrEmpty(txtFullName.Text) == false)
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

            string phoneNumber = "+880" + txtPhoneNumber.Text;
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
            string dateofbirth = dtpSellerDOB.Value.ToString();
            string joiningdate = dtpJoiningDate.Value.ToString();


            //Exceptions
            if (txtFullName.StateCommon.Content.Color1 == Color.Gray || string.IsNullOrEmpty(txtFullName.Text) == true)
            {

                lblFullNameEmpty.Visible = true;
                
            }
            else
            {

                lblFullNameEmpty.Visible = false;
            }
            if (txtUserName.StateCommon.Content.Color1 == Color.Gray || string.IsNullOrEmpty(txtUserName.Text) == true)
            {

                lblUsernameEmpty.Visible= true;
            }
            else
            {

                lblUsernameEmpty.Visible =false;
            }
            if (txtPhoneNumber.StateCommon.Content.Color1 == Color.Gray || string.IsNullOrEmpty(txtPhoneNumber.Text) == true)
            {
                lblPhoneNumberEmpty.Visible= true;


            }
            else
            {

                lblPhoneNumberEmpty.Visible = false;
            }
            if (txtSalary.StateCommon.Content.Color1 == Color.Gray || string.IsNullOrEmpty(txtSalary.Text) == true)
            {

                lblSalaryEmpty.Visible = true;

            }
            else
            {

                lblSalaryEmpty.Visible = false;
            }

            if (txtPassword.StateCommon.Content.Color1 == Color.Gray || string.IsNullOrEmpty(txtPassword.Text) == true)
            {

                lblPasswordError.Visible = true;

            }
            else
            {

                lblPasswordError.Visible = false;
            }
            if (txtConfirmPassword.StateCommon.Content.Color1 == Color.Gray || string.IsNullOrEmpty(txtConfirmPassword.Text) == true)
            {

                lblComfirmPasswordError.Visible = true;

            }
            else
            {

                lblComfirmPasswordError.Visible = false;
            }








            //Username Existance Check

            var sql = "select * from UserInfo where username = '" + userName + "';";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                lblUsernameEmpty.Visible = true;
                new ComfirmationError("Username already exists", 15, 17).Show();

            }
           

            if (lblFullNameEmpty.Visible == true || lblUsernameEmpty.Visible == true || lblPhoneNumberEmpty.Visible == true || lblSalaryEmpty.Visible == true || lblPasswordError.Visible == true || lblComfirmPasswordError.Visible == true)
            {
                return;
            }


            //Error Message Exceptions
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblPasswordError.Visible = true;

                new ComfirmationError("Password Mismatch", 68, 17).Show();
                return;

            }

            else
            {
                lblPasswordError.Visible = false;
            }
            if (txtPassword.Text.Length < 4 || txtConfirmPassword.Text.Length < 4)
            {

                lblPasswordError.Visible = true;
                new ComfirmationError().Show();
                return;
            }
            else
            {
                lblPasswordError.Visible = false;

            }
            if (txtPhoneNumber.Text.Length != 11)
            {
                lblPhoneNumberEmpty.Visible = true;
                new ComfirmationError("Invalid Phone Number", 70, 19).Show();
                return;
            }
            else
            {
                lblPhoneNumberEmpty.Visible = false;
            }
            if (lblFullNameEmpty.Visible == true || lblUsernameEmpty.Visible == true || lblPhoneNumberEmpty.Visible == true || lblSalaryEmpty.Visible == true || lblPasswordError.Visible == true || lblComfirmPasswordError.Visible == true)
            {
                return;
            }



            //Seller Add SQL

            sql = "insert into UserInfo values ('" + UID + "', '" + fullName + "', '" + userName + "', '" + password + "', '" + dateofbirth + "', '" + phoneNumber + "', '" + gender + "', '" + role + "', " + salary + ", '" + joiningdate + "', 'Active')  ;";
            ds = this.Da.ExecuteQuery(sql);

            new ComfirmationDone("Seller Added Sucessfully",38, 369).Show();
            

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
            lblFullNameEmpty.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string test = DateTime.ParseExact(dtpSellerDOB.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            lblSalaryEmpty.Visible = false;
        }
        //Clear All
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "Full Name";
            this.txtFullName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            txtConfirmPassword.Text = "Confirm Password";
            this.txtConfirmPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            txtSalary.Text = "Salary";
            this.txtSalary.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            txtPassword.Text = "Password";
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            txtPhoneNumber.Text = "Phone Number";
            this.txtPhoneNumber.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            txtUserName.Text = "Username";
            this.txtUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            //dtpJoiningDate.Value = DateTime.Today.AddDays(-1);
            //dtpSellerDOB.Value = DateTime.Today.AddDays(-1);
            rdbFemale.Checked = false;
            rdbMale.Checked = false;

        }
        private void txtbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void lblPasswordError_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswordError.Visible = false;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            lblComfirmPasswordError.Visible = false;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            lblPhoneNumberEmpty.Visible = false;
        }

        private void lblSalaryEmpty_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lblPasswordLength_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblUsernameEmpty.Visible = false;
        }

        private void lblFullNameEmpty_Click(object sender, EventArgs e)
        {

        }
    }
}
