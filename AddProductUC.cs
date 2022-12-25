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
    public partial class AddProductUC : UserControl
    {
        private DataAccess Da { get; set; }

        public AddProductUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulatecmbCategory();
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "Product Name" || string.IsNullOrEmpty(txtProductName.Text) == true)
            {
                lblProductNameEmpty.Visible = true;
            }
            else {
                lblProductNameEmpty.Visible = false;
            }
            if (txtBrand.Text == "Brand" || string.IsNullOrEmpty(txtBrand.Text) == true) {
                lblBrandEmpty.Visible = true;
            }
            else {
                lblBrandEmpty.Visible = false;
            }
            if (txtQuantity.Text == "Quantity" || string.IsNullOrEmpty(txtQuantity.Text) == true) {
                lblQuantityEmpty.Visible = true;
            }
            else {
                lblQuantityEmpty.Visible = false;
            }
            if (cmbCategory.SelectedIndex == -1) {
                lblCategoryEmpty.Visible = true;
            }
            else {
                lblCategoryEmpty.Visible = false;
            }

            if (lblProductNameEmpty.Visible == true || lblBrandEmpty.Visible == true || lblCategoryEmpty.Visible == true || lblQuantityEmpty.Visible == true)
            {
                return;
            }

            string PID = "P-" + this.AutoId();
            string productName = txtProductName.Text;
            string brand = this.txtBrand.Text;
            int quantity = Convert.ToInt32(this.txtQuantity.Text);
            string ctg = cmbCategory.Text;
            string[] ctgID = ctg.Split(' ');
            string category = ctgID[0];

            var sql = "select * from ProductInfo where ProductName = '" + productName + "';";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count >= 1)
            {
                lblProductNameEmpty.Visible = true;
                new ComfirmationError("Product already exists", 15, 17).Show();
                return;
            }


            sql = "insert into ProductInfo values ('" + PID + "', '" + productName + "', '" + brand + "', '" + category + "', " + quantity + ")  ;";
            ds = this.Da.ExecuteQuery(sql);

            new Comfirmation("Product Added Sucessfully", 38, 369).Show();


        }

        private string AutoId()
        {
            try
            {
                var dt = Da.ExecuteQueryTable(@"Select * from ProductInfo order by P_ID Desc;");
                string lastId = dt.Rows[0][0].ToString();
                string[] id = lastId.Split('-');
                int newIdNum = Convert.ToInt32(id[1]);
                return (++newIdNum).ToString("d3");
            }
            catch (IndexOutOfRangeException e)
            {
                var sql = "insert into ProductInfo values ('P-001', 'Bish', 'Maa Babar Dowa', 'C-010', 100);";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = Da.ExecuteQueryTable(@"Select * from ProductInfo order by P_ID Desc;");
                string lastId = dt.Rows[0][0].ToString();
                string[] id = lastId.Split('-');
                int newIdNum = Convert.ToInt32(id[1]);
                return (++newIdNum).ToString("d3");
            }

        }

        private void PopulatecmbCategory()
        {
            try
            {
                var sql = $@"select C_ID, CategoryName from CategoryInfo;";
                var dt = Da.ExecuteQueryTable(sql);
                int index = 0;
                while (index < dt.Rows.Count)
                {
                    this.cmbCategory.Items.Add(dt.Rows[index][0] + " " + dt.Rows[index][1]);
                    index++;
                }
                this.cmbCategory.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
