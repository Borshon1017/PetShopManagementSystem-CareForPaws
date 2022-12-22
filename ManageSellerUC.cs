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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            AddSellerUC addSellerUC = new AddSellerUC();
            addSellerUC.Location = new Point(4, 53);
            addSellerUC.Dock = DockStyle.None;
        }
    }
}
