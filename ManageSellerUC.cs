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
    public partial class ManageSellerUC : UserControl
    {
        public ManageSellerUC()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void ManageSellerUC_Load(object sender, EventArgs e)
        {
            AddSellerUC addSellerUC = new AddSellerUC();
            this.AddUserControl(addSellerUC);
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchSeller_Click(object sender, EventArgs e)
        {
            SearchSellerUC searchSellerUC = new SearchSellerUC();
            this.AddUserControl(searchSellerUC);
        }
    }
}
