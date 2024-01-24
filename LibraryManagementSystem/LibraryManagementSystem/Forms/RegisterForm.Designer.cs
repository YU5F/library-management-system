namespace LibraryManagementSystem.Forms
{
    partial class RegisterForm
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
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picturePhoto = new System.Windows.Forms.PictureBox();
            this.btnPhotoSelect = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtSurname = new LibraryManagementSystem.Controls.CustomTextBox();
            this.txtPassword = new LibraryManagementSystem.Controls.CustomTextBox();
            this.txtEmail = new LibraryManagementSystem.Controls.CustomTextBox();
            this.txtName = new LibraryManagementSystem.Controls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnBack.IconColor = System.Drawing.Color.White;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(80, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(314, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(82, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(39, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(79, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Photo";
            // 
            // picturePhoto
            // 
            this.picturePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.picturePhoto.Location = new System.Drawing.Point(293, 214);
            this.picturePhoto.Name = "picturePhoto";
            this.picturePhoto.Size = new System.Drawing.Size(92, 91);
            this.picturePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePhoto.TabIndex = 5;
            this.picturePhoto.TabStop = false;
            // 
            // btnPhotoSelect
            // 
            this.btnPhotoSelect.FlatAppearance.BorderSize = 2;
            this.btnPhotoSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhotoSelect.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhotoSelect.ForeColor = System.Drawing.Color.White;
            this.btnPhotoSelect.Location = new System.Drawing.Point(158, 214);
            this.btnPhotoSelect.Name = "btnPhotoSelect";
            this.btnPhotoSelect.Size = new System.Drawing.Size(92, 28);
            this.btnPhotoSelect.TabIndex = 6;
            this.btnPhotoSelect.Text = "Select";
            this.btnPhotoSelect.UseVisualStyleBackColor = true;
            this.btnPhotoSelect.Click += new System.EventHandler(this.btnPhotoSelect_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(439, 245);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 41);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.txtSurname.BorderColor = System.Drawing.Color.White;
            this.txtSurname.BorderSize = 2;
            this.txtSurname.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(427, 67);
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Padding = new System.Windows.Forms.Padding(7);
            this.txtSurname.PasswordChar = false;
            this.txtSurname.Size = new System.Drawing.Size(127, 38);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.Texts = "";
            this.txtSurname.UnderlinedStyle = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(156, 152);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(398, 38);
            this.txtPassword.TabIndex = 4;
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
            this.txtEmail.Location = new System.Drawing.Point(156, 108);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(398, 38);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(156, 67);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(127, 38);
            this.txtName.TabIndex = 1;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(593, 317);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnPhotoSelect);
            this.Controls.Add(this.picturePhoto);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblName;
        private Controls.CustomTextBox txtName;
        private System.Windows.Forms.Label label1;
        private Controls.CustomTextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private Controls.CustomTextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private Controls.CustomTextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picturePhoto;
        private System.Windows.Forms.Button btnPhotoSelect;
        private System.Windows.Forms.Button btnRegister;
    }
}