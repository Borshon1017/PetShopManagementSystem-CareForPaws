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
            DeleteSellerUC.askStaticSingle = true;
            AdminHome.logoutConfirmation = true;
            AdminHome.recoverAllConfirmation= true;
            AdminHome.updateSellerConfirmation= true;
            SellerHome.logoutConfirmation= true;
            AddCategoryUC.categoryAddConfirmation = true;
            UpdateProductUC.updateProductConfirmation = true;
            UpdateCategoryUC.updateCategoryConfirmation=true;
            UpdateCategoryUC.deleteCategoryConfirmation = true;
            RecoverSellerUC.recover = true;
            RecoverSellerUC.recoverSingle = true;
            AdminHome.adminExit=true;
            SellerHome.sellerExit = true;
            



            this.Close();
            
            }

        private void btnNo_Click(object sender, EventArgs e)
        {
            AdminHome.logoutConfirmation = false;
            DeleteSellerUC.askStatic = false;
            DeleteSellerUC.askStaticSingle = false;
            AdminHome.recoverAllConfirmation = false;
            AdminHome.updateSellerConfirmation = false;
            SellerHome.logoutConfirmation = false;
            AddCategoryUC.categoryAddConfirmation = false;
            UpdateProductUC.updateProductConfirmation = false ;
            UpdateCategoryUC.updateCategoryConfirmation = false;
            UpdateCategoryUC.deleteCategoryConfirmation = false;
            RecoverSellerUC.recover = false;
            RecoverSellerUC.recoverSingle = false;
            AdminHome.adminExit = false;
            SellerHome.sellerExit = false;

            this.Close();
        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmationAsk_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
