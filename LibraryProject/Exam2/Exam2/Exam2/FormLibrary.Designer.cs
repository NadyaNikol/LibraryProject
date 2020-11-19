namespace Exam2
{
    partial class FormLibrary
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
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.boosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addToChareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChoose = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbSearch
            // 
            this.txtbSearch.Location = new System.Drawing.Point(353, 63);
            this.txtbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(246, 20);
            this.txtbSearch.TabIndex = 15;
            this.txtbSearch.Click += new System.EventHandler(this.txtbSearch_Click);
            this.txtbSearch.TextChanged += new System.EventHandler(this.txtbSearch_TextChanged);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(652, 65);
            this.comboBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(127, 21);
            this.comboBoxSearch.TabIndex = 14;
            this.comboBoxSearch.Visible = false;
            // 
            // lvBooks
            // 
            this.lvBooks.FullRowSelect = true;
            this.lvBooks.GridLines = true;
            this.lvBooks.HideSelection = false;
            this.lvBooks.Location = new System.Drawing.Point(8, 90);
            this.lvBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(771, 376);
            this.lvBooks.TabIndex = 13;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.View = System.Windows.Forms.View.Details;
            this.lvBooks.SelectedIndexChanged += new System.EventHandler(this.lvBooks_SelectedIndexChanged);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(9, 48);
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(40, 13);
            this.lblPeriod.TabIndex = 12;
            this.lblPeriod.Text = "Period:";
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Location = new System.Drawing.Point(12, 63);
            this.comboBoxPeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(127, 21);
            this.comboBoxPeriod.TabIndex = 11;
            this.comboBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriod_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boosToolStripMenuItem,
            this.toolStripMenuItem3,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // boosToolStripMenuItem
            // 
            this.boosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saleToolStripMenuItem,
            this.setAsideToolStripMenuItem,
            this.writeOffToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addToChareToolStripMenuItem});
            this.boosToolStripMenuItem.Name = "boosToolStripMenuItem";
            this.boosToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.boosToolStripMenuItem.Text = "Book";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Enabled = false;
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Enabled = false;
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saleToolStripMenuItem.Text = "To sale";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // setAsideToolStripMenuItem
            // 
            this.setAsideToolStripMenuItem.Enabled = false;
            this.setAsideToolStripMenuItem.Name = "setAsideToolStripMenuItem";
            this.setAsideToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.setAsideToolStripMenuItem.Text = "Put off";
            this.setAsideToolStripMenuItem.Click += new System.EventHandler(this.putOffToolStripMenuItem_Click);
            // 
            // writeOffToolStripMenuItem
            // 
            this.writeOffToolStripMenuItem.Enabled = false;
            this.writeOffToolStripMenuItem.Name = "writeOffToolStripMenuItem";
            this.writeOffToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.writeOffToolStripMenuItem.Text = "Write off";
            this.writeOffToolStripMenuItem.Click += new System.EventHandler(this.writeOffToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 6);
            // 
            // addToChareToolStripMenuItem
            // 
            this.addToChareToolStripMenuItem.Enabled = false;
            this.addToChareToolStripMenuItem.Name = "addToChareToolStripMenuItem";
            this.addToChareToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addToChareToolStripMenuItem.Text = "Add to share";
            this.addToChareToolStripMenuItem.Click += new System.EventHandler(this.addToChareToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendingBooksToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem3.Text = "Additional information";
            // 
            // pendingBooksToolStripMenuItem
            // 
            this.pendingBooksToolStripMenuItem.Name = "pendingBooksToolStripMenuItem";
            this.pendingBooksToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pendingBooksToolStripMenuItem.Text = "Info about books";
            this.pendingBooksToolStripMenuItem.Click += new System.EventHandler(this.infoAboutBooksToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.largeIconToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.largeIconToolStripMenuItem.Text = "Large icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Сhoose";
            // 
            // cmbChoose
            // 
            this.cmbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoose.FormattingEnabled = true;
            this.cmbChoose.Location = new System.Drawing.Point(169, 63);
            this.cmbChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbChoose.Name = "cmbChoose";
            this.cmbChoose.Size = new System.Drawing.Size(127, 21);
            this.cmbChoose.TabIndex = 18;
            this.cmbChoose.SelectedIndexChanged += new System.EventHandler(this.cmbChoose_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Exam2.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(602, 61);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 25);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(795, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChoose);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.lvBooks);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.comboBoxPeriod);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLibrary";
            this.Text = "Online library";
            this.Load += new System.EventHandler(this.FormLibrary_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem boosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addToChareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pendingBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChoose;
    }
}