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
    public partial class LoginForm : Form
    {
        public void EnableDoubleBuffering()
        {
            // Set the value of the double-buffering style bits to true.
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }

        private DataAccess Da { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                var sql = "select * from UserInfo where Username = '" + this.txtUserName.Text + "' and Password = '" + this.txtPassword.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                if (ds.Tables[0].Rows[0][7].ToString() == "Admin")
                {

                    new AdminHome(this.txtUserName.Text).Show();
                    this.Hide();

                }

                else if (ds.Tables[0].Rows[0][7].ToString() == "Seller")
                    new SellerHome().Show();
                }
                else
                {
                    lblInvalidLogin.Visible = true;
                }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {

            if (this.txtUserName.Text == "Username") {

                this.txtUserName.Text = "";
                this.txtUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }

        }

        private void txtUserName_Leave_1(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == "")
            {

                this.txtUserName.Text = "Username";
                this.txtUserName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void txtPassword_Enter_1(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Password")
            {

                this.txtPassword.Text = "";
                this.txtPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtPassword_Leave_1(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {

                this.txtPassword.Text = "Password";
                this.txtPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar= true;
            btnInvisible.Visible= true;
            btnVisible.Visible= true;
            btnInvisible.BringToFront();

        }

        private void btnvisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnInvisible.BringToFront();
               // btnInvisible.Visible = true;
                //btnVisible.Visible = false;
            }
            
            
            
        }

        private void btninvisible_Click(object sender, EventArgs e)
        {
           
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnVisible.BringToFront();
              //  btnInvisible.Visible = false;
               // btnVisible.Visible = true;
            }
            
           
            



        }

        private void btnLoginGuna_Click(object sender, EventArgs e)
        {
            var sql = "select * from UserInfo where Username = '" + this.txtUserName.Text + "' and Password = '" + this.txtPassword.Text + "';";
            var ds = this.Da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                if (ds.Tables[0].Rows[0][7].ToString() == "Admin")
                {
                    string usernameLabel = this.txtUserName.Text;
                    new AdminHome(usernameLabel).Show();
                    this.Hide();

                }

                else if (ds.Tables[0].Rows[0][7].ToString() == "Seller")
                    new SellerHome().Show();
            }
            else
            {
                lblInvalidLogin.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
