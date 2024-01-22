namespace LibraryManagementSystem.Forms
{
    partial class LoginForm
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
            this.lblMail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new LibraryManagementSystem.Controls.CustomTextBox();
            this.txtEmail = new LibraryManagementSystem.Controls.CustomTextBox();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblMail.Location = new System.Drawing.Point(111, 86);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(70, 23);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(68, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(249, 115);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.Size = new System.Drawing.Size(250, 38);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.txtEmail.BorderColor = System.Drawing.Color.White;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(249, 71);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(250, 38);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(593, 317);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMail);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label label1;
        private Controls.CustomTextBox txtEmail;
        private Controls.CustomTextBox txtPassword;
    }
}