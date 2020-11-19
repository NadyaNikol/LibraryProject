namespace Exam2
{
    partial class FormPutOff
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.txtbNameOfBook = new System.Windows.Forms.TextBox();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 328);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 148);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(13, 328);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(180, 148);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 108);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 20);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Users login";
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Location = new System.Drawing.Point(15, 19);
            this.lblNameBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(108, 20);
            this.lblNameBook.TabIndex = 20;
            this.lblNameBook.Text = "Name of book";
            // 
            // txtbNameOfBook
            // 
            this.txtbNameOfBook.Location = new System.Drawing.Point(13, 48);
            this.txtbNameOfBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNameOfBook.Name = "txtbNameOfBook";
            this.txtbNameOfBook.Size = new System.Drawing.Size(398, 26);
            this.txtbNameOfBook.TabIndex = 19;
            // 
            // cmbLogin
            // 
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Location = new System.Drawing.Point(13, 140);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(396, 28);
            this.cmbLogin.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(382, 26);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Value = new System.DateTime(2019, 10, 11, 1, 35, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Expiration date";
            // 
            // FormPutOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(428, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNameBook);
            this.Controls.Add(this.txtbNameOfBook);
            this.Name = "FormPutOff";
            this.Text = "Put off";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.TextBox txtbNameOfBook;
        private System.Windows.Forms.ComboBox cmbLogin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}