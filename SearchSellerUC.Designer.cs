namespace CareForPaws
{
    partial class SearchSellerUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSellerUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchByID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSearchByUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSeachByName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.careForPawsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.careForPawsDataSet = new CareForPaws.CareForPawsDataSet();
            this.dgvSeller = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txtJoiningDate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtGender = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPhone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDOB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtFullName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.careForPawsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careForPawsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(20, 18);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(264, 34);
            this.txtSearchByID.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSearchByID.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSearchByID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByID.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSearchByID.StateCommon.Border.Rounding = 20;
            this.txtSearchByID.StateCommon.Border.Width = 1;
            this.txtSearchByID.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSearchByID.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSearchByID.TabIndex = 20;
            this.txtSearchByID.Text = "Search By ID";
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            this.txtSearchByID.Enter += new System.EventHandler(this.txtSearchByID_Enter);
            this.txtSearchByID.Leave += new System.EventHandler(this.txtSearchByID_Leave);
            // 
            // txtSearchByUserName
            // 
            this.txtSearchByUserName.Location = new System.Drawing.Point(20, 68);
            this.txtSearchByUserName.Name = "txtSearchByUserName";
            this.txtSearchByUserName.Size = new System.Drawing.Size(264, 34);
            this.txtSearchByUserName.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSearchByUserName.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSearchByUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByUserName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSearchByUserName.StateCommon.Border.Rounding = 20;
            this.txtSearchByUserName.StateCommon.Border.Width = 1;
            this.txtSearchByUserName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSearchByUserName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByUserName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSearchByUserName.TabIndex = 19;
            this.txtSearchByUserName.Text = "Search By Username";
            this.txtSearchByUserName.TextChanged += new System.EventHandler(this.txtSearchByUserName_TextChanged);
            this.txtSearchByUserName.Enter += new System.EventHandler(this.txtSearchByUserName_Enter);
            this.txtSearchByUserName.Leave += new System.EventHandler(this.txtSearchByUserName_Leave);
            // 
            // txtSeachByName
            // 
            this.txtSeachByName.Location = new System.Drawing.Point(20, 118);
            this.txtSeachByName.Name = "txtSeachByName";
            this.txtSeachByName.Size = new System.Drawing.Size(264, 34);
            this.txtSeachByName.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSeachByName.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSeachByName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSeachByName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSeachByName.StateCommon.Border.Rounding = 20;
            this.txtSeachByName.StateCommon.Border.Width = 1;
            this.txtSeachByName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSeachByName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachByName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSeachByName.TabIndex = 18;
            this.txtSeachByName.Text = "Search By Full Name";
            this.txtSeachByName.TextChanged += new System.EventHandler(this.txtSeachByName_TextChanged);
            this.txtSeachByName.Enter += new System.EventHandler(this.txtSeachByName_Enter);
            this.txtSeachByName.Leave += new System.EventHandler(this.txtSeachByName_Leave);
            // 
            // careForPawsDataSetBindingSource
            // 
            this.careForPawsDataSetBindingSource.DataSource = this.careForPawsDataSet;
            this.careForPawsDataSetBindingSource.Position = 0;
            // 
            // careForPawsDataSet
            // 
            this.careForPawsDataSet.DataSetName = "CareForPawsDataSet";
            this.careForPawsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvSeller
            // 
            this.dgvSeller.AllowUserToAddRows = false;
            this.dgvSeller.AllowUserToDeleteRows = false;
            this.dgvSeller.AllowUserToResizeColumns = false;
            this.dgvSeller.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSeller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSeller.BackgroundColor = System.Drawing.Color.White;
            this.dgvSeller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSeller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U_ID,
            this.Password,
            this.Picture,
            this.Username,
            this.FullName,
            this.DOB,
            this.Phone,
            this.Gender,
            this.Salary,
            this.JoiningDate});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeller.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSeller.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSeller.Location = new System.Drawing.Point(20, 176);
            this.dgvSeller.Name = "dgvSeller";
            this.dgvSeller.ReadOnly = true;
            this.dgvSeller.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeller.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSeller.RowHeadersWidth = 15;
            this.dgvSeller.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSeller.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSeller.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvSeller.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSeller.RowTemplate.Height = 40;
            this.dgvSeller.RowTemplate.ReadOnly = true;
            this.dgvSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeller.Size = new System.Drawing.Size(363, 373);
            this.dgvSeller.TabIndex = 21;
            this.dgvSeller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeller_CellContentClick);
            this.dgvSeller.DoubleClick += new System.EventHandler(this.dgvSeller_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.gunaCirclePictureBox1);
            this.panel2.Controls.Add(this.txtJoiningDate);
            this.panel2.Controls.Add(this.txtGender);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtDOB);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Location = new System.Drawing.Point(397, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 473);
            this.panel2.TabIndex = 24;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 186);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(213, 34);
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
            this.txtPassword.TabIndex = 33;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(75, 11);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(85, 85);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 32;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // txtJoiningDate
            // 
            this.txtJoiningDate.Location = new System.Drawing.Point(12, 386);
            this.txtJoiningDate.Name = "txtJoiningDate";
            this.txtJoiningDate.ReadOnly = true;
            this.txtJoiningDate.Size = new System.Drawing.Size(213, 34);
            this.txtJoiningDate.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtJoiningDate.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtJoiningDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJoiningDate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtJoiningDate.StateCommon.Border.Rounding = 20;
            this.txtJoiningDate.StateCommon.Border.Width = 1;
            this.txtJoiningDate.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtJoiningDate.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoiningDate.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtJoiningDate.TabIndex = 31;
            this.txtJoiningDate.Text = "Joining Date";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(12, 346);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(213, 34);
            this.txtGender.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtGender.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtGender.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGender.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtGender.StateCommon.Border.Rounding = 20;
            this.txtGender.StateCommon.Border.Width = 1;
            this.txtGender.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtGender.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtGender.TabIndex = 30;
            this.txtGender.Text = "Gender";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 306);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(213, 34);
            this.txtPhone.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtPhone.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtPhone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhone.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPhone.StateCommon.Border.Rounding = 20;
            this.txtPhone.StateCommon.Border.Width = 1;
            this.txtPhone.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPhone.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPhone.TabIndex = 29;
            this.txtPhone.Text = "Phone Number";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(12, 266);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(213, 34);
            this.txtDOB.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtDOB.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtDOB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDOB.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDOB.StateCommon.Border.Rounding = 20;
            this.txtDOB.StateCommon.Border.Width = 1;
            this.txtDOB.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtDOB.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtDOB.TabIndex = 26;
            this.txtDOB.Text = "Date Of Birth";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(12, 426);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(213, 34);
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
            this.txtSalary.TabIndex = 28;
            this.txtSalary.Text = "Salary";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(12, 226);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(213, 34);
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
            this.txtFullName.TabIndex = 25;
            this.txtFullName.Text = "Full Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 146);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(213, 34);
            this.txtUsername.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtUsername.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUsername.StateCommon.Border.Rounding = 20;
            this.txtUsername.StateCommon.Border.Width = 1;
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUsername.TabIndex = 24;
            this.txtUsername.Text = "Username";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 106);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(213, 34);
            this.txtID.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtID.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtID.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtID.StateCommon.Border.Rounding = 20;
            this.txtID.StateCommon.Border.Width = 1;
            this.txtID.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtID.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtID.TabIndex = 23;
            this.txtID.Text = "ID";
            // 
            // U_ID
            // 
            this.U_ID.DataPropertyName = "U_ID";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.U_ID.DefaultCellStyle = dataGridViewCellStyle11;
            this.U_ID.HeaderText = "ID";
            this.U_ID.Name = "U_ID";
            this.U_ID.ReadOnly = true;
            this.U_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.U_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.U_ID.Width = 50;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // Picture
            // 
            this.Picture.HeaderText = "";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Picture.Width = 35;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.Username.DefaultCellStyle = dataGridViewCellStyle12;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Username.Width = 80;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.FullName.DefaultCellStyle = dataGridViewCellStyle13;
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "Date Of Birth";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Visible = false;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone Number";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Visible = false;
            // 
            // JoiningDate
            // 
            this.JoiningDate.DataPropertyName = "JoiningDate";
            this.JoiningDate.HeaderText = "Joining Date";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            this.JoiningDate.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BaseColor = System.Drawing.Color.Black;
            this.btnClear.BorderColor = System.Drawing.Color.White;
            this.btnClear.BorderSize = 1;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.FocusedColor = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = null;
            this.btnClear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(418, 509);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.OnPressedDepth = 20;
            this.btnClear.Radius = 22;
            this.btnClear.Size = new System.Drawing.Size(94, 40);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnClear.UseTransfarantBackground = true;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BaseColor = System.Drawing.Color.Black;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderSize = 1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(524, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.OnPressedDepth = 20;
            this.btnSave.Radius = 22;
            this.btnSave.Size = new System.Drawing.Size(91, 40);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnSave.UseTransfarantBackground = true;
            // 
            // SearchSellerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSeller);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.txtSearchByUserName);
            this.Controls.Add(this.txtSeachByName);
            this.Name = "SearchSellerUC";
            this.Size = new System.Drawing.Size(652, 570);
            this.Load += new System.EventHandler(this.SearchSellerUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.careForPawsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careForPawsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSeachByName;
        private System.Windows.Forms.BindingSource careForPawsDataSetBindingSource;
        private CareForPawsDataSet careForPawsDataSet;
        private System.Windows.Forms.DataGridView dgvSeller;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtJoiningDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGender;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDOB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFullName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtID;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaButton btnSave;
    }
}
