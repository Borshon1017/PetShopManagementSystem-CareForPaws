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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
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
            AddSellerUC addSellerUC = new AddSellerUC();
            this.AddUserControl(addSellerUC);
        }

        private void btnSearchSeller_Click(object sender, EventArgs e)
        {
            EditInfoUC editInfoUC = new EditInfoUC();
            this.AddUserControl(editInfoUC);
        }

        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            DeleteSellerUC deleteSellerUC = new DeleteSellerUC();
            this.AddUserControl(deleteSellerUC);
        }

        private void btnSellerList_Click(object sender, EventArgs e)
        {
            RecoverSellerUC recoverSellerUC = new RecoverSellerUC();
            this.AddUserControl(recoverSellerUC);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
