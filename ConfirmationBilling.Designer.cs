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
            this.lblComfirmation = new System.Windows.Forms.Label();
            this.gifConfirmationTick = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gifConfirmationTick)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComfirmation
            // 
            this.lblComfirmation.AutoSize = true;
            this.lblComfirmation.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComfirmation.Location = new System.Drawing.Point(97, 410);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfirmationBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblComfirmation);
            this.Controls.Add(this.gifConfirmationTick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmationBilling";
            ((System.ComponentModel.ISupportInitialize)(this.gifConfirmationTick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComfirmation;
        private System.Windows.Forms.PictureBox gifConfirmationTick;
        private System.Windows.Forms.Button button1;
    }
}