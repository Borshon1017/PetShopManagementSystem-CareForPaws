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

    public partial class AdminHome : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
        
        public static bool logoutConfirmation;
        public static bool recoverAllConfirmation;
        public static bool updateSellerConfirmation;
        public static bool adminExit;
        private string username;
        public void EnableDoubleBuffering()
        {
            // Set the value of the double-buffering style bits to true.
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }


        public AdminHome(string username)
        {
            this.username = username;
            InitializeComponent();
            lblUsername.Text = username;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void AddUserControl(UserControl userControl) { 
        
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        
        }

        private void btnManageSeller_Click(object sender, EventArgs e)
        {

            ManageSellerUC manageSellerUC = new ManageSellerUC();
            this.AddUserControl(manageSellerUC);
            




        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {

            ManageProductUC manageProductUC = new ManageProductUC();
            this.AddUserControl(manageProductUC);

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pnlUserOptionList_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
        }

       

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void addSellerUC1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {


            ConfirmationAsk logoutConfirmationObject = new ConfirmationAsk("Are you sure you want Logout?", 12, 309);
           
            logoutConfirmationObject.ShowDialog();
           
           
            
            Logoutaction();
            





        }
        void Logoutaction()
        {
            if (logoutConfirmation == false)
            {

              
               


            }
            else if (logoutConfirmation == true)
            {
                new LoginForm().Show();
                this.Close();
                
              
                logoutConfirmation = false;
                
                

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            AdminTransactionHistory adminTransactionHistory = new AdminTransactionHistory();
            this.AddUserControl(adminTransactionHistory);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnUserProfile_Click(object sender, EventArgs e)
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

        private void pnlUserList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new ConfirmationAsk("Do you want to close this application?", 12, 309).ShowDialog();
            if (adminExit == true)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (adminExit == false)
            {
                return;
            }
        }
    }
}
