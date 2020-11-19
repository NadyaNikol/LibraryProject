namespace Exam2
{
    partial class FormAddNewAuthor
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
            this.lblLN = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.txtbFN = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtbLN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(15, 102);
            this.lblLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(84, 20);
            this.lblLN.TabIndex = 23;
            this.lblLN.Text = "Last name";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(15, 21);
            this.lblFN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(84, 20);
            this.lblFN.TabIndex = 22;
            this.lblFN.Text = "First name";
            // 
            // txtbFN
            // 
            this.txtbFN.Location = new System.Drawing.Point(13, 50);
            this.txtbFN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbFN.Name = "txtbFN";
            this.txtbFN.Size = new System.Drawing.Size(398, 26);
            this.txtbFN.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 200);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 148);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(13, 200);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(180, 148);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtbLN
            // 
            this.txtbLN.Location = new System.Drawing.Point(13, 140);
            this.txtbLN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbLN.Name = "txtbLN";
            this.txtbLN.Size = new System.Drawing.Size(398, 26);
            this.txtbLN.TabIndex = 24;
            // 
            // FormAddNewAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(432, 374);
            this.Controls.Add(this.txtbLN);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.txtbFN);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "FormAddNewAuthor";
            this.Text = "New author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.TextBox txtbFN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtbLN;
    }
}