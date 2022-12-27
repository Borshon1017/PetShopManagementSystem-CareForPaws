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


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
