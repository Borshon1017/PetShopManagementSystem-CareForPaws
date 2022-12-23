using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareForPaws
{
    public partial class Comfirmation : Form
    {
        private System.Windows.Forms.Timer tmr;
        

        public Comfirmation(string message, int x, int y)
        {
            InitializeComponent();
           lblComfirmation.Location = new Point(x, y);
            lblComfirmation.Text = message;
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(2).TotalMilliseconds;
            tmr.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
