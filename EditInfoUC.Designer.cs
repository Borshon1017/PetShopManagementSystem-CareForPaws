namespace CareForPaws
{
    partial class EditInfoUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInfoUC));
            this.txtSearchByID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSearchByUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSeachByName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.careForPawsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.careForPawsDataSet = new CareForPaws.CareForPawsDataSet();
            this.dgvSeller = new System.Windows.Forms.DataGridView();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbGender = new Guna.UI.WinForms.GunaComboBox();
            this.dtpJoiningDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpDOB = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblSalaryEmpty = new System.Windows.Forms.Label();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhoneNumberEmpty = new System.Windows.Forms.Label();
            this.lblDOBerror = new System.Windows.Forms.Label();
            this.lblFullNameEmpty = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txtPhoneNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSalary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtFullName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.careForPawsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careForPawsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(19, 18);
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
            this.txtSearchByUserName.Location = new System.Drawing.Point(19, 68);
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
            this.txtSeachByName.Location = new System.Drawing.Point(19, 118);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSeller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSeller.BackgroundColor = System.Drawing.Color.White;
            this.dgvSeller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSeller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U_ID,
            this.Password,
            this.Username,
            this.FullName,
            this.DOB,
            this.Phone,
            this.Gender,
            this.Salary,
            this.JoiningDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeller.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSeller.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSeller.Location = new System.Drawing.Point(20, 209);
            this.dgvSeller.Name = "dgvSeller";
            this.dgvSeller.ReadOnly = true;
            this.dgvSeller.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeller.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSeller.RowHeadersVisible = false;
            this.dgvSeller.RowHeadersWidth = 15;
            this.dgvSeller.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSeller.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSeller.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvSeller.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSeller.RowTemplate.Height = 40;
            this.dgvSeller.RowTemplate.ReadOnly = true;
            this.dgvSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeller.Size = new System.Drawing.Size(363, 340);
            this.dgvSeller.TabIndex = 21;
            this.dgvSeller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeller_CellContentClick);
            this.dgvSeller.DoubleClick += new System.EventHandler(this.dgvSeller_DoubleClick);
            // 
            // U_ID
            // 
            this.U_ID.DataPropertyName = "U_ID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.U_ID.DefaultCellStyle = dataGridViewCellStyle3;
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
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Username.DefaultCellStyle = dataGridViewCellStyle4;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Username.Width = 120;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.FullName.DefaultCellStyle = dataGridViewCellStyle5;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbGender);
            this.panel2.Controls.Add(this.dtpJoiningDate);
            this.panel2.Controls.Add(this.dtpDOB);
            this.panel2.Controls.Add(this.lblSalaryEmpty);
            this.panel2.Controls.Add(this.lblJoiningDate);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.lblPhoneNumberEmpty);
            this.panel2.Controls.Add(this.lblDOBerror);
            this.panel2.Controls.Add(this.lblFullNameEmpty);
            this.panel2.Controls.Add(this.lblPasswordError);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.gunaCirclePictureBox1);
            this.panel2.Controls.Add(this.txtPhoneNumber);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Location = new System.Drawing.Point(397, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 473);
            this.panel2.TabIndex = 24;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.BaseColor = System.Drawing.Color.White;
            this.cmbGender.BorderColor = System.Drawing.Color.Black;
            this.cmbGender.BorderSize = 1;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.ForeColor = System.Drawing.Color.Gray;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(35, 344);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.OnHoverItemBaseColor = System.Drawing.Color.Gainsboro;
            this.cmbGender.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.cmbGender.Radius = 12;
            this.cmbGender.Size = new System.Drawing.Size(168, 30);
            this.cmbGender.TabIndex = 27;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpJoiningDate.BaseColor = System.Drawing.Color.White;
            this.dtpJoiningDate.BorderColor = System.Drawing.Color.Black;
            this.dtpJoiningDate.BorderSize = 1;
            this.dtpJoiningDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoiningDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpJoiningDate.FocusedColor = System.Drawing.Color.Black;
            this.dtpJoiningDate.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.ForeColor = System.Drawing.Color.Gray;
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoiningDate.Location = new System.Drawing.Point(35, 382);
            this.dtpJoiningDate.MaxDate = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            this.dtpJoiningDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpJoiningDate.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.dtpJoiningDate.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpJoiningDate.OnPressedColor = System.Drawing.Color.Transparent;
            this.dtpJoiningDate.Radius = 11;
            this.dtpJoiningDate.Size = new System.Drawing.Size(168, 30);
            this.dtpJoiningDate.TabIndex = 46;
            this.dtpJoiningDate.Text = "12/22/2022";
            this.dtpJoiningDate.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.dtpJoiningDate.Value = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            // 
            // dtpDOB
            // 
            this.dtpDOB.BackColor = System.Drawing.Color.Transparent;
            this.dtpDOB.BaseColor = System.Drawing.Color.White;
            this.dtpDOB.BorderColor = System.Drawing.Color.Black;
            this.dtpDOB.BorderSize = 1;
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDOB.FocusedColor = System.Drawing.Color.Black;
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.ForeColor = System.Drawing.Color.Gray;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(35, 266);
            this.dtpDOB.MaxDate = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDOB.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.dtpDOB.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpDOB.OnPressedColor = System.Drawing.Color.Transparent;
            this.dtpDOB.Radius = 11;
            this.dtpDOB.Size = new System.Drawing.Size(168, 30);
            this.dtpDOB.TabIndex = 45;
            this.dtpDOB.Text = "12/22/2022";
            this.dtpDOB.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.dtpDOB.Value = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // lblSalaryEmpty
            // 
            this.lblSalaryEmpty.AutoSize = true;
            this.lblSalaryEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryEmpty.Location = new System.Drawing.Point(10, 427);
            this.lblSalaryEmpty.Name = "lblSalaryEmpty";
            this.lblSalaryEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblSalaryEmpty.TabIndex = 44;
            this.lblSalaryEmpty.Text = "*";
            this.lblSalaryEmpty.Visible = false;
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.ForeColor = System.Drawing.Color.Red;
            this.lblJoiningDate.Location = new System.Drawing.Point(10, 387);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(21, 25);
            this.lblJoiningDate.TabIndex = 43;
            this.lblJoiningDate.Text = "*";
            this.lblJoiningDate.Visible = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Red;
            this.lblGender.Location = new System.Drawing.Point(10, 350);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(21, 25);
            this.lblGender.TabIndex = 42;
            this.lblGender.Text = "*";
            this.lblGender.Visible = false;
            // 
            // lblPhoneNumberEmpty
            // 
            this.lblPhoneNumberEmpty.AutoSize = true;
            this.lblPhoneNumberEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberEmpty.Location = new System.Drawing.Point(10, 311);
            this.lblPhoneNumberEmpty.Name = "lblPhoneNumberEmpty";
            this.lblPhoneNumberEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblPhoneNumberEmpty.TabIndex = 41;
            this.lblPhoneNumberEmpty.Text = "*";
            this.lblPhoneNumberEmpty.Visible = false;
            // 
            // lblDOBerror
            // 
            this.lblDOBerror.AutoSize = true;
            this.lblDOBerror.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBerror.ForeColor = System.Drawing.Color.Red;
            this.lblDOBerror.Location = new System.Drawing.Point(10, 271);
            this.lblDOBerror.Name = "lblDOBerror";
            this.lblDOBerror.Size = new System.Drawing.Size(21, 25);
            this.lblDOBerror.TabIndex = 40;
            this.lblDOBerror.Text = "*";
            this.lblDOBerror.Visible = false;
            // 
            // lblFullNameEmpty
            // 
            this.lblFullNameEmpty.AutoSize = true;
            this.lblFullNameEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblFullNameEmpty.Location = new System.Drawing.Point(10, 232);
            this.lblFullNameEmpty.Name = "lblFullNameEmpty";
            this.lblFullNameEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblFullNameEmpty.TabIndex = 39;
            this.lblFullNameEmpty.Text = "*";
            this.lblFullNameEmpty.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(10, 192);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(21, 25);
            this.lblPasswordError.TabIndex = 38;
            this.lblPasswordError.Text = "*";
            this.lblPasswordError.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(35, 184);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(168, 34);
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
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(35, 304);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(168, 34);
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
            this.txtPhoneNumber.TabIndex = 29;
            this.txtPhoneNumber.Text = "Phone Number";
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(35, 421);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(168, 34);
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
            this.txtFullName.Location = new System.Drawing.Point(35, 224);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(168, 34);
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
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(35, 144);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(168, 34);
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
            this.txtUserName.TabIndex = 24;
            this.txtUserName.Text = "Username";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(35, 104);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(168, 34);
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
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(34, 179);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(336, 16);
            this.lblMessage.TabIndex = 27;
            this.lblMessage.Text = "[ Double Click On The Desired Row To Load Up Information ]";
            this.lblMessage.Click += new System.EventHandler(this.lblInvalidLogin_Click);
            // 
            // EditInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSeller);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.txtSearchByUserName);
            this.Controls.Add(this.txtSeachByName);
            this.Name = "EditInfoUC";
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFullName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtID;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.Label lblSalaryEmpty;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhoneNumberEmpty;
        private System.Windows.Forms.Label lblDOBerror;
        private System.Windows.Forms.Label lblFullNameEmpty;
        private System.Windows.Forms.Label lblPasswordError;
        private Guna.UI.WinForms.GunaComboBox cmbGender;
        private Guna.UI.WinForms.GunaDateTimePicker dtpJoiningDate;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
    }
}
