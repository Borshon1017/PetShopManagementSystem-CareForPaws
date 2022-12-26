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
        private string username;
        public SellerHome(string username)

        {
            this.username = username;
            InitializeComponent();
            lblUsername.Text = username;
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
    }
}

