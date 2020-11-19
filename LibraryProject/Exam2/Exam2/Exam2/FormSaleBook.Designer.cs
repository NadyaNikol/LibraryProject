namespace Exam2
{
    partial class FormSaleBook
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
            this.lblNameBook = new System.Windows.Forms.Label();
            this.txtbNameOfBook = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNameOfShop = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Location = new System.Drawing.Point(18, 14);
            this.lblNameBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(108, 20);
            this.lblNameBook.TabIndex = 12;
            this.lblNameBook.Text = "Name of book";
            // 
            // txtbNameOfBook
            // 
            this.txtbNameOfBook.Location = new System.Drawing.Point(16, 43);
            this.txtbNameOfBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNameOfBook.Name = "txtbNameOfBook";
            this.txtbNameOfBook.Size = new System.Drawing.Size(398, 26);
            this.txtbNameOfBook.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(18, 95);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(16, 122);
            this.txtbPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(398, 26);
            this.txtbPrice.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name of shop";
            // 
            // cmbNameOfShop
            // 
            this.cmbNameOfShop.FormattingEnabled = true;
            this.cmbNameOfShop.Location = new System.Drawing.Point(16, 202);
            this.cmbNameOfShop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNameOfShop.Name = "cmbNameOfShop";
            this.cmbNameOfShop.Size = new System.Drawing.Size(398, 28);
            this.cmbNameOfShop.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 364);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 148);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(13, 364);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(180, 148);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantity books";
            // 
            // txtbQuantity
            // 
            this.txtbQuantity.Location = new System.Drawing.Point(16, 284);
            this.txtbQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbQuantity.Name = "txtbQuantity";
            this.txtbQuantity.Size = new System.Drawing.Size(398, 26);
            this.txtbQuantity.TabIndex = 19;
            // 
            // FormSaleBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(426, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbNameOfShop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.lblNameBook);
            this.Controls.Add(this.txtbNameOfBook);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSaleBook";
            this.Text = "Sale book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.TextBox txtbNameOfBook;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNameOfShop;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbQuantity;
    }
}