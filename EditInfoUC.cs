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

        private DataAccess Da { get; set; }

        public EditInfoUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }



        private void PopulateGridView(string sql = "select * from UserInfo where Role = 'Seller';")
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
                var sql = "select * from UserInfo where U_ID like '%" + this.txtSearchByID.Text + "%' and Role = 'Seller';";
                this.PopulateGridView(sql);
            }
        }

        private void txtSearchByUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByUserName.Text != "Search By Username" || string.IsNullOrEmpty(txtSearchByUserName.Text) == false || string.IsNullOrWhiteSpace(txtSearchByUserName.Text) == false) {
                var sql = "select * from UserInfo where Username like '%" + this.txtSearchByUserName.Text + "%' and Role = 'Seller';";
                this.PopulateGridView(sql);
            }
        }

        private void txtSeachByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSeachByName.Text != "Search By Full Name" || string.IsNullOrEmpty(txtSeachByName.Text) == false || string.IsNullOrWhiteSpace(txtSeachByName.Text) == false) {
                var sql = "select * from UserInfo where FullName like '%" + this.txtSeachByName.Text + "%' and Role = 'Seller';";
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
            this.txtUsername.Text = this.dgvSeller.CurrentRow.Cells["Username"].Value.ToString();
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpDOB.Value = Convert.ToDateTime(this.dgvSeller.CurrentRow.Cells["DOB"].Value);
            this.dtpDOB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPhone.Text = this.dgvSeller.CurrentRow.Cells["Phone"].Value.ToString();
            this.txtPhone.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
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
            var query = "select * from UserInfo where U_ID = '" + this.txtID.Text + "';";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                var sql = @"update UserInfo
                                set FullName = '" + this.txtFullName.Text + @"',
                                Username = '" + this.txtUsername.Text + @"',
                                Password = '" + this.txtPassword.Text + @"',
                                DOB = '" + this.dtpDOB.Text + @"',
                                Phone = '" + this.txtPhone.Text + @"',
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

            txtUsername.ReadOnly = false;
            txtFullName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtSalary.ReadOnly = false;

        }

    }
}
