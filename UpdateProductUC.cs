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
    
    public partial class UpdateProductUC : UserControl
    {
        public static bool updateProductConfirmation;
        private DataAccess Da { get; set; }
        public UpdateProductUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from ProductInfo, CategoryInfo where ProductInfo.C_ID = CategoryInfo.C_ID;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
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

        private void txtSearchByProductName_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchByProductName.Text == "Search By Product Name")
            {

                this.txtSearchByProductName.Text = "";
                this.txtSearchByProductName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSearchByProductName_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchByProductName.Text == "")
            {

                this.txtSearchByProductName.Text = "Search By Product Name";
                this.txtSearchByProductName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
                this.PopulateGridView();


            }
        }

        private void txtProductName_Enter(object sender, EventArgs e)
        {
            if (this.txtProductName.Text == "Product Name")
            {

                this.txtProductName.Text = "";
                this.txtProductName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (this.txtProductName.Text == "")
            {

                this.txtProductName.Text = "Product Name";
                this.txtProductName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtBrand_Enter(object sender, EventArgs e)
        {
            if (this.txtBrand.Text == "Brand")
            {

                this.txtBrand.Text = "";
                this.txtBrand.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtBrand_Leave(object sender, EventArgs e)
        {
            if (this.txtBrand.Text == "")
            {

                this.txtBrand.Text = "Brand";
                this.txtBrand.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (this.txtQuantity.Text == "Quantity")
            {

                this.txtQuantity.Text = "";
                this.txtQuantity.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (this.txtQuantity.Text == "")
            {

                this.txtQuantity.Text = "Quantity";
                this.txtQuantity.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtBrand.Text == "Brand" || string.IsNullOrEmpty(txtBrand.Text) == true)
            {
                lblBrandEmpty.Visible = true;
            }
            else
            {
                lblBrandEmpty.Visible = false;
            }
            if (txtQuantity.Text == "Quantity" || string.IsNullOrEmpty(txtQuantity.Text) == true)
            {
                lblQuantityEmpty.Visible = true;
            }
            else
            {
                lblQuantityEmpty.Visible = false;
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                lblCategoryEmpty.Visible = true;
            }
            else
            {
                lblCategoryEmpty.Visible = false;
            }

            

            if (lblBrandEmpty.Visible == true || lblCategoryEmpty.Visible == true || lblQuantityEmpty.Visible == true)
            {
                return;
            }

            var query = "select * from ProductInfo, CategoryInfo where P_ID = '" + this.txtID.Text + "';";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count >= 1)
            {
                var q = "select C_ID from CategoryInfo where CategoryName = '" + this.cmbCategory.Text + "';";
                var d = this.Da.ExecuteQuery(q);
                string cID = d.Tables[0].Rows[0][0].ToString();
                var sql = @"update ProductInfo
                                set Brand = '" + this.txtBrand.Text + @"',
                                C_ID = '" + cID + @"',
                                Quantity = " + this.txtQuantity.Text + @"
                                where P_ID = '" + this.txtID.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count >= 1)
                    new ConfirmationDone("Data added Sucessfully", 51, 374).Show();
                else
                    MessageBox.Show("Data upgradation failed");
            }

            this.PopulateGridView();
        }

        private void UpdateProductUC_Load(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByID.Text != "Search By ID" || string.IsNullOrEmpty(txtSearchByID.Text) == false || string.IsNullOrWhiteSpace(txtSearchByID.Text) == false)
            {
                var sql = "select * from ProductInfo where P_ID like '%" + this.txtSearchByID.Text + "%';";
                this.PopulateGridView(sql);
            }
        }

        private void txtSearchByProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByProductName.Text != "Search By ProductName" || string.IsNullOrEmpty(txtSearchByProductName.Text) == false || string.IsNullOrWhiteSpace(txtSearchByProductName.Text) == false)
            {
                var sql = "select * from ProductInfo where ProductName like '%" + this.txtSearchByProductName.Text + "%';";
                this.PopulateGridView(sql);
            }
        }

        private void PopulatecmbCategory()
        {
            cmbCategory.Items.Clear();
            try
            {
                var sql = $@"select distinct(CategoryName) from CategoryInfo;";
                var dt = Da.ExecuteQueryTable(sql);
                int index = 0;
                while (index < dt.Rows.Count)
                {
                    this.cmbCategory.Items.Add(dt.Rows[index][0]);
                    index++;
                }
                this.cmbCategory.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
            }
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvProduct.SelectedRows.Count == 0) { return;  }
            this.PopulatecmbCategory();
            this.txtBrand.ReadOnly = false;
            this.txtQuantity.ReadOnly = false;
            this.txtID.Text = this.dgvProduct.CurrentRow.Cells["P_ID"].Value.ToString();
            this.txtID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBrand.Text = this.dgvProduct.CurrentRow.Cells["Brand"].Value.ToString();
            this.txtBrand.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtProductName.Text = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            this.txtProductName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells["Quantity"].Value.ToString();
            this.txtQuantity.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbCategory.Text = this.dgvProduct.CurrentRow.Cells["CategoryName"].Value.ToString();
            this.cmbCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
               {
                    e.Handled = true;
               }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.Columns[e.ColumnIndex].Name.Equals("DeleteButton"))
            {
                var sql = "delete from ProductInfo where P_ID  = '" + this.dgvProduct.CurrentRow.Cells["P_ID"].Value.ToString() + "';";
                this.Da.ExecuteDMLQuery(sql);
                this.PopulateGridView();
            }
        }

        private void addSellerUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
