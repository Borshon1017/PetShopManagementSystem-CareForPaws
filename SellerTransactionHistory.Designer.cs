namespace CareForPaws
{
    partial class SellerTransactionHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.txtSearchByPurchaseDate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSearchByID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.T_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToResizeColumns = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.T_ID,
            this.ProductName,
            this.AmountPaid,
            this.PurchaseDate});
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle40;
            this.dgvTransaction.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTransaction.Location = new System.Drawing.Point(24, 132);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowHeadersWidth = 15;
            this.dgvTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTransaction.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvTransaction.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvTransaction.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTransaction.RowTemplate.Height = 40;
            this.dgvTransaction.RowTemplate.ReadOnly = true;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(602, 469);
            this.dgvTransaction.TabIndex = 35;
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
            this.txtSearchByPurchaseDate.TabIndex = 37;
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
            this.txtSearchByID.TabIndex = 36;
            this.txtSearchByID.Text = "Search By ID";
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            this.txtSearchByID.Enter += new System.EventHandler(this.txtSearchByID_Enter);
            this.txtSearchByID.Leave += new System.EventHandler(this.txtSearchByID_Leave);
            // 
            // T_ID
            // 
            this.T_ID.DataPropertyName = "T_ID";
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Black;
            this.T_ID.DefaultCellStyle = dataGridViewCellStyle38;
            this.T_ID.HeaderText = "ID";
            this.T_ID.Name = "T_ID";
            this.T_ID.ReadOnly = true;
            this.T_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.T_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.T_ID.Width = 80;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle39.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle39;
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
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(300, 80);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(97, 15);
            this.lblMessage.TabIndex = 38;
            this.lblMessage.Text = "[ YYYY-MM-DD ]";
            // 
            // SellerTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtSearchByPurchaseDate);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.dgvTransaction);
            this.Name = "SellerTransactionHistory";
            this.Size = new System.Drawing.Size(652, 625);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByPurchaseDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByID;
        private System.Windows.Forms.Label lblMessage;
    }
}
