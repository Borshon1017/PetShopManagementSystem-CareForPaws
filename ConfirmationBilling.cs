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
    public partial class ConfirmationBilling : Form
    {
        private List<string[]> CartRows { set; get; }
        private System.Windows.Forms.Timer tmr;
        public ConfirmationBilling()
        {

            InitializeComponent();


            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                gifConfirmationTick.Visible = false;
                lblComfirmation.Visible = false;

            };
            tmr.Interval = (int)TimeSpan.FromSeconds(2).TotalMilliseconds;
            tmr.Start();
            this.panel1.Visible = true;


        }
        public ConfirmationBilling(List<string[]> cartRows, double totalCartCost) : base()
        {
            this.CartRows = cartRows;
            this.PopulateDGVCart();
            this.lblTotalCostPrice.Text = totalCartCost.ToString() + "$";
            this.lblVatPrice.Text = ((totalCartCost * 5) / 100).ToString() + "$";
            this.lblTotalPrice.Text = (totalCartCost + ((totalCartCost * 5) / 100)).ToString() + "$";
            this.lblDateToday.Text = DateTime.Now.ToString("D");
        }

        private void PopulateDGVCart()
        {
            try
            {
                int index = 0;
                while (index < CartRows.Count)
                {
                    var name = this.CartRows[index][0];
                    var price = this.CartRows[index][1];
                    var quantity = this.CartRows[index][2];
                    MessageBox.Show(name);
                    MessageBox.Show(price);
                    MessageBox.Show(quantity);
                    
                    MessageBox.Show(dgvFinalCart.Rows.Count.ToString());
                    this.dgvFinalCart.Rows.Add(new string[] { name, price, quantity });

                    index++;
                }
            }
            catch (Exception exec)
            {
                new ConfirmationError(exec.Message, 20, 22).Show();

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
