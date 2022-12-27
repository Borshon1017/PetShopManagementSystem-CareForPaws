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
    public partial class CreateOrderUC : UserControl
    {

        private DataAccess Da { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        public CreateOrderUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public CreateOrderUC(string username, string password)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.Username = username;
            this.Password = password;
        }

        private void PopulateGridView(string sql = "select * from ProductInfo, CategoryInfo where ProductInfo.C_ID = CategoryInfo.C_ID;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        private void txtSearchByCategory_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchByCategory.Text == "Search By Category")
            {

                this.txtSearchByCategory.Text = "";
                this.txtSearchByCategory.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSearchByCategory_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchByCategory.Text == "")
            {

                this.txtSearchByCategory.Text = "Search By Category";
                this.txtSearchByCategory.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvProduct.SelectedRows.Count <= 0) return;

            var pID = dgvProduct.CurrentRow.Cells["P_ID"].Value.ToString();
            this.AddToCart(pID);

        }

        private void AddToCart(string pID)
        {
            try
            {
                int i = 0;
                while (i < dgvCart.Rows.Count)
                {
                    string val = dgvCart.Rows[i].Cells["P_IDcart"].Value.ToString();
                    if (val.Equals(pID))
                    {
                        new ConfirmationError("Product already in cart", 20, 22).Show();
                        return;
                    }
                    i++;
                }


                var sql = $"select P_ID, ProductName, Price, Quantity from ProductInfo where P_ID = '" + pID + "';";
                var dt = Da.ExecuteQueryTable(sql);
                this.dgvCart.AutoGenerateColumns = false;
                var row = new string[] { dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), "1", dt.Rows[0][3].ToString() };
                this.dgvCart.Rows.Add(row);
                this.SetCost();

            }
            catch (Exception exec)
            {
                new ConfirmationError(exec.Message, 20, 22).Show();
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentQuantity = 0;
                if (this.dgvCart.Columns[e.ColumnIndex].Name.Equals("Increment"))
                {
                    currentQuantity = Int32.Parse(this.dgvCart.CurrentRow.Cells["QuantityCart"].Value.ToString());
                    var totalQuantity = Int32.Parse(this.dgvCart.CurrentRow.Cells["TotalQuantityCart"].Value.ToString());
                    if (totalQuantity == currentQuantity) return;

                    this.dgvCart.CurrentRow.Cells["QuantityCart"].Value = (++currentQuantity).ToString();
                    this.SetCost(currentQuantity);
                }
                else if (this.dgvCart.Columns[e.ColumnIndex].Name.Equals("Decrement"))
                {
                    currentQuantity = Int32.Parse(this.dgvCart.CurrentRow.Cells["QuantityCart"].Value.ToString());
                    if (currentQuantity == 1) return;
                    this.dgvCart.CurrentRow.Cells["QuantityCart"].Value = (--currentQuantity).ToString();
                    this.SetCost(currentQuantity);
                }
                else if (this.dgvCart.Columns[e.ColumnIndex].Name.Equals("DeleteButton"))
                {
                    if (this.dgvCart.SelectedRows.Count <= 0) return;
                    this.dgvCart.Rows.RemoveAt(e.RowIndex);
                    this.SetCost();
                }
            }
            catch (Exception exec)
            {
                new ConfirmationError(exec.Message, 20, 22).Show();
            }
        }

        private double SetCost(int q = 1)
        {

            int index = 0;
            double total = 0.0;

            while (index < this.dgvCart.RowCount)
            {
                var price = Double.Parse(this.dgvCart.Rows[index].Cells["PriceCart"].Value.ToString());
                var quantity = Double.Parse(this.dgvCart.Rows[index].Cells["QuantityCart"].Value.ToString());
                total += price * quantity;
                index++;
            }


            this.lblTotalCostPrice.Text = total.ToString() + "$";
            var vat = (total * 5) / 100;
            this.lblVatPrice.Text = vat.ToString() + "$";
            this.lblTotalPrice.Text = (vat + total).ToString() + "$";

            return total;
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            this.dgvCart.DataSource = null;
            this.dgvCart.Rows.Clear();
            this.SetCost();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.ShowDialog();
            if (string.IsNullOrEmpty(customerInfo.CustomerName)) return;
            else {
                string transactionID = "T-" + AutoId();
                var sql = @"select U_ID from UserInfo where Username = '"+Username+"' and Password = '"+Password+"';";
                var ds = Da.ExecuteQuery(sql);
                string uID = ds.Tables[0].Rows[0][0].ToString();
                string customerName = customerInfo.CustomerName;
                string[] a = lblTotalPrice.Text.Split('$');
                double amountPaid = Convert.ToDouble(a[0]);
                string purchaseDate = DateTime.Now.ToString("d");
                var query = @"insert into TransactionInfo values('"+ transactionID +"', '"+ uID +"', '"+ customerName +"', "+ amountPaid +", '"+ purchaseDate+"');";
                ds = Da.ExecuteQuery(query);
                this.dgvCart.DataSource = null;
                this.dgvCart.Rows.Clear();
                this.SetCost();
            }
        }


        private string AutoId()
        {
            try
            {
                var dt = Da.ExecuteQueryTable(@"Select * from TransactionInfo order by T_ID Desc;");
                string lastId = dt.Rows[0][0].ToString();
                string[] id = lastId.Split('-');
                int newIdNum = Convert.ToInt32(id[1]);
                return (++newIdNum).ToString("d3");
            }
            catch (IndexOutOfRangeException e)
            {
                var sql = "insert into TransactionInfo values ('T-001', 'U-010', 'Rianul Amin', 500, '2022-12-28');";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = Da.ExecuteQueryTable(@"Select * from TransactionInfo order by T_ID Desc;");
                string lastId = dt.Rows[0][0].ToString();
                string[] id = lastId.Split('-');
                int newIdNum = Convert.ToInt32(id[1]);
                return (++newIdNum).ToString("d3");
            }

        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}