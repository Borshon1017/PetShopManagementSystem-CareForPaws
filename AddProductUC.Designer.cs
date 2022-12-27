namespace CareForPaws
{
    partial class AddProductUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductUC));
            this.lblQuantityEmpty = new System.Windows.Forms.Label();
            this.lblBrandEmpty = new System.Windows.Forms.Label();
            this.lblCategoryEmpty = new System.Windows.Forms.Label();
            this.lblProductNameEmpty = new System.Windows.Forms.Label();
            this.btnClearAll = new Guna.UI.WinForms.GunaButton();
            this.txtQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBrand = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProductName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddProduct = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantityEmpty
            // 
            this.lblQuantityEmpty.AutoSize = true;
            this.lblQuantityEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityEmpty.Location = new System.Drawing.Point(166, 384);
            this.lblQuantityEmpty.Name = "lblQuantityEmpty";
            this.lblQuantityEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblQuantityEmpty.TabIndex = 60;
            this.lblQuantityEmpty.Text = "*";
            this.lblQuantityEmpty.Visible = false;
            // 
            // lblBrandEmpty
            // 
            this.lblBrandEmpty.AutoSize = true;
            this.lblBrandEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblBrandEmpty.Location = new System.Drawing.Point(166, 342);
            this.lblBrandEmpty.Name = "lblBrandEmpty";
            this.lblBrandEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblBrandEmpty.TabIndex = 59;
            this.lblBrandEmpty.Text = "*";
            this.lblBrandEmpty.Visible = false;
            // 
            // lblCategoryEmpty
            // 
            this.lblCategoryEmpty.AutoSize = true;
            this.lblCategoryEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryEmpty.Location = new System.Drawing.Point(166, 448);
            this.lblCategoryEmpty.Name = "lblCategoryEmpty";
            this.lblCategoryEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblCategoryEmpty.TabIndex = 58;
            this.lblCategoryEmpty.Text = "*";
            this.lblCategoryEmpty.Visible = false;
            // 
            // lblProductNameEmpty
            // 
            this.lblProductNameEmpty.AutoSize = true;
            this.lblProductNameEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblProductNameEmpty.Location = new System.Drawing.Point(166, 297);
            this.lblProductNameEmpty.Name = "lblProductNameEmpty";
            this.lblProductNameEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblProductNameEmpty.TabIndex = 57;
            this.lblProductNameEmpty.Text = "*";
            this.lblProductNameEmpty.Visible = false;
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
            this.btnClearAll.Location = new System.Drawing.Point(194, 494);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnClearAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClearAll.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClearAll.OnHoverImage = null;
            this.btnClearAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearAll.OnPressedDepth = 20;
            this.btnClearAll.Radius = 22;
            this.btnClearAll.Size = new System.Drawing.Size(125, 47);
            this.btnClearAll.TabIndex = 53;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearAll.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnClearAll.UseTransfarantBackground = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(194, 377);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(264, 34);
            this.txtQuantity.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtQuantity.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtQuantity.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQuantity.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtQuantity.StateCommon.Border.Rounding = 20;
            this.txtQuantity.StateCommon.Border.Width = 1;
            this.txtQuantity.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtQuantity.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtQuantity.TabIndex = 52;
            this.txtQuantity.Text = "Quantity";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(194, 334);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(264, 34);
            this.txtBrand.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtBrand.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtBrand.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBrand.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBrand.StateCommon.Border.Rounding = 20;
            this.txtBrand.StateCommon.Border.Width = 1;
            this.txtBrand.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtBrand.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBrand.TabIndex = 48;
            this.txtBrand.Text = "Brand";
            this.txtBrand.TextChanged += new System.EventHandler(this.txtBrand_TextChanged);
            this.txtBrand.Enter += new System.EventHandler(this.txtBrand_Enter);
            this.txtBrand.Leave += new System.EventHandler(this.txtBrand_Leave);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(194, 291);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(264, 34);
            this.txtProductName.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtProductName.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtProductName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProductName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtProductName.StateCommon.Border.Rounding = 20;
            this.txtProductName.StateCommon.Border.Width = 1;
            this.txtProductName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtProductName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProductName.TabIndex = 47;
            this.txtProductName.Text = "Product Name";
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            this.txtProductName.Enter += new System.EventHandler(this.txtProductName_Enter);
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AnimationHoverSpeed = 0.07F;
            this.btnAddProduct.AnimationSpeed = 0.03F;
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.BaseColor = System.Drawing.Color.Black;
            this.btnAddProduct.BorderColor = System.Drawing.Color.White;
            this.btnAddProduct.BorderSize = 1;
            this.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddProduct.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = null;
            this.btnAddProduct.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddProduct.Location = new System.Drawing.Point(333, 494);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnHoverImage = null;
            this.btnAddProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnPressedDepth = 20;
            this.btnAddProduct.Radius = 22;
            this.btnAddProduct.Size = new System.Drawing.Size(125, 47);
            this.btnAddProduct.TabIndex = 46;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddProduct.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnAddProduct.UseTransfarantBackground = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BaseColor = System.Drawing.Color.White;
            this.cmbCategory.BorderColor = System.Drawing.Color.Black;
            this.cmbCategory.BorderSize = 1;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(194, 443);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.OnHoverItemBaseColor = System.Drawing.Color.Gainsboro;
            this.cmbCategory.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.cmbCategory.Radius = 12;
            this.cmbCategory.Size = new System.Drawing.Size(264, 30);
            this.cmbCategory.TabIndex = 61;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(196, 418);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 20);
            this.lblCategory.TabIndex = 62;
            this.lblCategory.Text = "Category:";
            // 
            // AddProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblQuantityEmpty);
            this.Controls.Add(this.lblBrandEmpty);
            this.Controls.Add(this.lblCategoryEmpty);
            this.Controls.Add(this.lblProductNameEmpty);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddProductUC";
            this.Size = new System.Drawing.Size(652, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuantityEmpty;
        private System.Windows.Forms.Label lblBrandEmpty;
        private System.Windows.Forms.Label lblCategoryEmpty;
        private System.Windows.Forms.Label lblProductNameEmpty;
        private Guna.UI.WinForms.GunaButton btnClearAll;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBrand;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductName;
        private Guna.UI.WinForms.GunaButton btnAddProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
    }
}
