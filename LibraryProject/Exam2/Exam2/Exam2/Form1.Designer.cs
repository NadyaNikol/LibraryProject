namespace Exam2
{
    partial class Form1
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
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.checkBoxRegister = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewUser.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewUser.Location = new System.Drawing.Point(392, 482);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(182, 68);
            this.btnAddNewUser.TabIndex = 0;
            this.btnAddNewUser.Text = "ADD NEW USER";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Visible = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // txtbLogin
            // 
            this.txtbLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbLogin.Location = new System.Drawing.Point(153, 375);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(420, 30);
            this.txtbLogin.TabIndex = 1;
            // 
            // txtbPassword
            // 
            this.txtbPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbPassword.Location = new System.Drawing.Point(153, 435);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(420, 30);
            this.txtbPassword.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(57, 375);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(61, 19);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "LOGIN:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(14, 435);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // checkBoxRegister
            // 
            this.checkBoxRegister.AutoSize = true;
            this.checkBoxRegister.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRegister.Location = new System.Drawing.Point(153, 503);
            this.checkBoxRegister.Name = "checkBoxRegister";
            this.checkBoxRegister.Size = new System.Drawing.Size(123, 24);
            this.checkBoxRegister.TabIndex = 5;
            this.checkBoxRegister.Text = "REGISTER:";
            this.checkBoxRegister.UseVisualStyleBackColor = true;
            this.checkBoxRegister.CheckedChanged += new System.EventHandler(this.checkBoxRegister_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(386, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Online";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(340, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 81);
            this.label2.TabIndex = 7;
            this.label2.Text = "Library";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnter.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(690, 482);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(182, 68);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Exam2.Properties.Resources.library21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 572);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxRegister);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.btnAddNewUser);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox checkBoxRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnter;
    }
}

