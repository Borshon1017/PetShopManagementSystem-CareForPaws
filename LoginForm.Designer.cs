namespace CareForPaws
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVisible = new System.Windows.Forms.Button();
            this.btnInvisible = new System.Windows.Forms.Button();
            this.iconPassword = new System.Windows.Forms.PictureBox();
            this.iconUser = new System.Windows.Forms.PictureBox();
            this.lblInvalidLogin = new System.Windows.Forms.Label();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnlTitleBar = new Guna.UI.WinForms.GunaPanel();
            this.btnClose = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.btnLoginBlack = new Guna.UI.WinForms.GunaButton();
            this.btnMinimize = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pnlTitleBar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 625);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLoginBlack);
            this.panel2.Controls.Add(this.btnVisible);
            this.panel2.Controls.Add(this.btnInvisible);
            this.panel2.Controls.Add(this.iconPassword);
            this.panel2.Controls.Add(this.iconUser);
            this.panel2.Controls.Add(this.lblInvalidLogin);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Location = new System.Drawing.Point(248, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 312);
            this.panel2.TabIndex = 0;
            // 
            // btnVisible
            // 
            this.btnVisible.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnVisible.BackColor = System.Drawing.Color.Transparent;
            this.btnVisible.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisible.BackgroundImage")));
            this.btnVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisible.FlatAppearance.BorderSize = 0;
            this.btnVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisible.ForeColor = System.Drawing.Color.Transparent;
            this.btnVisible.Location = new System.Drawing.Point(352, 121);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(34, 29);
            this.btnVisible.TabIndex = 8;
            this.btnVisible.Text = "0";
            this.btnVisible.UseVisualStyleBackColor = false;
            this.btnVisible.Visible = false;
            this.btnVisible.Click += new System.EventHandler(this.btnvisible_Click);
            // 
            // btnInvisible
            // 
            this.btnInvisible.BackColor = System.Drawing.Color.Transparent;
            this.btnInvisible.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInvisible.BackgroundImage")));
            this.btnInvisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInvisible.FlatAppearance.BorderSize = 0;
            this.btnInvisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvisible.ForeColor = System.Drawing.Color.Transparent;
            this.btnInvisible.Location = new System.Drawing.Point(352, 121);
            this.btnInvisible.Name = "btnInvisible";
            this.btnInvisible.Size = new System.Drawing.Size(34, 29);
            this.btnInvisible.TabIndex = 7;
            this.btnInvisible.Text = "0";
            this.btnInvisible.UseVisualStyleBackColor = false;
            this.btnInvisible.Visible = false;
            this.btnInvisible.Click += new System.EventHandler(this.btninvisible_Click);
            // 
            // iconPassword
            // 
            this.iconPassword.Image = ((System.Drawing.Image)(resources.GetObject("iconPassword.Image")));
            this.iconPassword.Location = new System.Drawing.Point(37, 121);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(26, 26);
            this.iconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPassword.TabIndex = 5;
            this.iconPassword.TabStop = false;
            // 
            // iconUser
            // 
            this.iconUser.Image = ((System.Drawing.Image)(resources.GetObject("iconUser.Image")));
            this.iconUser.Location = new System.Drawing.Point(37, 54);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(26, 26);
            this.iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconUser.TabIndex = 4;
            this.iconUser.TabStop = false;
            // 
            // lblInvalidLogin
            // 
            this.lblInvalidLogin.AutoSize = true;
            this.lblInvalidLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidLogin.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidLogin.Location = new System.Drawing.Point(141, 174);
            this.lblInvalidLogin.Name = "lblInvalidLogin";
            this.lblInvalidLogin.Size = new System.Drawing.Size(139, 16);
            this.lblInvalidLogin.TabIndex = 3;
            this.lblInvalidLogin.Text = "Invalid Login Credentials";
            this.lblInvalidLogin.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(82, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(264, 34);
            this.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtPassword.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPassword.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtPassword.StateCommon.Border.Rounding = 20;
            this.txtPassword.StateCommon.Border.Width = 1;
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter_1);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave_1);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(82, 51);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(264, 34);
            this.txtUserName.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtUserName.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUserName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUserName.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtUserName.StateCommon.Border.Rounding = 20;
            this.txtUserName.StateCommon.Border.Width = 1;
            this.txtUserName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtUserName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Username";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave_1);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(930, 40);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.BaseColor2 = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.BorderSize = 2;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(52, 52);
            this.btnClose.Location = new System.Drawing.Point(889, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnClose.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.IndianRed;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnClose.Click += new System.EventHandler(this.gunaGradientCircleButton1_Click);
            // 
            // btnLoginBlack
            // 
            this.btnLoginBlack.AnimationHoverSpeed = 0.07F;
            this.btnLoginBlack.AnimationSpeed = 0.03F;
            this.btnLoginBlack.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginBlack.BaseColor = System.Drawing.Color.Black;
            this.btnLoginBlack.BorderColor = System.Drawing.Color.White;
            this.btnLoginBlack.BorderSize = 1;
            this.btnLoginBlack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoginBlack.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoginBlack.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginBlack.ForeColor = System.Drawing.Color.White;
            this.btnLoginBlack.Image = null;
            this.btnLoginBlack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLoginBlack.Location = new System.Drawing.Point(152, 217);
            this.btnLoginBlack.Name = "btnLoginBlack";
            this.btnLoginBlack.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnLoginBlack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoginBlack.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLoginBlack.OnHoverImage = null;
            this.btnLoginBlack.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoginBlack.OnPressedDepth = 20;
            this.btnLoginBlack.Radius = 22;
            this.btnLoginBlack.Size = new System.Drawing.Size(125, 47);
            this.btnLoginBlack.TabIndex = 15;
            this.btnLoginBlack.Text = "Login";
            this.btnLoginBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLoginBlack.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnLoginBlack.UseTransfarantBackground = true;
            this.btnLoginBlack.Click += new System.EventHandler(this.btnLoginBlack_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.BaseColor2 = System.Drawing.Color.White;
            this.btnMinimize.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.BorderSize = 2;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Image = null;
            this.btnMinimize.ImageSize = new System.Drawing.Size(52, 52);
            this.btnMinimize.Location = new System.Drawing.Point(850, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnMinimize.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnMinimize.Click += new System.EventHandler(this.gunaGradientCircleButton2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private System.Windows.Forms.Label lblInvalidLogin;
        private System.Windows.Forms.PictureBox iconUser;
        private System.Windows.Forms.PictureBox iconPassword;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.Button btnInvisible;
        private Guna.UI.WinForms.GunaPanel pnlTitleBar;
        private Guna.UI.WinForms.GunaGradientCircleButton btnClose;
        private Guna.UI.WinForms.GunaButton btnLoginBlack;
        private Guna.UI.WinForms.GunaGradientCircleButton btnMinimize;
    }
}

