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
    public partial class SellerTransactionHistory : UserControl
    {
        private string Username { get; set; }
        private string Password { get; set; }
        private string id;
        private DataAccess Da { get; set; }
        public SellerTransactionHistory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public SellerTransactionHistory(string u, string p)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Username = u;
            this.Password = p;
            UID();
            this.PopulateGridView();
        }

        public void UID() {
            
            var query = @"select U_ID from UserInfo where Username = '" + Username + "' and Password = '" + Password + "';";
            var ds = Da.ExecuteQuery(query);
            string uID = ds.Tables[0].Rows[0][0].ToString();
            this.id = uID;

        }

        private void PopulateGridView(string sql = null)
        {
            if(sql == null) sql = "select * from TransactionInfo where U_ID = '" + this.id + "'; ";
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvTransaction.AutoGenerateColumns = false;
            this.dgvTransaction.DataSource = ds.Tables[0];
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

        private void txtSearchByPurchaseDate_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchByPurchaseDate.Text == "Search By Purchase Date")
            {

                this.txtSearchByPurchaseDate.Text = "";
                this.txtSearchByPurchaseDate.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtSearchByPurchaseDate_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchByPurchaseDate.Text == "")
            {

                this.txtSearchByPurchaseDate.Text = "Search By Purchase Date";
                this.txtSearchByPurchaseDate.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
                this.PopulateGridView();


            }
        }

        private void txtSearchByPurchaseDate_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByPurchaseDate.Text != "Search By PurchaseDate" || string.IsNullOrEmpty(txtSearchByPurchaseDate.Text) == false || string.IsNullOrWhiteSpace(txtSearchByPurchaseDate.Text) == false)
            {
                var sql = "select * from TransactionInfo where PurchaseDate like '%" + this.txtSearchByPurchaseDate.Text + "%';";
                this.PopulateGridView(sql);
            }
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByID.Text != "Search By ID" || string.IsNullOrEmpty(txtSearchByID.Text) == false || string.IsNullOrWhiteSpace(txtSearchByID.Text) == false)
            {
                var sql = "select * from TransactionInfo where T_ID like '%" + this.txtSearchByID.Text + "%';";
                this.PopulateGridView(sql);
            }
        }
    }
}
