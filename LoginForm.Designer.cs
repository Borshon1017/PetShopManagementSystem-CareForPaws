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
            this.lblPasswordEmpty = new System.Windows.Forms.Label();
            this.lblUsernameEmpty = new System.Windows.Forms.Label();
            this.lblInvalidLogin = new System.Windows.Forms.Label();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 525);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPasswordEmpty);
            this.panel2.Controls.Add(this.lblUsernameEmpty);
            this.panel2.Controls.Add(this.lblInvalidLogin);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Location = new System.Drawing.Point(245, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 312);
            this.panel2.TabIndex = 0;
            // 
            // lblPasswordEmpty
            // 
            this.lblPasswordEmpty.AutoSize = true;
            this.lblPasswordEmpty.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordEmpty.Location = new System.Drawing.Point(130, 96);
            this.lblPasswordEmpty.Name = "lblPasswordEmpty";
            this.lblPasswordEmpty.Size = new System.Drawing.Size(160, 16);
            this.lblPasswordEmpty.TabIndex = 5;
            this.lblPasswordEmpty.Text = "Password Can Not Be Empty";
            this.lblPasswordEmpty.Visible = false;
            // 
            // lblUsernameEmpty
            // 
            this.lblUsernameEmpty.AutoSize = true;
            this.lblUsernameEmpty.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameEmpty.Location = new System.Drawing.Point(130, 32);
            this.lblUsernameEmpty.Name = "lblUsernameEmpty";
            this.lblUsernameEmpty.Size = new System.Drawing.Size(164, 16);
            this.lblUsernameEmpty.TabIndex = 4;
            this.lblUsernameEmpty.Text = "Username Can Not Be Empty";
            this.lblUsernameEmpty.Visible = false;
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
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(82, 220);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnLogin.OverrideDefault.Back.ColorAngle = 45F;
            this.btnLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogin.OverrideDefault.Border.ColorAngle = 45F;
            this.btnLogin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogin.OverrideDefault.Border.Rounding = 20;
            this.btnLogin.OverrideDefault.Border.Width = 1;
            this.btnLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLogin.Size = new System.Drawing.Size(264, 47);
            this.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.StateCommon.Back.ColorAngle = 45F;
            this.btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StateCommon.Border.ColorAngle = 45F;
            this.btnLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogin.StateCommon.Border.Rounding = 20;
            this.btnLogin.StateCommon.Border.Width = 1;
            this.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.btnLogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.StatePressed.Back.ColorAngle = 135F;
            this.btnLogin.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StatePressed.Border.Rounding = 20;
            this.btnLogin.StatePressed.Border.Width = 1;
            this.btnLogin.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btnLogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.StateTracking.Back.ColorAngle = 45F;
            this.btnLogin.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogin.StateTracking.Border.ColorAngle = 45F;
            this.btnLogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogin.StateTracking.Border.Rounding = 20;
            this.btnLogin.StateTracking.Border.Width = 1;
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Values.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.txtPassword.StateCommon.Border.Rounding = 20;
            this.txtPassword.StateCommon.Border.Width = 1;
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.SystemColors.GrayText;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
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
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(930, 525);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private System.Windows.Forms.Label lblInvalidLogin;
        private System.Windows.Forms.Label lblPasswordEmpty;
        private System.Windows.Forms.Label lblUsernameEmpty;
    }
}

