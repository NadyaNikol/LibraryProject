namespace Exam2
{
    partial class FormPublishBook
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
            this.lblDatePubHouse = new System.Windows.Forms.Label();
            this.dtpDatePublishing = new System.Windows.Forms.DateTimePicker();
            this.cmbNamePubHouse = new System.Windows.Forms.ComboBox();
            this.lblbNamePubHouse = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatePubHouse
            // 
            this.lblDatePubHouse.AutoSize = true;
            this.lblDatePubHouse.Location = new System.Drawing.Point(13, 119);
            this.lblDatePubHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatePubHouse.Name = "lblDatePubHouse";
            this.lblDatePubHouse.Size = new System.Drawing.Size(137, 20);
            this.lblDatePubHouse.TabIndex = 30;
            this.lblDatePubHouse.Text = "Date of publishing";
            // 
            // dtpDatePublishing
            // 
            this.dtpDatePublishing.Location = new System.Drawing.Point(12, 159);
            this.dtpDatePublishing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDatePublishing.Name = "dtpDatePublishing";
            this.dtpDatePublishing.Size = new System.Drawing.Size(397, 26);
            this.dtpDatePublishing.TabIndex = 29;
            // 
            // cmbNamePubHouse
            // 
            this.cmbNamePubHouse.FormattingEnabled = true;
            this.cmbNamePubHouse.Location = new System.Drawing.Point(12, 62);
            this.cmbNamePubHouse.Name = "cmbNamePubHouse";
            this.cmbNamePubHouse.Size = new System.Drawing.Size(397, 28);
            this.cmbNamePubHouse.TabIndex = 27;
            // 
            // lblbNamePubHouse
            // 
            this.lblbNamePubHouse.AutoSize = true;
            this.lblbNamePubHouse.Location = new System.Drawing.Point(13, 23);
            this.lblbNamePubHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbNamePubHouse.Name = "lblbNamePubHouse";
            this.lblbNamePubHouse.Size = new System.Drawing.Size(193, 20);
            this.lblbNamePubHouse.TabIndex = 26;
            this.lblbNamePubHouse.Text = "Name of Publishing house";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 230);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 148);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 230);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(180, 148);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormPublishBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(427, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblDatePubHouse);
            this.Controls.Add(this.dtpDatePublishing);
            this.Controls.Add(this.cmbNamePubHouse);
            this.Controls.Add(this.lblbNamePubHouse);
            this.Name = "FormPublishBook";
            this.Text = "Publish book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatePubHouse;
        private System.Windows.Forms.DateTimePicker dtpDatePublishing;
        private System.Windows.Forms.ComboBox cmbNamePubHouse;
        private System.Windows.Forms.Label lblbNamePubHouse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}