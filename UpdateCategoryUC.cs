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
        public static bool updateCategoryConfirmation;
        public static bool deleteCategoryConfirmation;
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
            if (this.dgvCategory.SelectedRows.Count == 0) { return; }
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


            var query = "select * from CategoryInfo where C_ID = '" + this.txtID.Text + "';";
            var ds = this.Da.ExecuteQuery(query);
            new ConfirmationAsk("Are you sure you want to update the following category?", 12, 309).ShowDialog();
            if (updateCategoryConfirmation == true)
            {

            }
            else
            {
                return;
            }

            if (ds.Tables[0].Rows.Count == 1)
            {
                var sql = @"update CategoryInfo
                                set CategoryName = '" + this.txtCategoryName.Text + @"'
                                where C_ID = '" + this.txtID.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    new ConfirmationDone("Data updated properly", 51, 374);
                    
                else
                    new ConfirmationError("Failed to update", 14, 12);
            }

            this.PopulateGridView();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategory.Columns[e.ColumnIndex].Name.Equals("DeleteButton"))
            {
                //
                new ConfirmationAsk("Are you sure you want to delete the following category?", 12, 309).ShowDialog();
                if (deleteCategoryConfirmation == true)
                {
                }
                else if (deleteCategoryConfirmation == false)
                {
                    return;
                }
                var sql = "delete from ProductInfo where C_ID = '" + this.dgvCategory.CurrentRow.Cells["C_ID"].Value.ToString() + "' ;";
                this.Da.ExecuteDMLQuery(sql);
                sql = "delete from CategoryInfo where C_ID = '" + this.dgvCategory.CurrentRow.Cells["C_ID"].Value.ToString() + "' ;";
                this.Da.ExecuteDMLQuery(sql);
                this.PopulateGridView();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
