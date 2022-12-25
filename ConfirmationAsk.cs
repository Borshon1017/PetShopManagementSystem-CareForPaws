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
    public partial class ConfirmationAsk : Form
    {
        
        public ConfirmationAsk()
        {
            
            InitializeComponent();
        }
        public ConfirmationAsk(string msg, int x, int y)
        {
            
            InitializeComponent();
            lblComfirmationFail.Text = msg;
            lblComfirmationFail.Location = new Point(x, y);
        }



        private void btnYes_Click(object sender, EventArgs e)
        {
            DeleteSellerUC.askStatic = true;
            AdminHome.logoutConfirmation = true;

            if (DeleteSellerUC.askStatic = true || AdminHome.logoutConfirmation == true)
            {
                this.Close();
            }
            }

        private void btnNo_Click(object sender, EventArgs e)
        {
            AdminHome.logoutConfirmation = false;
            DeleteSellerUC.askStatic = false;
            this.Close();
        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
