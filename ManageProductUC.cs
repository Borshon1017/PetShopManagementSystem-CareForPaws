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
    public partial class ManageProductUC : UserControl
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

        private void AddUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();

        }
        public ManageProductUC()
        {
            InitializeComponent();
        }

        private void ManageProductUC_Load(object sender, EventArgs e)
        {
            AddCategoryUC addCategoryUC = new AddCategoryUC();
            this.AddUserControl(addCategoryUC);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryUC addCategoryUC = new AddCategoryUC();
            this.AddUserControl(addCategoryUC);
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            UpdateCategoryUC updateCategoryUC = new UpdateCategoryUC();
            this.AddUserControl(updateCategoryUC);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductUC addProductUC = new AddProductUC();
            this.AddUserControl(addProductUC);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProductUC updateProductUC = new UpdateProductUC();
            this.AddUserControl(updateProductUC);
        }
    }
    
}
