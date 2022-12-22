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
    public partial class AddSellerUC : UserControl
    {
        public AddSellerUC()
        {
            InitializeComponent();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpSellerDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpSellerDOB.Text = "Select date of birth";
        }
    }
}
