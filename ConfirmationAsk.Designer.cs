namespace CareForPaws
{
    partial class ConfirmationAsk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationAsk));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblComfirmationFail = new System.Windows.Forms.Label();
            this.btnYes = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNo = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblComfirmationFail
            // 
            this.lblComfirmationFail.AutoSize = true;
            this.lblComfirmationFail.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComfirmationFail.Location = new System.Drawing.Point(12, 309);
            this.lblComfirmationFail.Name = "lblComfirmationFail";
            this.lblComfirmationFail.Size = new System.Drawing.Size(318, 30);
            this.lblComfirmationFail.TabIndex = 5;
            this.lblComfirmationFail.Text = "Are you sure you want to delete?";
            this.lblComfirmationFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.AnimationHoverSpeed = 0.07F;
            this.btnYes.AnimationSpeed = 0.03F;
            this.btnYes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYes.BorderColor = System.Drawing.Color.Black;
            this.btnYes.BorderSize = 2;
            this.btnYes.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnYes.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnYes.CheckedForeColor = System.Drawing.Color.White;
            this.btnYes.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnYes.CheckedImage")));
            this.btnYes.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYes.FocusedColor = System.Drawing.Color.Empty;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYes.ForeColor = System.Drawing.Color.Black;
            this.btnYes.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.Image")));
            this.btnYes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnYes.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnYes.Location = new System.Drawing.Point(211, 388);
            this.btnYes.Name = "btnYes";
            this.btnYes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnYes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnYes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnYes.OnHoverImage = null;
            this.btnYes.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnYes.OnPressedColor = System.Drawing.Color.Black;
            this.btnYes.Size = new System.Drawing.Size(119, 42);
            this.btnYes.TabIndex = 8;
            this.btnYes.Text = "Yes";
            this.btnYes.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.AnimationHoverSpeed = 0.07F;
            this.btnNo.AnimationSpeed = 0.03F;
            this.btnNo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNo.BorderColor = System.Drawing.Color.Black;
            this.btnNo.BorderSize = 2;
            this.btnNo.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNo.CheckedForeColor = System.Drawing.Color.White;
            this.btnNo.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnNo.CheckedImage")));
            this.btnNo.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNo.ForeColor = System.Drawing.Color.Black;
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNo.Location = new System.Drawing.Point(17, 388);
            this.btnNo.Name = "btnNo";
            this.btnNo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNo.OnHoverImage = null;
            this.btnNo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNo.Size = new System.Drawing.Size(119, 42);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "No";
            this.btnNo.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // ConfirmationAsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(350, 468);
            this.ControlBox = false;
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblComfirmationFail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationAsk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attention Required";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfirmationAsk_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblComfirmationFail;
        private Guna.UI.WinForms.GunaAdvenceButton btnYes;
        private Guna.UI.WinForms.GunaAdvenceButton btnNo;
    }
}