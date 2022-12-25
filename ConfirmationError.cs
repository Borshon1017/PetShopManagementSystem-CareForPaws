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
    public partial class ConfirmationError : Form
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
        private System.Windows.Forms.Timer tmr;
        public ConfirmationError()
        {
            InitializeComponent();
        }
        public ConfirmationError(string message, int x, int y)
        {
            InitializeComponent();
            lblComfirmationFail.Location = new Point(x, y);
            lblComfirmationFail.Text = message;
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(3).TotalMilliseconds;
            tmr.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblComfirmationFail_Click(object sender, EventArgs e)
        {

        }
    }
}
