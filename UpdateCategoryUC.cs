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
    public partial class UpdateCategoryUC : UserControl
    {
        private DataAccess Da { get; set; }
        public UpdateCategoryUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from CategoryInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.DataSource = ds.Tables[0];
        }

        private void UpdateCategoryUC_Load(object sender, EventArgs e)
        {
            this.dgvCategory.ClearSelection();
        }

        private void txtSearchByID_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchByID.Text == "Search By ID")
            {

                this.txtSearchByID.Text = "";
                this.txtSearchByID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSearchByCategoryName_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchByCategoryName.Text == "Search By Category Name")
            {

                this.txtSearchByCategoryName.Text = "";
                this.txtSearchByCategoryName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

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

        private void txtSearchByCategoryName_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchByCategoryName.Text == "")
            {

                this.txtSearchByCategoryName.Text = "Search By Category Name";
                this.txtSearchByCategoryName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
                this.PopulateGridView();

            }
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByID.Text != "Search By ID" || string.IsNullOrEmpty(txtSearchByID.Text) == false || string.IsNullOrWhiteSpace(txtSearchByID.Text) == false)
            {
                var sql = "select * from CategoryInfo where C_ID like '%" + this.txtSearchByID.Text + "%';";
                this.PopulateGridView(sql);
            }
        }

        private void txtSearchByCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCategoryName.Text != "Search By Category Name" || string.IsNullOrEmpty(txtSearchByCategoryName.Text) == false || string.IsNullOrWhiteSpace(txtSearchByCategoryName.Text) == false)
            {
                var sql = "select * from CategoryInfo where CategoryName like '%" + this.txtSearchByCategoryName.Text + "%';";
                this.PopulateGridView(sql);
            }
        }

        private void dgvCategory_DoubleClick(object sender, EventArgs e)
        {
            this.txtCategoryName.ReadOnly = false;
            this.txtID.Text = this.dgvCategory.CurrentRow.Cells["C_ID"].Value.ToString();
            this.txtID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCategoryName.Text = this.dgvCategory.CurrentRow.Cells["CategoryName"].Value.ToString();
            this.txtCategoryName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "Category Name" || string.IsNullOrEmpty(txtCategoryName.Text) == true)
            {

                lblCategoryNameEmpty.Visible = true;

            }
            else
            {
                lblCategoryNameEmpty.Visible = false;
            }


            //CategoryName Conflict Check
            var sql = "select * from CategoryInfo where CategoryName = '" + this.txtCategoryName.Text + "';";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                lblCategoryNameEmpty.Visible = true;
                new ComfirmationError("Category already exists", 15, 17).Show();
                return;

            }
            if (lblCategoryNameEmpty.Visible == true)
            {
                return;
            }


            var query = "select * from CategoryInfo where C_ID = '" + this.txtID.Text + "';";
            ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update CategoryInfo
                                set CategoryName = '" + this.txtCategoryName.Text + @"'
                                where C_ID = '" + this.txtID.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data updated properly");
                else
                    MessageBox.Show("Data upgradation failed");
            }

            this.PopulateGridView();
        }

    }
}
