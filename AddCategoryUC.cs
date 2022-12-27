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
    public partial class AddCategoryUC : UserControl
    {
        public static bool categoryAddConfirmation;
        public AddCategoryUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            if (String.IsNullOrEmpty(txtCategoryName.Text) == false)
            {
                btnAddCategory.Enabled = true;
            }
        }

        private DataAccess Da { get; set; }

        private void txtCategoryName_Enter(object sender, EventArgs e)
        {
            if (this.txtCategoryName.Text == "Category Name")
            {

                this.txtCategoryName.Text = "";
                this.txtCategoryName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtCategoryName_Leave(object sender, EventArgs e)
        {
            if (this.txtCategoryName.Text == "")
            {

                this.txtCategoryName.Text = "Category Name";
                this.txtCategoryName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string CID = "C-" + this.AutoId();
            string categoryName = txtCategoryName.Text;




            if (txtCategoryName.StateCommon.Content.Color1 == Color.Gray|| txtCategoryName.Text== "Category Name" || string.IsNullOrEmpty(txtCategoryName.Text) == true)
            {
                lblCategoryNameEmpty.Visible = true;
                return;
            }
            new ConfirmationAsk("Are you sure you want '" + txtCategoryName.Text + "' to add to category list?", 12, 309).ShowDialog();
            if (categoryAddConfirmation == true)
            {
            }
            else if (categoryAddConfirmation == false)
            {
                return;
            }

            var sql = "select * from CategoryInfo where CategoryName = '" + categoryName + "';";
            var ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                lblCategoryNameEmpty.Visible = true;
                new ConfirmationError("Category already exists", 15, 17).Show();
                return;
            }
            lblCategoryNameEmpty.Visible = false;
            sql = "insert into CategoryInfo values ('" + CID + "', '" + categoryName + "')  ;";
            ds = this.Da.ExecuteQuery(sql);

            new ConfirmationDone("Category Added Sucessfully", 38, 369).Show();
            this.txtCategoryName.Text = "Category Name";
            this.txtCategoryName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
        }

        private string AutoId()
        {
            try
            {
                var dt = Da.ExecuteQueryTable(@"Select * from CategoryInfo order by C_ID Desc;");
                string lastId = dt.Rows[0][0].ToString();
                string[] id = lastId.Split('-');
                int newIdNum = Convert.ToInt32(id[1]);
                return (++newIdNum).ToString("d3");
            }
            catch (IndexOutOfRangeException e) {
                var sql = "insert into CategoryInfo values ('C-001', 'Food');";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = Da.ExecuteQueryTable(@"Select * from CategoryInfo order by C_ID Desc;");
                string lastId = dt.Rows[0][0].ToString();
                string[] id = lastId.Split('-');
                int newIdNum = Convert.ToInt32(id[1]);
                return (++newIdNum).ToString("d3");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
