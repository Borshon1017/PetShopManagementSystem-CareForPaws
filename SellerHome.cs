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
    public partial class SellerHome : Form
    {
        
       
        public static bool logoutConfirmation;
        protected override CreateParams CreateParams

        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
        public static bool sellerExit;
        private string username;
        private string password;
        public SellerHome(string u, string p)

        {
            this.username = u;
            this.password = p;
       
            InitializeComponent();
            lblUsername.Text = u;

        }

        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrderUC createOrderUC = new CreateOrderUC(username, password);
            this.AddUserControl(createOrderUC);
        }

        private void pnlUserOptionList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUserProfile_Click_1(object sender, EventArgs e)
        {
            if (pnlUserOptionlist.Visible == false)
            {

                guna2Transition1.ShowSync(pnlUserOptionlist);


            }
            else
            {

                guna2Transition1.HideSync(pnlUserOptionlist);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           new ConfirmationAsk("Do you want to close this application?", 12, 309).ShowDialog();
            if (sellerExit==true)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (sellerExit==false)
            {
                return;
            }


        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            SellerTransactionHistory sellerTransactionHistory = new SellerTransactionHistory(username, password);
            this.AddUserControl(sellerTransactionHistory);
        }
    }
}

