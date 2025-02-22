﻿namespace CareForPaws
{
    partial class AddSellerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSellerUC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpSellerDOB = new Guna.UI.WinForms.GunaDateTimePicker();
            this.rdbMale = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.rdbFemale = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.icoMale = new System.Windows.Forms.PictureBox();
            this.icoFemale = new System.Windows.Forms.PictureBox();
            this.btnAddSeller = new Guna.UI.WinForms.GunaButton();
            this.txtFullName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPhoneNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtConfirmPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnClearAll = new Guna.UI.WinForms.GunaButton();
            this.dtpJoiningDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblFullNameEmpty = new System.Windows.Forms.Label();
            this.lblSalaryEmpty = new System.Windows.Forms.Label();
            this.lblUsernameEmpty = new System.Windows.Forms.Label();
            this.lblPhoneNumberEmpty = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblComfirmPasswordError = new System.Windows.Forms.Label();
            this.lblGenderSelectMale = new System.Windows.Forms.Label();
            this.lblGenderSelectFemale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoFemale)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtpSellerDOB
            // 
            this.dtpSellerDOB.BackColor = System.Drawing.Color.Transparent;
            this.dtpSellerDOB.BaseColor = System.Drawing.Color.White;
            this.dtpSellerDOB.BorderColor = System.Drawing.Color.Silver;
            this.dtpSellerDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpSellerDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpSellerDOB.FocusedColor = System.Drawing.Color.Black;
            this.dtpSellerDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSellerDOB.ForeColor = System.Drawing.Color.Black;
            this.dtpSellerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSellerDOB.Location = new System.Drawing.Point(30, 401);
            this.dtpSellerDOB.MaxDate = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            this.dtpSellerDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpSellerDOB.Name = "dtpSellerDOB";
            this.dtpSellerDOB.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpSellerDOB.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.dtpSellerDOB.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpSellerDOB.OnPressedColor = System.Drawing.Color.Black;
            this.dtpSellerDOB.Size = new System.Drawing.Size(208, 30);
            this.dtpSellerDOB.TabIndex = 5;
            this.dtpSellerDOB.Text = "12/22/2022";
            this.dtpSellerDOB.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.dtpSellerDOB.Value = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            this.dtpSellerDOB.ValueChanged += new System.EventHandler(this.dtpSellerDOB_ValueChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.BaseColor = System.Drawing.Color.White;
            this.rdbMale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbMale.CheckedOnColor = System.Drawing.Color.Black;
            this.rdbMale.FillColor = System.Drawing.Color.White;
            this.rdbMale.Location = new System.Drawing.Point(396, 398);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(20, 20);
            this.rdbMale.TabIndex = 7;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // rdbFemale
            // 
            this.rdbFemale.BaseColor = System.Drawing.Color.White;
            this.rdbFemale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbFemale.CheckedOnColor = System.Drawing.Color.Black;
            this.rdbFemale.FillColor = System.Drawing.Color.White;
            this.rdbFemale.Location = new System.Drawing.Point(555, 398);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(20, 20);
            this.rdbFemale.TabIndex = 8;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbFemale_CheckedChanged);
            // 
            // icoMale
            // 
            this.icoMale.Image = ((System.Drawing.Image)(resources.GetObject("icoMale.Image")));
            this.icoMale.Location = new System.Drawing.Point(320, 371);
            this.icoMale.Name = "icoMale";
            this.icoMale.Size = new System.Drawing.Size(70, 60);
            this.icoMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoMale.TabIndex = 9;
            this.icoMale.TabStop = false;
            // 
            // icoFemale
            // 
            this.icoFemale.Image = ((System.Drawing.Image)(resources.GetObject("icoFemale.Image")));
            this.icoFemale.Location = new System.Drawing.Point(479, 371);
            this.icoFemale.Name = "icoFemale";
            this.icoFemale.Size = new System.Drawing.Size(70, 60);
            this.icoFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoFemale.TabIndex = 10;
            this.icoFemale.TabStop = false;
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.AnimationHoverSpeed = 0.07F;
            this.btnAddSeller.AnimationSpeed = 0.03F;
            this.btnAddSeller.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSeller.BaseColor = System.Drawing.Color.Black;
            this.btnAddSeller.BorderColor = System.Drawing.Color.White;
            this.btnAddSeller.BorderSize = 1;
            this.btnAddSeller.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSeller.Enabled = false;
            this.btnAddSeller.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddSeller.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSeller.ForeColor = System.Drawing.Color.White;
            this.btnAddSeller.Image = null;
            this.btnAddSeller.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddSeller.Location = new System.Drawing.Point(450, 472);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnAddSeller.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddSeller.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddSeller.OnHoverImage = null;
            this.btnAddSeller.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddSeller.OnPressedDepth = 20;
            this.btnAddSeller.Radius = 22;
            this.btnAddSeller.Size = new System.Drawing.Size(125, 47);
            this.btnAddSeller.TabIndex = 14;
            this.btnAddSeller.Text = "Add Seller";
            this.btnAddSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSeller.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnAddSeller.UseTransfarantBackground = true;
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(311, 28);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(264, 34);
            this.txtFullName.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtFullName.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtFullName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFullName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtFullName.StateCommon.Border.Rounding = 20;
            this.txtFullName.StateCommon.Border.Width = 1;
            this.txtFullName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtFullName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtFullName.TabIndex = 15;
            this.txtFullName.Text = "Full Name";
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged_1);
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(311, 78);
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
            this.txtUserName.TabIndex = 16;
            this.txtUserName.Text = "Username";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(311, 128);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(264, 34);
            this.txtPhoneNumber.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtPhoneNumber.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtPhoneNumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhoneNumber.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPhoneNumber.StateCommon.Border.Rounding = 20;
            this.txtPhoneNumber.StateCommon.Border.Width = 1;
            this.txtPhoneNumber.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPhoneNumber.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPhoneNumber.TabIndex = 17;
            this.txtPhoneNumber.Text = "Phone Number";
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(311, 228);
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
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(311, 277);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(264, 34);
            this.txtConfirmPassword.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtConfirmPassword.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtConfirmPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtConfirmPassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtConfirmPassword.StateCommon.Border.Rounding = 20;
            this.txtConfirmPassword.StateCommon.Border.Width = 1;
            this.txtConfirmPassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtConfirmPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtConfirmPassword.TabIndex = 19;
            this.txtConfirmPassword.Text = "Confirm Password";
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(311, 178);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(264, 34);
            this.txtSalary.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSalary.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSalary.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSalary.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSalary.StateCommon.Border.Rounding = 20;
            this.txtSalary.StateCommon.Border.Width = 1;
            this.txtSalary.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSalary.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSalary.TabIndex = 20;
            this.txtSalary.Text = "Salary";
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            this.txtSalary.Enter += new System.EventHandler(this.txtSalary_Enter);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // btnClearAll
            // 
            this.btnClearAll.AnimationHoverSpeed = 0.07F;
            this.btnClearAll.AnimationSpeed = 0.03F;
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearAll.BaseColor = System.Drawing.Color.Black;
            this.btnClearAll.BorderColor = System.Drawing.Color.White;
            this.btnClearAll.BorderSize = 1;
            this.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnClearAll.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Image = null;
            this.btnClearAll.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClearAll.Location = new System.Drawing.Point(312, 472);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnClearAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClearAll.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClearAll.OnHoverImage = null;
            this.btnClearAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearAll.OnPressedDepth = 20;
            this.btnClearAll.Radius = 22;
            this.btnClearAll.Size = new System.Drawing.Size(125, 47);
            this.btnClearAll.TabIndex = 21;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearAll.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnClearAll.UseTransfarantBackground = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpJoiningDate.BaseColor = System.Drawing.Color.White;
            this.dtpJoiningDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpJoiningDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoiningDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpJoiningDate.FocusedColor = System.Drawing.Color.Black;
            this.dtpJoiningDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpJoiningDate.ForeColor = System.Drawing.Color.Black;
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoiningDate.Location = new System.Drawing.Point(30, 326);
            this.dtpJoiningDate.MaxDate = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            this.dtpJoiningDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpJoiningDate.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.dtpJoiningDate.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpJoiningDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpJoiningDate.Size = new System.Drawing.Size(208, 30);
            this.dtpJoiningDate.TabIndex = 22;
            this.dtpJoiningDate.Text = "12/22/2022";
            this.dtpJoiningDate.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.dtpJoiningDate.Value = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Joining Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date of Birth";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblFullNameEmpty
            // 
            this.lblFullNameEmpty.AutoSize = true;
            this.lblFullNameEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblFullNameEmpty.Location = new System.Drawing.Point(284, 34);
            this.lblFullNameEmpty.Name = "lblFullNameEmpty";
            this.lblFullNameEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblFullNameEmpty.TabIndex = 33;
            this.lblFullNameEmpty.Text = "*";
            this.lblFullNameEmpty.Visible = false;
            this.lblFullNameEmpty.Click += new System.EventHandler(this.lblFullNameEmpty_Click);
            // 
            // lblSalaryEmpty
            // 
            this.lblSalaryEmpty.AutoSize = true;
            this.lblSalaryEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryEmpty.Location = new System.Drawing.Point(284, 185);
            this.lblSalaryEmpty.Name = "lblSalaryEmpty";
            this.lblSalaryEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblSalaryEmpty.TabIndex = 35;
            this.lblSalaryEmpty.Text = "*";
            this.lblSalaryEmpty.Visible = false;
            this.lblSalaryEmpty.Click += new System.EventHandler(this.lblSalaryEmpty_Click);
            // 
            // lblUsernameEmpty
            // 
            this.lblUsernameEmpty.AutoSize = true;
            this.lblUsernameEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameEmpty.Location = new System.Drawing.Point(284, 84);
            this.lblUsernameEmpty.Name = "lblUsernameEmpty";
            this.lblUsernameEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblUsernameEmpty.TabIndex = 36;
            this.lblUsernameEmpty.Text = "*";
            this.lblUsernameEmpty.Visible = false;
            // 
            // lblPhoneNumberEmpty
            // 
            this.lblPhoneNumberEmpty.AutoSize = true;
            this.lblPhoneNumberEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberEmpty.Location = new System.Drawing.Point(284, 134);
            this.lblPhoneNumberEmpty.Name = "lblPhoneNumberEmpty";
            this.lblPhoneNumberEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblPhoneNumberEmpty.TabIndex = 37;
            this.lblPhoneNumberEmpty.Text = "*";
            this.lblPhoneNumberEmpty.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(284, 237);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(21, 25);
            this.lblPasswordError.TabIndex = 38;
            this.lblPasswordError.Text = "*";
            this.lblPasswordError.Visible = false;
            // 
            // lblComfirmPasswordError
            // 
            this.lblComfirmPasswordError.AutoSize = true;
            this.lblComfirmPasswordError.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComfirmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblComfirmPasswordError.Location = new System.Drawing.Point(284, 286);
            this.lblComfirmPasswordError.Name = "lblComfirmPasswordError";
            this.lblComfirmPasswordError.Size = new System.Drawing.Size(21, 25);
            this.lblComfirmPasswordError.TabIndex = 39;
            this.lblComfirmPasswordError.Text = "*";
            this.lblComfirmPasswordError.Visible = false;
            // 
            // lblGenderSelectMale
            // 
            this.lblGenderSelectMale.AutoSize = true;
            this.lblGenderSelectMale.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderSelectMale.ForeColor = System.Drawing.Color.Red;
            this.lblGenderSelectMale.Location = new System.Drawing.Point(293, 393);
            this.lblGenderSelectMale.Name = "lblGenderSelectMale";
            this.lblGenderSelectMale.Size = new System.Drawing.Size(21, 25);
            this.lblGenderSelectMale.TabIndex = 40;
            this.lblGenderSelectMale.Text = "*";
            this.lblGenderSelectMale.Visible = false;
            this.lblGenderSelectMale.Click += new System.EventHandler(this.lblGenderSelectMale_Click);
            // 
            // lblGenderSelectFemale
            // 
            this.lblGenderSelectFemale.AutoSize = true;
            this.lblGenderSelectFemale.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderSelectFemale.ForeColor = System.Drawing.Color.Red;
            this.lblGenderSelectFemale.Location = new System.Drawing.Point(452, 393);
            this.lblGenderSelectFemale.Name = "lblGenderSelectFemale";
            this.lblGenderSelectFemale.Size = new System.Drawing.Size(21, 25);
            this.lblGenderSelectFemale.TabIndex = 41;
            this.lblGenderSelectFemale.Text = "*";
            this.lblGenderSelectFemale.Visible = false;
            // 
            // AddSellerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblGenderSelectFemale);
            this.Controls.Add(this.lblGenderSelectMale);
            this.Controls.Add(this.lblComfirmPasswordError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblPhoneNumberEmpty);
            this.Controls.Add(this.lblUsernameEmpty);
            this.Controls.Add(this.lblSalaryEmpty);
            this.Controls.Add(this.lblFullNameEmpty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpJoiningDate);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnAddSeller);
            this.Controls.Add(this.icoFemale);
            this.Controls.Add(this.icoMale);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.dtpSellerDOB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddSellerUC";
            this.Size = new System.Drawing.Size(652, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoFemale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpSellerDOB;
        private Guna.UI.WinForms.GunaMediumRadioButton rdbMale;
        private Guna.UI.WinForms.GunaMediumRadioButton rdbFemale;
        private System.Windows.Forms.PictureBox icoMale;
        private System.Windows.Forms.PictureBox icoFemale;
        private Guna.UI.WinForms.GunaButton btnAddSeller;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFullName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtConfirmPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSalary;
        private Guna.UI.WinForms.GunaButton btnClearAll;
        private Guna.UI.WinForms.GunaDateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblFullNameEmpty;
        private System.Windows.Forms.Label lblSalaryEmpty;
        private System.Windows.Forms.Label lblUsernameEmpty;
        private System.Windows.Forms.Label lblPhoneNumberEmpty;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblComfirmPasswordError;
        private System.Windows.Forms.Label lblGenderSelectMale;
        private System.Windows.Forms.Label lblGenderSelectFemale;
    }
}
