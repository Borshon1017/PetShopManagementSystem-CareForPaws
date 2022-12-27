namespace CareForPaws
{
    partial class AdminTransactionHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtSearchByPurchaseDate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSearchByID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.T_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(300, 80);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(97, 15);
            this.lblMessage.TabIndex = 41;
            this.lblMessage.Text = "[ YYYY-MM-DD ]";
            // 
            // txtSearchByPurchaseDate
            // 
            this.txtSearchByPurchaseDate.Location = new System.Drawing.Point(25, 71);
            this.txtSearchByPurchaseDate.Name = "txtSearchByPurchaseDate";
            this.txtSearchByPurchaseDate.Size = new System.Drawing.Size(264, 34);
            this.txtSearchByPurchaseDate.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSearchByPurchaseDate.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSearchByPurchaseDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByPurchaseDate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSearchByPurchaseDate.StateCommon.Border.Rounding = 20;
            this.txtSearchByPurchaseDate.StateCommon.Border.Width = 1;
            this.txtSearchByPurchaseDate.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSearchByPurchaseDate.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByPurchaseDate.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSearchByPurchaseDate.TabIndex = 40;
            this.txtSearchByPurchaseDate.Text = "Search By Purchase Date";
            this.txtSearchByPurchaseDate.TextChanged += new System.EventHandler(this.txtSearchByPurchaseDate_TextChanged);
            this.txtSearchByPurchaseDate.Enter += new System.EventHandler(this.txtSearchByPurchaseDate_Enter);
            this.txtSearchByPurchaseDate.Leave += new System.EventHandler(this.txtSearchByPurchaseDate_Leave);
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(24, 21);
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
            this.txtSearchByID.TabIndex = 39;
            this.txtSearchByID.Text = "Search By ID";
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            this.txtSearchByID.Enter += new System.EventHandler(this.txtSearchByID_Enter);
            this.txtSearchByID.Leave += new System.EventHandler(this.txtSearchByID_Leave);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToResizeColumns = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.T_ID,
            this.S_ID,
            this.ProductName,
            this.AmountPaid,
            this.PurchaseDate});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvTransaction.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTransaction.Location = new System.Drawing.Point(25, 134);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowHeadersWidth = 15;
            this.dgvTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTransaction.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvTransaction.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvTransaction.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTransaction.RowTemplate.Height = 40;
            this.dgvTransaction.RowTemplate.ReadOnly = true;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(602, 469);
            this.dgvTransaction.TabIndex = 42;
            // 
            // T_ID
            // 
            this.T_ID.DataPropertyName = "T_ID";
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            this.T_ID.DefaultCellStyle = dataGridViewCellStyle31;
            this.T_ID.HeaderText = "ID";
            this.T_ID.Name = "T_ID";
            this.T_ID.ReadOnly = true;
            this.T_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.T_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.T_ID.Width = 80;
            // 
            // S_ID
            // 
            this.S_ID.DataPropertyName = "S_ID";
            this.S_ID.HeaderText = "Seller ID";
            this.S_ID.Name = "S_ID";
            this.S_ID.ReadOnly = true;
            this.S_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.S_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.S_ID.Width = 80;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle32.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle32;
            this.ProductName.HeaderText = "Customer Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AmountPaid
            // 
            this.AmountPaid.DataPropertyName = "AmountPaid";
            this.AmountPaid.HeaderText = "Amount Paid";
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ReadOnly = true;
            this.AmountPaid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AmountPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AmountPaid.Width = 160;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PurchaseDate.Width = 160;
            // 
            // AdminTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtSearchByPurchaseDate);
            this.Controls.Add(this.txtSearchByID);
            this.Name = "AdminTransactionHistory";
            this.Size = new System.Drawing.Size(652, 625);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByPurchaseDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByID;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
    }
}
