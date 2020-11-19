namespace Exam2
{
    partial class FormTable
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDecomissionedBooks = new System.Windows.Forms.TabPage();
            this.dgvDecomBooks = new System.Windows.Forms.DataGridView();
            this.tabPendingBooks = new System.Windows.Forms.TabPage();
            this.dgvPendBooks = new System.Windows.Forms.DataGridView();
            this.tabStocksBooks = new System.Windows.Forms.TabPage();
            this.dgvStocksBooks = new System.Windows.Forms.DataGridView();
            this.tabContinueBook = new System.Windows.Forms.TabPage();
            this.dgvContinueBook = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabDecomissionedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecomBooks)).BeginInit();
            this.tabPendingBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendBooks)).BeginInit();
            this.tabStocksBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocksBooks)).BeginInit();
            this.tabContinueBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContinueBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDecomissionedBooks);
            this.tabControl1.Controls.Add(this.tabPendingBooks);
            this.tabControl1.Controls.Add(this.tabStocksBooks);
            this.tabControl1.Controls.Add(this.tabContinueBook);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDecomissionedBooks
            // 
            this.tabDecomissionedBooks.Controls.Add(this.dgvDecomBooks);
            this.tabDecomissionedBooks.Location = new System.Drawing.Point(4, 29);
            this.tabDecomissionedBooks.Name = "tabDecomissionedBooks";
            this.tabDecomissionedBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecomissionedBooks.Size = new System.Drawing.Size(767, 392);
            this.tabDecomissionedBooks.TabIndex = 0;
            this.tabDecomissionedBooks.Text = "Decomissioned books";
            this.tabDecomissionedBooks.UseVisualStyleBackColor = true;
            // 
            // dgvDecomBooks
            // 
            this.dgvDecomBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecomBooks.Location = new System.Drawing.Point(6, 6);
            this.dgvDecomBooks.Name = "dgvDecomBooks";
            this.dgvDecomBooks.RowTemplate.Height = 28;
            this.dgvDecomBooks.Size = new System.Drawing.Size(755, 380);
            this.dgvDecomBooks.TabIndex = 0;
            // 
            // tabPendingBooks
            // 
            this.tabPendingBooks.Controls.Add(this.dgvPendBooks);
            this.tabPendingBooks.Location = new System.Drawing.Point(4, 29);
            this.tabPendingBooks.Name = "tabPendingBooks";
            this.tabPendingBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPendingBooks.Size = new System.Drawing.Size(767, 392);
            this.tabPendingBooks.TabIndex = 1;
            this.tabPendingBooks.Text = "Pending books";
            this.tabPendingBooks.UseVisualStyleBackColor = true;
            // 
            // dgvPendBooks
            // 
            this.dgvPendBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendBooks.Location = new System.Drawing.Point(6, 6);
            this.dgvPendBooks.Name = "dgvPendBooks";
            this.dgvPendBooks.RowTemplate.Height = 28;
            this.dgvPendBooks.Size = new System.Drawing.Size(754, 380);
            this.dgvPendBooks.TabIndex = 1;
            // 
            // tabStocksBooks
            // 
            this.tabStocksBooks.Controls.Add(this.dgvStocksBooks);
            this.tabStocksBooks.Location = new System.Drawing.Point(4, 29);
            this.tabStocksBooks.Name = "tabStocksBooks";
            this.tabStocksBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabStocksBooks.Size = new System.Drawing.Size(767, 392);
            this.tabStocksBooks.TabIndex = 2;
            this.tabStocksBooks.Text = "Books in stocks";
            this.tabStocksBooks.UseVisualStyleBackColor = true;
            // 
            // dgvStocksBooks
            // 
            this.dgvStocksBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocksBooks.Location = new System.Drawing.Point(6, 6);
            this.dgvStocksBooks.Name = "dgvStocksBooks";
            this.dgvStocksBooks.RowTemplate.Height = 28;
            this.dgvStocksBooks.Size = new System.Drawing.Size(754, 380);
            this.dgvStocksBooks.TabIndex = 2;
            // 
            // tabContinueBook
            // 
            this.tabContinueBook.Controls.Add(this.dgvContinueBook);
            this.tabContinueBook.Location = new System.Drawing.Point(4, 29);
            this.tabContinueBook.Name = "tabContinueBook";
            this.tabContinueBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabContinueBook.Size = new System.Drawing.Size(767, 392);
            this.tabContinueBook.TabIndex = 3;
            this.tabContinueBook.Text = "Continue book";
            this.tabContinueBook.UseVisualStyleBackColor = true;
            // 
            // dgvContinueBook
            // 
            this.dgvContinueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContinueBook.Location = new System.Drawing.Point(6, 6);
            this.dgvContinueBook.Name = "dgvContinueBook";
            this.dgvContinueBook.RowTemplate.Height = 28;
            this.dgvContinueBook.Size = new System.Drawing.Size(754, 380);
            this.dgvContinueBook.TabIndex = 3;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTable";
            this.Text = "Additional information";
            this.tabControl1.ResumeLayout(false);
            this.tabDecomissionedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecomBooks)).EndInit();
            this.tabPendingBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendBooks)).EndInit();
            this.tabStocksBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocksBooks)).EndInit();
            this.tabContinueBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContinueBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDecomissionedBooks;
        private System.Windows.Forms.DataGridView dgvDecomBooks;
        private System.Windows.Forms.TabPage tabPendingBooks;
        private System.Windows.Forms.DataGridView dgvPendBooks;
        private System.Windows.Forms.TabPage tabStocksBooks;
        private System.Windows.Forms.DataGridView dgvStocksBooks;
        private System.Windows.Forms.TabPage tabContinueBook;
        private System.Windows.Forms.DataGridView dgvContinueBook;
    }
}