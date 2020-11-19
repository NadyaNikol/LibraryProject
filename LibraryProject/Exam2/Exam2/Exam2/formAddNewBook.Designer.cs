namespace Exam2
{
    partial class formAddNewBook
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
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbNameOfBook = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtbAmountPages = new System.Windows.Forms.TextBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDrawingOfBook = new System.Windows.Forms.TextBox();
            this.cbNextBook = new System.Windows.Forms.CheckBox();
            this.lblNameNextBook = new System.Windows.Forms.Label();
            this.cbBookContinue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 503);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 148);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(13, 503);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(180, 148);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 102);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Location = new System.Drawing.Point(15, 20);
            this.lblNameBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(108, 20);
            this.lblNameBook.TabIndex = 10;
            this.lblNameBook.Text = "Name of book";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(14, 128);
            this.txtbPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(162, 26);
            this.txtbPrice.TabIndex = 9;
            // 
            // txtbNameOfBook
            // 
            this.txtbNameOfBook.Location = new System.Drawing.Point(14, 49);
            this.txtbNameOfBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNameOfBook.Name = "txtbNameOfBook";
            this.txtbNameOfBook.Size = new System.Drawing.Size(398, 26);
            this.txtbNameOfBook.TabIndex = 8;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(220, 102);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(113, 20);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Amount pages";
            // 
            // txtbAmountPages
            // 
            this.txtbAmountPages.Location = new System.Drawing.Point(219, 128);
            this.txtbAmountPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbAmountPages.Name = "txtbAmountPages";
            this.txtbAmountPages.Size = new System.Drawing.Size(192, 26);
            this.txtbAmountPages.TabIndex = 12;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(15, 186);
            this.lblTheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(58, 20);
            this.lblTheme.TabIndex = 15;
            this.lblTheme.Text = "Theme";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(15, 263);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 20);
            this.lblAuthor.TabIndex = 17;
            this.lblAuthor.Text = "Author";
            // 
            // cmbTheme
            // 
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Location = new System.Drawing.Point(14, 209);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(398, 28);
            this.cmbTheme.TabIndex = 18;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(14, 302);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(362, 28);
            this.cmbAuthor.TabIndex = 19;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackgroundImage = global::Exam2.Properties.Resources.add;
            this.btnAddAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAuthor.Location = new System.Drawing.Point(382, 295);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(48, 42);
            this.btnAddAuthor.TabIndex = 20;
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Drawing of book";
            // 
            // txtbDrawingOfBook
            // 
            this.txtbDrawingOfBook.Location = new System.Drawing.Point(13, 379);
            this.txtbDrawingOfBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbDrawingOfBook.Name = "txtbDrawingOfBook";
            this.txtbDrawingOfBook.Size = new System.Drawing.Size(398, 26);
            this.txtbDrawingOfBook.TabIndex = 21;
            // 
            // cbNextBook
            // 
            this.cbNextBook.AutoSize = true;
            this.cbNextBook.Location = new System.Drawing.Point(14, 448);
            this.cbNextBook.Name = "cbNextBook";
            this.cbNextBook.Size = new System.Drawing.Size(165, 24);
            this.cbNextBook.TabIndex = 23;
            this.cbNextBook.Text = "It book is next part";
            this.cbNextBook.UseVisualStyleBackColor = true;
            this.cbNextBook.CheckedChanged += new System.EventHandler(this.cbNextBook_CheckedChanged);
            // 
            // lblNameNextBook
            // 
            this.lblNameNextBook.AutoSize = true;
            this.lblNameNextBook.Location = new System.Drawing.Point(198, 424);
            this.lblNameNextBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameNextBook.Name = "lblNameNextBook";
            this.lblNameNextBook.Size = new System.Drawing.Size(108, 20);
            this.lblNameNextBook.TabIndex = 25;
            this.lblNameNextBook.Text = "Name of book";
            this.lblNameNextBook.Visible = false;
            // 
            // cbBookContinue
            // 
            this.cbBookContinue.FormattingEnabled = true;
            this.cbBookContinue.Location = new System.Drawing.Point(202, 448);
            this.cbBookContinue.Name = "cbBookContinue";
            this.cbBookContinue.Size = new System.Drawing.Size(237, 28);
            this.cbBookContinue.TabIndex = 24;
            this.cbBookContinue.Visible = false;
            // 
            // formAddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(451, 681);
            this.Controls.Add(this.lblNameNextBook);
            this.Controls.Add(this.cbBookContinue);
            this.Controls.Add(this.cbNextBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbDrawingOfBook);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtbAmountPages);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNameBook);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.txtbNameOfBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "formAddNewBook";
            this.Text = "New book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbNameOfBook;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtbAmountPages;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDrawingOfBook;
        private System.Windows.Forms.CheckBox cbNextBook;
        private System.Windows.Forms.Label lblNameNextBook;
        private System.Windows.Forms.ComboBox cbBookContinue;
    }
}