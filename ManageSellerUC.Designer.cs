namespace CareForPaws
{
    partial class ManageSellerUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellerList = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteSeller = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddSeller = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEditInfo);
            this.panel1.Controls.Add(this.btnSellerList);
            this.panel1.Controls.Add(this.btnDeleteSeller);
            this.panel1.Controls.Add(this.btnAddSeller);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.BackColor = System.Drawing.Color.White;
            this.btnEditInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEditInfo.CheckedState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnEditInfo.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEditInfo.CheckedState.Parent = this.btnEditInfo;
            this.btnEditInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnEditInfo.CustomImages.Parent = this.btnEditInfo;
            this.btnEditInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnEditInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInfo.ForeColor = System.Drawing.Color.Black;
            this.btnEditInfo.HoverState.CustomBorderColor = System.Drawing.Color.Gainsboro;
            this.btnEditInfo.HoverState.Parent = this.btnEditInfo;
            this.btnEditInfo.Location = new System.Drawing.Point(162, 0);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.ShadowDecoration.Parent = this.btnEditInfo;
            this.btnEditInfo.Size = new System.Drawing.Size(163, 53);
            this.btnEditInfo.TabIndex = 3;
            this.btnEditInfo.Text = "Edit Info";
            this.btnEditInfo.Click += new System.EventHandler(this.btnSearchSeller_Click);
            // 
            // btnSellerList
            // 
            this.btnSellerList.BackColor = System.Drawing.Color.White;
            this.btnSellerList.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellerList.CheckedState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnSellerList.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSellerList.CheckedState.Parent = this.btnSellerList;
            this.btnSellerList.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnSellerList.CustomImages.Parent = this.btnSellerList;
            this.btnSellerList.FillColor = System.Drawing.Color.Transparent;
            this.btnSellerList.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellerList.ForeColor = System.Drawing.Color.Black;
            this.btnSellerList.HoverState.CustomBorderColor = System.Drawing.Color.Gainsboro;
            this.btnSellerList.HoverState.Parent = this.btnSellerList;
            this.btnSellerList.Location = new System.Drawing.Point(488, 0);
            this.btnSellerList.Name = "btnSellerList";
            this.btnSellerList.ShadowDecoration.Parent = this.btnSellerList;
            this.btnSellerList.Size = new System.Drawing.Size(163, 53);
            this.btnSellerList.TabIndex = 4;
            this.btnSellerList.Text = "Recover";
            this.btnSellerList.Click += new System.EventHandler(this.btnSellerList_Click);
            // 
            // btnDeleteSeller
            // 
            this.btnDeleteSeller.BackColor = System.Drawing.Color.White;
            this.btnDeleteSeller.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDeleteSeller.CheckedState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnDeleteSeller.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDeleteSeller.CheckedState.Parent = this.btnDeleteSeller;
            this.btnDeleteSeller.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDeleteSeller.CustomImages.Parent = this.btnDeleteSeller;
            this.btnDeleteSeller.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteSeller.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSeller.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSeller.HoverState.CustomBorderColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteSeller.HoverState.Parent = this.btnDeleteSeller;
            this.btnDeleteSeller.Location = new System.Drawing.Point(325, 0);
            this.btnDeleteSeller.Name = "btnDeleteSeller";
            this.btnDeleteSeller.ShadowDecoration.Parent = this.btnDeleteSeller;
            this.btnDeleteSeller.Size = new System.Drawing.Size(163, 53);
            this.btnDeleteSeller.TabIndex = 2;
            this.btnDeleteSeller.Text = "Delete Seller";
            this.btnDeleteSeller.Click += new System.EventHandler(this.btnDeleteSeller_Click);
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.BackColor = System.Drawing.Color.White;
            this.btnAddSeller.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddSeller.Checked = true;
            this.btnAddSeller.CheckedState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnAddSeller.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddSeller.CheckedState.Parent = this.btnAddSeller;
            this.btnAddSeller.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAddSeller.CustomImages.Parent = this.btnAddSeller;
            this.btnAddSeller.FillColor = System.Drawing.Color.Transparent;
            this.btnAddSeller.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSeller.ForeColor = System.Drawing.Color.Black;
            this.btnAddSeller.HoverState.CustomBorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddSeller.HoverState.Parent = this.btnAddSeller;
            this.btnAddSeller.Location = new System.Drawing.Point(-1, 0);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.ShadowDecoration.Parent = this.btnAddSeller;
            this.btnAddSeller.Size = new System.Drawing.Size(163, 53);
            this.btnAddSeller.TabIndex = 1;
            this.btnAddSeller.Text = "Add Seller";
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 570);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ManageSellerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageSellerUC";
            this.Size = new System.Drawing.Size(652, 625);
            this.Load += new System.EventHandler(this.ManageSellerUC_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddSeller;
        private Guna.UI2.WinForms.Guna2Button btnSellerList;
        private Guna.UI2.WinForms.Guna2Button btnEditInfo;
        private Guna.UI2.WinForms.Guna2Button btnDeleteSeller;
        private System.Windows.Forms.Panel panel2;
    }
}
