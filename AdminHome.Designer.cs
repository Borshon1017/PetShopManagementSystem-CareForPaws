namespace CareForPaws
{
    partial class AdminHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlUserOptionList = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSettings = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnUserProfile = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblUsername = new Guna.UI.WinForms.GunaLabel();
            this.btnSalesHistory = new Guna.UI.WinForms.GunaButton();
            this.btnManageProduct = new Guna.UI.WinForms.GunaButton();
            this.btnManageSeller = new Guna.UI.WinForms.GunaButton();
            this.transUsercontrol = new Guna.UI.WinForms.GunaTransition(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUserOptionList.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.transUsercontrol.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 625);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transUsercontrol.SetDecoration(this.panel3, Guna.UI.Animation.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(277, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 625);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlUserOptionList);
            this.panel2.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel2.Controls.Add(this.btnSalesHistory);
            this.panel2.Controls.Add(this.btnManageProduct);
            this.panel2.Controls.Add(this.btnManageSeller);
            this.transUsercontrol.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 624);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlUserOptionList
            // 
            this.pnlUserOptionList.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserOptionList.Controls.Add(this.btnLogout);
            this.pnlUserOptionList.Controls.Add(this.btnSettings);
            this.transUsercontrol.SetDecoration(this.pnlUserOptionList, Guna.UI.Animation.DecorationType.None);
            this.pnlUserOptionList.Location = new System.Drawing.Point(0, 47);
            this.pnlUserOptionList.Name = "pnlUserOptionList";
            this.pnlUserOptionList.Size = new System.Drawing.Size(278, 110);
            this.pnlUserOptionList.TabIndex = 18;
            this.pnlUserOptionList.Visible = false;
            this.pnlUserOptionList.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUserOptionList_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.BorderSize = 1;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.CheckedImage")));
            this.btnLogout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.transUsercontrol.SetDecoration(this.btnLogout, Guna.UI.Animation.DecorationType.None);
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.LineColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(-1, 55);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(279, 55);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // btnSettings
            // 
            this.btnSettings.AnimationHoverSpeed = 0.07F;
            this.btnSettings.AnimationSpeed = 0.03F;
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.BaseColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.BorderSize = 1;
            this.btnSettings.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSettings.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSettings.CheckedForeColor = System.Drawing.Color.White;
            this.btnSettings.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.CheckedImage")));
            this.btnSettings.CheckedLineColor = System.Drawing.Color.DimGray;
            this.transUsercontrol.SetDecoration(this.btnSettings, Guna.UI.Animation.DecorationType.None);
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.FocusedColor = System.Drawing.Color.Empty;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSettings.LineColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(-1, 1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSettings.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSettings.OnHoverImage = null;
            this.btnSettings.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSettings.OnPressedColor = System.Drawing.Color.Black;
            this.btnSettings.Size = new System.Drawing.Size(279, 55);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnUserProfile);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblUsername);
            this.transUsercontrol.SetDecoration(this.guna2CustomGradientPanel1, Guna.UI.Animation.DecorationType.None);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-1, 1);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(279, 47);
            this.guna2CustomGradientPanel1.TabIndex = 17;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserProfile.BackgroundImage")));
            this.btnUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserProfile.CheckedState.Parent = this.btnUserProfile;
            this.btnUserProfile.CustomImages.Parent = this.btnUserProfile;
            this.transUsercontrol.SetDecoration(this.btnUserProfile, Guna.UI.Animation.DecorationType.None);
            this.btnUserProfile.FillColor = System.Drawing.Color.Transparent;
            this.btnUserProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserProfile.ForeColor = System.Drawing.Color.White;
            this.btnUserProfile.HoverState.Parent = this.btnUserProfile;
            this.btnUserProfile.Location = new System.Drawing.Point(4, -2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.PressedColor = System.Drawing.Color.Gainsboro;
            this.btnUserProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUserProfile.ShadowDecoration.Parent = this.btnUserProfile;
            this.btnUserProfile.Size = new System.Drawing.Size(50, 49);
            this.btnUserProfile.TabIndex = 18;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.transUsercontrol.SetDecoration(this.lblUsername, Guna.UI.Animation.DecorationType.None);
            this.lblUsername.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(55, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 27);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.AnimationHoverSpeed = 0.07F;
            this.btnSalesHistory.AnimationSpeed = 0.03F;
            this.btnSalesHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesHistory.BaseColor = System.Drawing.Color.Black;
            this.btnSalesHistory.BorderColor = System.Drawing.Color.White;
            this.btnSalesHistory.BorderSize = 1;
            this.transUsercontrol.SetDecoration(this.btnSalesHistory, Guna.UI.Animation.DecorationType.None);
            this.btnSalesHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalesHistory.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalesHistory.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesHistory.ForeColor = System.Drawing.Color.White;
            this.btnSalesHistory.Image = null;
            this.btnSalesHistory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSalesHistory.Location = new System.Drawing.Point(26, 408);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnSalesHistory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalesHistory.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSalesHistory.OnHoverImage = null;
            this.btnSalesHistory.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalesHistory.OnPressedDepth = 20;
            this.btnSalesHistory.Radius = 22;
            this.btnSalesHistory.Size = new System.Drawing.Size(225, 58);
            this.btnSalesHistory.TabIndex = 15;
            this.btnSalesHistory.Text = "Sales History";
            this.btnSalesHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalesHistory.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnSalesHistory.UseTransfarantBackground = true;
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.AnimationHoverSpeed = 0.07F;
            this.btnManageProduct.AnimationSpeed = 0.03F;
            this.btnManageProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnManageProduct.BaseColor = System.Drawing.Color.Black;
            this.btnManageProduct.BorderColor = System.Drawing.Color.White;
            this.btnManageProduct.BorderSize = 1;
            this.transUsercontrol.SetDecoration(this.btnManageProduct, Guna.UI.Animation.DecorationType.None);
            this.btnManageProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManageProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnManageProduct.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProduct.ForeColor = System.Drawing.Color.White;
            this.btnManageProduct.Image = null;
            this.btnManageProduct.ImageSize = new System.Drawing.Size(20, 20);
            this.btnManageProduct.Location = new System.Drawing.Point(26, 344);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnManageProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnManageProduct.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnManageProduct.OnHoverImage = null;
            this.btnManageProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnManageProduct.OnPressedDepth = 20;
            this.btnManageProduct.Radius = 22;
            this.btnManageProduct.Size = new System.Drawing.Size(225, 58);
            this.btnManageProduct.TabIndex = 14;
            this.btnManageProduct.Text = "Manage Product";
            this.btnManageProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnManageProduct.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnManageProduct.UseTransfarantBackground = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // btnManageSeller
            // 
            this.btnManageSeller.AnimationHoverSpeed = 0.07F;
            this.btnManageSeller.AnimationSpeed = 0.03F;
            this.btnManageSeller.BackColor = System.Drawing.Color.Transparent;
            this.btnManageSeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageSeller.BaseColor = System.Drawing.Color.Black;
            this.btnManageSeller.BorderColor = System.Drawing.Color.White;
            this.btnManageSeller.BorderSize = 1;
            this.transUsercontrol.SetDecoration(this.btnManageSeller, Guna.UI.Animation.DecorationType.None);
            this.btnManageSeller.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManageSeller.FocusedColor = System.Drawing.Color.Empty;
            this.btnManageSeller.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSeller.ForeColor = System.Drawing.Color.White;
            this.btnManageSeller.Image = null;
            this.btnManageSeller.ImageSize = new System.Drawing.Size(20, 20);
            this.btnManageSeller.Location = new System.Drawing.Point(26, 216);
            this.btnManageSeller.Name = "btnManageSeller";
            this.btnManageSeller.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnManageSeller.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnManageSeller.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnManageSeller.OnHoverImage = null;
            this.btnManageSeller.OnPressedColor = System.Drawing.Color.Black;
            this.btnManageSeller.OnPressedDepth = 20;
            this.btnManageSeller.Radius = 22;
            this.btnManageSeller.Size = new System.Drawing.Size(225, 58);
            this.btnManageSeller.TabIndex = 13;
            this.btnManageSeller.Text = "Manage Seller";
            this.btnManageSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnManageSeller.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnManageSeller.UseTransfarantBackground = true;
            this.btnManageSeller.Click += new System.EventHandler(this.btnManageSeller_Click);
            // 
            // transUsercontrol
            // 
            this.transUsercontrol.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide;
            this.transUsercontrol.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transUsercontrol.DefaultAnimation = animation1;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.panel1);
            this.transUsercontrol.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlUserOptionList.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnSalesHistory;
        private Guna.UI.WinForms.GunaButton btnManageProduct;
        private Guna.UI.WinForms.GunaButton btnManageSeller;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI.WinForms.GunaLabel lblUsername;
        private Guna.UI.WinForms.GunaTransition transUsercontrol;
        private System.Windows.Forms.Panel pnlUserOptionList;
        private Guna.UI2.WinForms.Guna2CircleButton btnUserProfile;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        private Guna.UI.WinForms.GunaAdvenceButton btnSettings;
    }
}