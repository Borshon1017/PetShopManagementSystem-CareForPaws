﻿namespace CareForPaws
{
    partial class ConfirmationError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationError));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WhitePanel = new System.Windows.Forms.Panel();
            this.lblComfirmationFail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.WhitePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-81, -75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WhitePanel
            // 
            this.WhitePanel.Controls.Add(this.lblComfirmationFail);
            this.WhitePanel.Location = new System.Drawing.Point(-1, 313);
            this.WhitePanel.Name = "WhitePanel";
            this.WhitePanel.Size = new System.Drawing.Size(338, 82);
            this.WhitePanel.TabIndex = 1;
            // 
            // lblComfirmationFail
            // 
            this.lblComfirmationFail.AutoSize = true;
            this.lblComfirmationFail.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComfirmationFail.Location = new System.Drawing.Point(14, 12);
            this.lblComfirmationFail.MaximumSize = new System.Drawing.Size(348, 0);
            this.lblComfirmationFail.Name = "lblComfirmationFail";
            this.lblComfirmationFail.Size = new System.Drawing.Size(298, 60);
            this.lblComfirmationFail.TabIndex = 4;
            this.lblComfirmationFail.Text = "Password can not be Less than\r\n 4 characters";
            this.lblComfirmationFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComfirmationFail.Click += new System.EventHandler(this.lblComfirmationFail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password Mismatch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // ConfirmationError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 396);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WhitePanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.WhitePanel.ResumeLayout(false);
            this.WhitePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel WhitePanel;
        private System.Windows.Forms.Label lblComfirmationFail;
        private System.Windows.Forms.Label label1;
    }
}