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
    }
}
