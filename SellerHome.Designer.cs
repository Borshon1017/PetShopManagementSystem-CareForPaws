namespace CareForPaws
{
    partial class SellerHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerHome));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCreateOrder = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(278, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 625);
            this.panel3.TabIndex = 2;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.AnimationHoverSpeed = 0.07F;
            this.btnCreateOrder.AnimationSpeed = 0.03F;
            this.btnCreateOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateOrder.BaseColor = System.Drawing.Color.Black;
            this.btnCreateOrder.BorderColor = System.Drawing.Color.White;
            this.btnCreateOrder.BorderSize = 1;
            this.btnCreateOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateOrder.FocusedColor = System.Drawing.Color.Empty;
            this.btnCreateOrder.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrder.Image = null;
            this.btnCreateOrder.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCreateOrder.Location = new System.Drawing.Point(23, 228);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnCreateOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCreateOrder.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnCreateOrder.OnHoverImage = null;
            this.btnCreateOrder.OnPressedColor = System.Drawing.Color.Black;
            this.btnCreateOrder.OnPressedDepth = 20;
            this.btnCreateOrder.Radius = 22;
            this.btnCreateOrder.Size = new System.Drawing.Size(225, 58);
            this.btnCreateOrder.TabIndex = 14;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateOrder.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnCreateOrder.UseTransfarantBackground = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // SellerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnCreateOrder;
    }
}