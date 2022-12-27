namespace CareForPaws
{
    partial class UpdateCategoryUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCategoryUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchByID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSearchByCategoryName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCategoryNameEmpty = new System.Windows.Forms.Label();
            this.txtCategoryName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
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
            this.txtSearchByID.TabIndex = 22;
            this.txtSearchByID.Text = "Search By ID";
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            this.txtSearchByID.Enter += new System.EventHandler(this.txtSearchByID_Enter);
            this.txtSearchByID.Leave += new System.EventHandler(this.txtSearchByID_Leave);
            // 
            // txtSearchByCategoryName
            // 
            this.txtSearchByCategoryName.Location = new System.Drawing.Point(19, 68);
            this.txtSearchByCategoryName.Name = "txtSearchByCategoryName";
            this.txtSearchByCategoryName.Size = new System.Drawing.Size(264, 34);
            this.txtSearchByCategoryName.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSearchByCategoryName.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSearchByCategoryName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByCategoryName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSearchByCategoryName.StateCommon.Border.Rounding = 20;
            this.txtSearchByCategoryName.StateCommon.Border.Width = 1;
            this.txtSearchByCategoryName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSearchByCategoryName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByCategoryName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSearchByCategoryName.TabIndex = 21;
            this.txtSearchByCategoryName.Text = "Search By Category Name";
            this.txtSearchByCategoryName.TextChanged += new System.EventHandler(this.txtSearchByCategoryName_TextChanged);
            this.txtSearchByCategoryName.Enter += new System.EventHandler(this.txtSearchByCategoryName_Enter);
            this.txtSearchByCategoryName.Leave += new System.EventHandler(this.txtSearchByCategoryName_Leave);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblMessage.Location = new System.Drawing.Point(18, 131);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(424, 20);
            this.lblMessage.TabIndex = 28;
            this.lblMessage.Text = "[ Double Click On The Desired Row To Load Up Information ]";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblCategoryNameEmpty);
            this.panel2.Controls.Add(this.txtCategoryName);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Location = new System.Drawing.Point(384, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 194);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // lblCategoryNameEmpty
            // 
            this.lblCategoryNameEmpty.AutoSize = true;
            this.lblCategoryNameEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryNameEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryNameEmpty.Location = new System.Drawing.Point(10, 151);
            this.lblCategoryNameEmpty.Name = "lblCategoryNameEmpty";
            this.lblCategoryNameEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblCategoryNameEmpty.TabIndex = 37;
            this.lblCategoryNameEmpty.Text = "*";
            this.lblCategoryNameEmpty.Visible = false;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(35, 144);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.Size = new System.Drawing.Size(168, 34);
            this.txtCategoryName.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtCategoryName.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtCategoryName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCategoryName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCategoryName.StateCommon.Border.Rounding = 20;
            this.txtCategoryName.StateCommon.Border.Width = 1;
            this.txtCategoryName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtCategoryName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtCategoryName.TabIndex = 24;
            this.txtCategoryName.Text = "Category Name";
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
            this.btnClear.Location = new System.Drawing.Point(400, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.OnPressedDepth = 20;
            this.btnClear.Radius = 22;
            this.btnClear.Size = new System.Drawing.Size(94, 40);
            this.btnClear.TabIndex = 31;
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
            this.btnSave.Location = new System.Drawing.Point(506, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.OnPressedDepth = 20;
            this.btnSave.Radius = 22;
            this.btnSave.Size = new System.Drawing.Size(91, 40);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnSave.UseTransfarantBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToResizeColumns = false;
            this.dgvCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID,
            this.CategoryName,
            this.DeleteButton});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategory.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCategory.Location = new System.Drawing.Point(19, 167);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.RowHeadersWidth = 15;
            this.dgvCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategory.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategory.RowTemplate.Height = 40;
            this.dgvCategory.RowTemplate.ReadOnly = true;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(333, 386);
            this.dgvCategory.TabIndex = 32;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            this.dgvCategory.DoubleClick += new System.EventHandler(this.dgvCategory_DoubleClick);
            // 
            // C_ID
            // 
            this.C_ID.DataPropertyName = "C_ID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.C_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.C_ID.HeaderText = "ID";
            this.C_ID.Name = "C_ID";
            this.C_ID.ReadOnly = true;
            this.C_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.C_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.C_ID.Width = 80;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryName.DataPropertyName = "CategoryName";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.CategoryName.DefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteButton.Width = 40;
            // 
            // UpdateCategoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.txtSearchByCategoryName);
            this.Name = "UpdateCategoryUC";
            this.Size = new System.Drawing.Size(652, 570);
            this.Load += new System.EventHandler(this.UpdateCategoryUC_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByCategoryName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCategoryNameEmpty;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCategoryName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtID;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewImageColumn DeleteButton;
    }
}
