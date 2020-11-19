namespace Exam2
{
    partial class FormAddNewUser
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
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPasword = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbLogin
            // 
            this.txtbLogin.Location = new System.Drawing.Point(13, 53);
            this.txtbLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(398, 26);
            this.txtbLogin.TabIndex = 0;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(13, 123);
            this.txtbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(398, 26);
            this.txtbPassword.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(15, 24);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(48, 20);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // lblPasword
            // 
            this.lblPasword.AutoSize = true;
            this.lblPasword.Location = new System.Drawing.Point(15, 98);
            this.lblPasword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasword.Name = "lblPasword";
            this.lblPasword.Size = new System.Drawing.Size(78, 20);
            this.lblPasword.TabIndex = 3;
            this.lblPasword.Text = "Password";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(13, 183);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(180, 148);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 183);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 148);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPasword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAddNewUser";
            this.Text = "New user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPasword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}