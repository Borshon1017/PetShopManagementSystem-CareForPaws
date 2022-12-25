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
    public partial class RecoverSellerUC : UserControl
    {
        private DataAccess Da { get; set; }
        public RecoverSellerUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from UserInfo where Role = 'Seller' and Status = 'Inactive';")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSeller.AutoGenerateColumns = false;
            this.dgvSeller.DataSource = ds.Tables[0];
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

        private void RecoverSellerUC_Load(object sender, EventArgs e)
        {
            this.dgvSeller.ClearSelection();
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByID.Text != "Search By ID" || string.IsNullOrEmpty(txtSearchByID.Text) == false || string.IsNullOrWhiteSpace(txtSearchByID.Text) == false)
            {
                var sql = "select * from UserInfo where U_ID like '%" + this.txtSearchByID.Text + "%' and Role = 'Seller' and Status = 'Inactive';";
                this.PopulateGridView(sql);
            }
        }

        private void txtSearchByUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByUserName.Text != "Search By Username" || string.IsNullOrEmpty(txtSearchByUserName.Text) == false || string.IsNullOrWhiteSpace(txtSearchByUserName.Text) == false)
            {
                var sql = "select * from UserInfo where Username like '%" + this.txtSearchByUserName.Text + "%' and Role = 'Seller' and Status = 'Inactive';";
                this.PopulateGridView(sql);
            }
        }

        private void txtSeachByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSeachByName.Text != "Search By Full Name" || string.IsNullOrEmpty(txtSeachByName.Text) == false || string.IsNullOrWhiteSpace(txtSeachByName.Text) == false)
            {
                var sql = "select * from UserInfo where FullName like '%" + this.txtSeachByName.Text + "%' and Role = 'Seller' and Status = 'Inactive';";
                this.PopulateGridView(sql);
            }
        }

        private void dgvSeller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSeller.Columns[e.ColumnIndex].Name.Equals("RecoverButton"))
            {
                var sql = "update UserInfo set Status = 'Active' where U_ID  = '" + this.dgvSeller.CurrentRow.Cells["U_ID"].Value.ToString() + "' and Role = 'Seller';";
                this.Da.ExecuteDMLQuery(sql);
                this.PopulateGridView();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var sql = "update UserInfo set Status = 'Active' where Role = 'Seller';";
            this.Da.ExecuteDMLQuery(sql);
            this.PopulateGridView();
        }
    }
}
