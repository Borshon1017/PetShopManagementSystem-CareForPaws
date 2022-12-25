using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareForPaws
{
    public partial class EditInfoUC : UserControl
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
        private DataAccess Da { get; set; }

        public EditInfoUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }



        private void PopulateGridView(string sql = "select * from UserInfo where Role = 'Seller' and Status = 'Active';")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSeller.AutoGenerateColumns = false;
            this.dgvSeller.DataSource = ds.Tables[0];
        }

        private void SearchSellerUC_Load(object sender, EventArgs e)
        {
            this.dgvSeller.ClearSelection();
        }

        private void txtSearchByID_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchByID.Text == "Search By ID")
            {

                this.txtSearchByID.Text = "";
                this.txtSearchByID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSearchByID_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchByID.Text == "")
            {

                this.txtSearchByID.Text = "Search By ID";
                this.txtSearchByID.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
                this.PopulateGridView();


            }
        }

        private void txtSearchByUserName_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchByUserName.Text == "Search By Username")
            {

                this.txtSearchByUserName.Text = "";
                this.txtSearchByUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSearchByUserName_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchByUserName.Text == "")
            {

                this.txtSearchByUserName.Text = "Search By Username";
                this.txtSearchByUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
                this.PopulateGridView();

            }
        }

        private void txtSeachByName_Enter(object sender, EventArgs e)
        {
            if (this.txtSeachByName.Text == "Search By Full Name")
            {

                this.txtSeachByName.Text = "";
                this.txtSeachByName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSeachByName_Leave(object sender, EventArgs e)
        {
            if (this.txtSeachByName.Text == "")
            {

                this.txtSeachByName.Text = "Search By Full Name";
                this.txtSeachByName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
                this.PopulateGridView();

            }
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByID.Text != "Search By ID" || string.IsNullOrEmpty(txtSearchByID.Text) == false || string.IsNullOrWhiteSpace(txtSearchByID.Text) == false) {
                var sql = "select * from UserInfo where U_ID like '%" + this.txtSearchByID.Text + "%' and Role = 'Seller' and Status = 'Active';";
                this.PopulateGridView(sql);
            }
        }

        private void txtSearchByUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByUserName.Text != "Search By Username" || string.IsNullOrEmpty(txtSearchByUserName.Text) == false || string.IsNullOrWhiteSpace(txtSearchByUserName.Text) == false) {
                var sql = "select * from UserInfo where Username like '%" + this.txtSearchByUserName.Text + "%' and Role = 'Seller' and Status = 'Active';";
                this.PopulateGridView(sql);
            }
        }

        private void txtSeachByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSeachByName.Text != "Search By Full Name" || string.IsNullOrEmpty(txtSeachByName.Text) == false || string.IsNullOrWhiteSpace(txtSeachByName.Text) == false) {
                var sql = "select * from UserInfo where FullName like '%" + this.txtSeachByName.Text + "%' and Role = 'Seller' and Status = 'Active';";
                this.PopulateGridView(sql);
            }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSeller_DoubleClick(object sender, EventArgs e)
        {
            this.TurnOffReadOnly();
            this.txtID.Text = this.dgvSeller.CurrentRow.Cells["U_ID"].Value.ToString();
            this.txtID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFullName.Text = this.dgvSeller.CurrentRow.Cells["FullName"].Value.ToString();
            this.txtFullName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUserName.Text = this.dgvSeller.CurrentRow.Cells["Username"].Value.ToString();
            this.txtUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpDOB.Value = Convert.ToDateTime(this.dgvSeller.CurrentRow.Cells["DOB"].Value);
            this.dtpDOB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPhoneNumber.Text = this.dgvSeller.CurrentRow.Cells["Phone"].Value.ToString();
            this.txtPhoneNumber.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSalary.Text = this.dgvSeller.CurrentRow.Cells["Salary"].Value.ToString();
            this.txtSalary.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbGender.Text = this.dgvSeller.CurrentRow.Cells["Gender"].Value.ToString();
            this.cmbGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpJoiningDate.Value = Convert.ToDateTime(this.dgvSeller.CurrentRow.Cells["JoiningDate"].Value);
            this.dtpJoiningDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.Text = this.dgvSeller.CurrentRow.Cells["Password"].Value.ToString();
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void dgvSeller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtFullName.Text == "Full Name" || string.IsNullOrEmpty(txtFullName.Text) == true)
            {

                lblFullNameEmpty.Visible = true;

            }
            else
            {

                lblFullNameEmpty.Visible = false;
            }
            if (txtUserName.Text == "Username" || string.IsNullOrEmpty(txtUserName.Text) == true)
            {

                lblUsernameEmpty.Visible = true;
            }
            else
            {

                lblUsernameEmpty.Visible = false;
            }
            if (txtPhoneNumber.Text == "Phone Number" || string.IsNullOrEmpty(txtPhoneNumber.Text) == true)
            {
                lblPhoneNumberEmpty.Visible = true;


            }
            else
            {

                lblPhoneNumberEmpty.Visible = false;
            }
            if (txtSalary.Text == "Salary" || string.IsNullOrEmpty(txtSalary.Text) == true)
            {

                lblSalaryEmpty.Visible = true;

            }
            else
            {
                lblSalaryEmpty.Visible = false;
            }

            if (txtPassword.Text == "Password" || string.IsNullOrEmpty(txtPassword.Text) == true)
            {

                lblPasswordError.Visible = true;

            }
            
            else
            {

                lblPasswordError.Visible = false;
            }
            if (string.IsNullOrEmpty(cmbGender.Text))
            {
                lblGender.Visible = true;
            }
            else
            {
                lblGender.Visible = false;


            }

            //    if (dtpDOB.StateCommon.Content.Color1 == Color.Gray || string.IsNullOrEmpty(dtpDOB.Text) == true)
            //   {

            //      lblDOBerror.Visible = true;

            //   }
            //    else
            //  {

            //       lblDOBerror.Visible = false;
            //  }
            // if (dtpJoiningDate.StateCommon.Content.Color1 == Color.Gray || string.IsNullOrEmpty(dtpJoiningDate.Text) == true)
            //  {

            //      lblDOBerror.Visible = true;
            //
            //        }
            //       else
            //       {

            //         lblDOBerror.Visible = false;
            //     }


            //UserName Conflict Check
            var sql = "select * from UserInfo where username = '" + txtUserName + "' and Status = 'Active';";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                lblUsernameEmpty.Visible = true;
                new ConfirmationError("Username already exists", 15, 17).Show();
                return;

            }
            if (lblFullNameEmpty.Visible == true || lblUsernameEmpty.Visible == true || lblPhoneNumberEmpty.Visible == true || lblSalaryEmpty.Visible == true || lblPasswordError.Visible == true || lblJoiningDate.Visible == true || lblDOBerror.Visible == true || lblGender.Visible == true)
            {
                return;
            }

            if (txtPassword.Text.Length < 4)
            {

                lblPasswordError.Visible = true;
                new ConfirmationError().Show();
                return;
            }
            else
            {
                lblPasswordError.Visible = false;

            }
            //if (txtPhoneNumber.Text.Length != 14)
            //{
            //    lblPhoneNumberEmpty.Visible = true;
            //    new ComfirmationError("Invalid Phone Number", 70, 19).Show();
            //}
            //else
            //{
            //    lblPhoneNumberEmpty.Visible = false;
            //}
            if (lblFullNameEmpty.Visible == true || lblUsernameEmpty.Visible == true || lblPhoneNumberEmpty.Visible == true || lblSalaryEmpty.Visible == true || lblPasswordError.Visible == true || lblJoiningDate.Visible == true || lblDOBerror.Visible == true || lblGender.Visible == true)
            {
                return;
            }



            var query = "select * from UserInfo where U_ID = '" + this.txtID.Text + "' and Status = 'Active';";
            ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                 sql = @"update UserInfo
                                set FullName = '" + this.txtFullName.Text + @"',
                                Username = '" + this.txtUserName.Text + @"',
                                Password = '" + this.txtPassword.Text + @"',
                                DOB = '" + this.dtpDOB.Text + @"',
                                Phone = '" + this.txtPhoneNumber.Text + @"',
                                Gender = '" + this.cmbGender.Text + @"',
                                Salary = " + this.txtSalary.Text + @",
                                JoiningDate = '" + this.dtpJoiningDate.Text + @"'
                                where U_ID = '" + this.txtID.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data updated properly");
                else
                    MessageBox.Show("Data upgradation failed");
            }

            this.PopulateGridView();
        }

        private void TurnOffReadOnly() {

            txtUserName.ReadOnly = false;
            txtFullName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtSalary.ReadOnly = false;

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInvalidLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "ID";
            this.txtID.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            txtFullName.Text = "Full Name";
            this.txtFullName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
           
            txtSalary.Text = "Salary";
            this.txtSalary.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            txtPassword.Text = "Password";
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            txtPhoneNumber.Text = "Phone Number";
            this.txtPhoneNumber.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            txtUserName.Text = "Username";
            this.txtUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
        }
    }
}
