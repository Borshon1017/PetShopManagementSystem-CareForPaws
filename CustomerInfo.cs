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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            if (this.txtCustomerName.Text == "Enter Customer's Name")
            {

                this.txtCustomerName.Text = "";
                this.txtCustomerName.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            if (this.txtCustomerName.Text == "")
            {

                this.txtCustomerName.Text = "Enter Customer's Name";
                this.txtCustomerName.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;

            }
        }

        public String CustomerName { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "Enter Customer's Name" || string.IsNullOrEmpty(txtCustomerName.Text) == true)
            {
                lblCustomerNameEmpty.Visible = true;
                return;
            }
            CustomerName = this.txtCustomerName.Text;
            ConfirmationBilling a = new ConfirmationBilling();
            a.Show();
            this.Close();
        }
    }
}
