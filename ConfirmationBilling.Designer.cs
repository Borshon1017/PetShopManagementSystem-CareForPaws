namespace CareForPaws
{
    partial class ConfirmationBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationBilling));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblComfirmation = new System.Windows.Forms.Label();
            this.gifConfirmationTick = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblThankYou = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblVatPrice = new System.Windows.Forms.Label();
            this.lblTotalCostPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblCartCost = new System.Windows.Forms.Label();
            this.lblDateToday = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvFinalCart = new System.Windows.Forms.DataGridView();
            this.ProductNameCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gifConfirmationTick)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComfirmation
            // 
            this.lblComfirmation.AutoSize = true;
            this.lblComfirmation.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComfirmation.Location = new System.Drawing.Point(90, 410);
            this.lblComfirmation.Name = "lblComfirmation";
            this.lblComfirmation.Size = new System.Drawing.Size(169, 30);
            this.lblComfirmation.TabIndex = 5;
            this.lblComfirmation.Text = "Order Confirmed";
            this.lblComfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gifConfirmationTick
            // 
            this.gifConfirmationTick.Image = ((System.Drawing.Image)(resources.GetObject("gifConfirmationTick.Image")));
            this.gifConfirmationTick.Location = new System.Drawing.Point(-116, 24);
            this.gifConfirmationTick.Name = "gifConfirmationTick";
            this.gifConfirmationTick.Size = new System.Drawing.Size(587, 346);
            this.gifConfirmationTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gifConfirmationTick.TabIndex = 4;
            this.gifConfirmationTick.TabStop = false;
            this.gifConfirmationTick.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 574);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.dgvFinalCart);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblThankYou);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 574);
            this.panel2.TabIndex = 0;
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankYou.Location = new System.Drawing.Point(46, 18);
            this.lblThankYou.MaximumSize = new System.Drawing.Size(260, 0);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(245, 72);
            this.lblThankYou.TabIndex = 42;
            this.lblThankYou.Text = "  Thank You For Shopping With Us";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblDateToday);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblTotalPrice);
            this.panel3.Controls.Add(this.lblVatPrice);
            this.panel3.Controls.Add(this.lblTotalCostPrice);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblVat);
            this.panel3.Controls.Add(this.lblCartCost);
            this.panel3.Location = new System.Drawing.Point(29, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 125);
            this.panel3.TabIndex = 43;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(145, 94);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(46, 25);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "0.00";
            // 
            // lblVatPrice
            // 
            this.lblVatPrice.AutoSize = true;
            this.lblVatPrice.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatPrice.Location = new System.Drawing.Point(111, 25);
            this.lblVatPrice.Name = "lblVatPrice";
            this.lblVatPrice.Size = new System.Drawing.Size(36, 20);
            this.lblVatPrice.TabIndex = 4;
            this.lblVatPrice.Text = "0.00";
            // 
            // lblTotalCostPrice
            // 
            this.lblTotalCostPrice.AutoSize = true;
            this.lblTotalCostPrice.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostPrice.Location = new System.Drawing.Point(112, 5);
            this.lblTotalCostPrice.Name = "lblTotalCostPrice";
            this.lblTotalCostPrice.Size = new System.Drawing.Size(36, 20);
            this.lblTotalCostPrice.TabIndex = 3;
            this.lblTotalCostPrice.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(4, 94);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(145, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Amount Paid   : ";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(5, 25);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(103, 20);
            this.lblVat.TabIndex = 1;
            this.lblVat.Text = "Vat [5%]        : ";
            // 
            // lblCartCost
            // 
            this.lblCartCost.AutoSize = true;
            this.lblCartCost.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCost.Location = new System.Drawing.Point(5, 5);
            this.lblCartCost.Name = "lblCartCost";
            this.lblCartCost.Size = new System.Drawing.Size(104, 20);
            this.lblCartCost.TabIndex = 0;
            this.lblCartCost.Text = "Cart Cost       : ";
            // 
            // lblDateToday
            // 
            this.lblDateToday.AutoSize = true;
            this.lblDateToday.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateToday.Location = new System.Drawing.Point(111, 45);
            this.lblDateToday.Name = "lblDateToday";
            this.lblDateToday.Size = new System.Drawing.Size(84, 20);
            this.lblDateToday.TabIndex = 7;
            this.lblDateToday.Text = "Date Today";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(5, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date Today   : ";
            // 
            // dgvFinalCart
            // 
            this.dgvFinalCart.AllowUserToAddRows = false;
            this.dgvFinalCart.AllowUserToDeleteRows = false;
            this.dgvFinalCart.AllowUserToResizeColumns = false;
            this.dgvFinalCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFinalCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinalCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinalCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFinalCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinalCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinalCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameCart,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinalCart.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFinalCart.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvFinalCart.Location = new System.Drawing.Point(29, 111);
            this.dgvFinalCart.Name = "dgvFinalCart";
            this.dgvFinalCart.ReadOnly = true;
            this.dgvFinalCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinalCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFinalCart.RowHeadersVisible = false;
            this.dgvFinalCart.RowHeadersWidth = 15;
            this.dgvFinalCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFinalCart.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFinalCart.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvFinalCart.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFinalCart.RowTemplate.Height = 40;
            this.dgvFinalCart.RowTemplate.ReadOnly = true;
            this.dgvFinalCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinalCart.Size = new System.Drawing.Size(290, 242);
            this.dgvFinalCart.TabIndex = 44;
            // 
            // ProductNameCart
            // 
            this.ProductNameCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductNameCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductNameCart.HeaderText = "Product Name";
            this.ProductNameCart.Name = "ProductNameCart";
            this.ProductNameCart.ReadOnly = true;
            this.ProductNameCart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductNameCart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 80;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 80;
            // 
            // ConfirmationBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblComfirmation);
            this.Controls.Add(this.gifConfirmationTick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmationBilling";
            ((System.ComponentModel.ISupportInitialize)(this.gifConfirmationTick)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComfirmation;
        private System.Windows.Forms.PictureBox gifConfirmationTick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblVatPrice;
        private System.Windows.Forms.Label lblTotalCostPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblCartCost;
        private System.Windows.Forms.Label lblDateToday;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvFinalCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}