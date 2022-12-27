namespace CareForPaws
{
    partial class AddCategoryUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryUC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCategoryName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddCategory = new Guna.UI.WinForms.GunaButton();
            this.lblCategoryNameEmpty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(194, 359);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(264, 34);
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
            this.txtCategoryName.TabIndex = 16;
            this.txtCategoryName.Text = "Category Name";
            this.txtCategoryName.Enter += new System.EventHandler(this.txtCategoryName_Enter);
            this.txtCategoryName.Leave += new System.EventHandler(this.txtCategoryName_Leave);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AnimationHoverSpeed = 0.07F;
            this.btnAddCategory.AnimationSpeed = 0.03F;
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCategory.BaseColor = System.Drawing.Color.Black;
            this.btnAddCategory.BorderColor = System.Drawing.Color.White;
            this.btnAddCategory.BorderSize = 1;
            this.btnAddCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddCategory.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Image = null;
            this.btnAddCategory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddCategory.Location = new System.Drawing.Point(264, 451);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnAddCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddCategory.OnHoverImage = null;
            this.btnAddCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCategory.OnPressedDepth = 20;
            this.btnAddCategory.Radius = 22;
            this.btnAddCategory.Size = new System.Drawing.Size(125, 47);
            this.btnAddCategory.TabIndex = 17;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCategory.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnAddCategory.UseTransfarantBackground = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblCategoryNameEmpty
            // 
            this.lblCategoryNameEmpty.AutoSize = true;
            this.lblCategoryNameEmpty.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryNameEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryNameEmpty.Location = new System.Drawing.Point(167, 365);
            this.lblCategoryNameEmpty.Name = "lblCategoryNameEmpty";
            this.lblCategoryNameEmpty.Size = new System.Drawing.Size(21, 25);
            this.lblCategoryNameEmpty.TabIndex = 37;
            this.lblCategoryNameEmpty.Text = "*";
            this.lblCategoryNameEmpty.Visible = false;
            // 
            // AddCategoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblCategoryNameEmpty);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddCategoryUC";
            this.Size = new System.Drawing.Size(652, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCategoryName;
        private Guna.UI.WinForms.GunaButton btnAddCategory;
        private System.Windows.Forms.Label lblCategoryNameEmpty;
    }
}
