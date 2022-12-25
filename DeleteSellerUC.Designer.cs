namespace CareForPaws
{
    partial class DeleteSellerUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteSellerUC));
            this.dgvSeller = new System.Windows.Forms.DataGridView();
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
            this.DeleteButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearchByID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSearchByUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSeachByName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnDeleteAll = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
            this.SuspendLayout();
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
            this.dgvSeller.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvSeller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.JoiningDate,
            this.DeleteButton});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeller.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSeller.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSeller.Location = new System.Drawing.Point(19, 177);
            this.dgvSeller.Name = "dgvSeller";
            this.dgvSeller.ReadOnly = true;
            this.dgvSeller.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeller.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSeller.RowHeadersVisible = false;
            this.dgvSeller.RowHeadersWidth = 15;
            this.dgvSeller.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSeller.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSeller.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvSeller.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSeller.RowTemplate.Height = 40;
            this.dgvSeller.RowTemplate.ReadOnly = true;
            this.dgvSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeller.Size = new System.Drawing.Size(615, 376);
            this.dgvSeller.TabIndex = 22;
            this.dgvSeller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeller_CellClick);
            this.dgvSeller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeller_CellContentClick);
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
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // 
            // FullName
            // 
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
            this.FullName.Width = 150;
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
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Salary.DefaultCellStyle = dataGridViewCellStyle6;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Salary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // JoiningDate
            // 
            this.JoiningDate.DataPropertyName = "JoiningDate";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.JoiningDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.JoiningDate.HeaderText = "Joining Date";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            this.JoiningDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.JoiningDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.JoiningDate.Width = 150;
            // 
            // DeleteButton
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle8;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Width = 40;
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
            this.txtSearchByID.TabIndex = 25;
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
            this.txtSearchByUserName.TabIndex = 24;
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
            this.txtSeachByName.TabIndex = 23;
            this.txtSeachByName.Text = "Search By Full Name";
            this.txtSeachByName.TextChanged += new System.EventHandler(this.txtSeachByName_TextChanged);
            this.txtSeachByName.Enter += new System.EventHandler(this.txtSeachByName_Enter);
            this.txtSeachByName.Leave += new System.EventHandler(this.txtSeachByName_Leave);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AnimationHoverSpeed = 0.07F;
            this.btnDeleteAll.AnimationSpeed = 0.03F;
            this.btnDeleteAll.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAll.BaseColor = System.Drawing.Color.Black;
            this.btnDeleteAll.BorderColor = System.Drawing.Color.White;
            this.btnDeleteAll.BorderSize = 1;
            this.btnDeleteAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteAll.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Image = null;
            this.btnDeleteAll.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteAll.Location = new System.Drawing.Point(515, 118);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteAll.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDeleteAll.OnHoverImage = null;
            this.btnDeleteAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteAll.OnPressedDepth = 20;
            this.btnDeleteAll.Radius = 22;
            this.btnDeleteAll.Size = new System.Drawing.Size(119, 40);
            this.btnDeleteAll.TabIndex = 29;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteAll.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnDeleteAll.UseTransfarantBackground = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // DeleteSellerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.txtSearchByUserName);
            this.Controls.Add(this.txtSeachByName);
            this.Controls.Add(this.dgvSeller);
            this.Name = "DeleteSellerUC";
            this.Size = new System.Drawing.Size(652, 570);
            this.Load += new System.EventHandler(this.DeleteSellerUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeller;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSeachByName;
        private Guna.UI.WinForms.GunaButton btnDeleteAll;
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
        private System.Windows.Forms.DataGridViewImageColumn DeleteButton;
    }
}
