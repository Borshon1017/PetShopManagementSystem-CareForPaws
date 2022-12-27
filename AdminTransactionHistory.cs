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
    public partial class AdminTransactionHistory : UserControl
    {
        private DataAccess Da { get; set; }
        public AdminTransactionHistory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from TransactionInfo; ")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvTransaction.AutoGenerateColumns = false;
            this.dgvTransaction.DataSource = ds.Tables[0];
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByID.Text != "Search By ID" || string.IsNullOrEmpty(txtSearchByID.Text) == false || string.IsNullOrWhiteSpace(txtSearchByID.Text) == false)
            {
                var sql = "select * from TransactionInfo where T_ID like '%" + this.txtSearchByID.Text + "%';";
                this.PopulateGridView(sql);
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
    }
}
