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
    public partial class SellerSettings : Form
    {
        private string username;
        private string password;
        private DataAccess Da { get; set; }
        public SellerSettings(string u, string p)
        {
            InitializeComponent();
            this.username = u;
            this.password = p;
            this.Da = new DataAccess();
        }
        
        public string UID()
        {

            var query = @"select U_ID from UserInfo where Username = '" + username + "';";
            var ds = Da.ExecuteQuery(query);
            string uID = ds.Tables[0].Rows[0][0].ToString();
            return uID;

        }

        

        private void SellerSettings_Load(object sender, EventArgs e)
        {
            this.txtID.Text=UID();
            this.txtID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUserName.Text = username;
            this.txtUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password" || string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                lblPasswordError.Visible = true;
            }
            else
            {
                lblPasswordError.Visible = false;
            }
            if (lblPasswordError.Visible == true)
            {
                return;
            }
            if (txtPassword.Text.Length < 4)
            {

                lblPasswordError.Visible = true;
                new ConfirmationError().Show();
                return;
            }
            else
            {
                lblPasswordError.Visible = false;

            }
            /*confirmationask updateinfo = new confirmationask("   save current changes?", 12, 309);

            updateinfo.showdialog();
            if (adminhome.updatesellerconfirmation == true)
            {
            }
            else if (adminhome.updatesellerconfirmation == false)
            {
                return;
            }*/
            var query = "select * from UserInfo where U_ID = '" + this.txtID.Text + "' and Status = 'Active';";
            var ds = this.Da.ExecuteQuery(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                var sql = @"update UserInfo set Password = '" + this.txtPassword.Text + @"' where U_ID = '" + this.txtID.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1) {
                    MessageBox.Show("Data updated properly");
                    this.txtPassword.Clear();
                }
                else
                    MessageBox.Show("Data upgradation failed");
            }
        }
    }
}
