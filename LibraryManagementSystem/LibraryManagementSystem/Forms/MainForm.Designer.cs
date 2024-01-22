﻿namespace LibraryManagementSystem
{
    partial class formMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopGrip = new System.Windows.Forms.Panel();
            this.ibtnMinimize = new FontAwesome.Sharp.IconButton();
            this.ibtnMaximize = new FontAwesome.Sharp.IconButton();
            this.ibtnExit = new FontAwesome.Sharp.IconButton();
            this.pnlSideNavBar = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.ibtnSignIn = new FontAwesome.Sharp.IconButton();
            this.ibtnBooks = new FontAwesome.Sharp.IconButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlTopGrip.SuspendLayout();
            this.pnlSideNavBar.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopGrip
            // 
            this.pnlTopGrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.pnlTopGrip.Controls.Add(this.ibtnMinimize);
            this.pnlTopGrip.Controls.Add(this.ibtnMaximize);
            this.pnlTopGrip.Controls.Add(this.ibtnExit);
            this.pnlTopGrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopGrip.Location = new System.Drawing.Point(0, 0);
            this.pnlTopGrip.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlTopGrip.Name = "pnlTopGrip";
            this.pnlTopGrip.Size = new System.Drawing.Size(1070, 34);
            this.pnlTopGrip.TabIndex = 0;
            this.pnlTopGrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopGrip_MouseDown);
            // 
            // ibtnMinimize
            // 
            this.ibtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ibtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnMinimize.FlatAppearance.BorderSize = 0;
            this.ibtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ibtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ibtnMinimize.IconColor = System.Drawing.Color.White;
            this.ibtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMinimize.IconSize = 32;
            this.ibtnMinimize.Location = new System.Drawing.Point(968, 0);
            this.ibtnMinimize.Name = "ibtnMinimize";
            this.ibtnMinimize.Size = new System.Drawing.Size(34, 34);
            this.ibtnMinimize.TabIndex = 2;
            this.ibtnMinimize.UseVisualStyleBackColor = false;
            this.ibtnMinimize.Click += new System.EventHandler(this.ibtnMinimize_Click);
            // 
            // ibtnMaximize
            // 
            this.ibtnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ibtnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnMaximize.FlatAppearance.BorderSize = 0;
            this.ibtnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ibtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.ibtnMaximize.IconColor = System.Drawing.Color.White;
            this.ibtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMaximize.IconSize = 32;
            this.ibtnMaximize.Location = new System.Drawing.Point(1002, 0);
            this.ibtnMaximize.Name = "ibtnMaximize";
            this.ibtnMaximize.Size = new System.Drawing.Size(34, 34);
            this.ibtnMaximize.TabIndex = 1;
            this.ibtnMaximize.UseVisualStyleBackColor = false;
            this.ibtnMaximize.Click += new System.EventHandler(this.ibtnMaximize_Click);
            // 
            // ibtnExit
            // 
            this.ibtnExit.BackColor = System.Drawing.Color.Transparent;
            this.ibtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnExit.FlatAppearance.BorderSize = 0;
            this.ibtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ibtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ibtnExit.IconColor = System.Drawing.Color.White;
            this.ibtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExit.IconSize = 32;
            this.ibtnExit.Location = new System.Drawing.Point(1036, 0);
            this.ibtnExit.Name = "ibtnExit";
            this.ibtnExit.Size = new System.Drawing.Size(34, 34);
            this.ibtnExit.TabIndex = 0;
            this.ibtnExit.UseVisualStyleBackColor = false;
            this.ibtnExit.Click += new System.EventHandler(this.ibtnExit_Click);
            // 
            // pnlSideNavBar
            // 
            this.pnlSideNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.pnlSideNavBar.Controls.Add(this.pnlButtons);
            this.pnlSideNavBar.Controls.Add(this.lblUsername);
            this.pnlSideNavBar.Controls.Add(this.pictureBox1);
            this.pnlSideNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideNavBar.Location = new System.Drawing.Point(0, 34);
            this.pnlSideNavBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlSideNavBar.Name = "pnlSideNavBar";
            this.pnlSideNavBar.Size = new System.Drawing.Size(215, 586);
            this.pnlSideNavBar.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.Controls.Add(this.ibtnSignIn);
            this.pnlButtons.Controls.Add(this.ibtnBooks);
            this.pnlButtons.Location = new System.Drawing.Point(0, 229);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(215, 357);
            this.pnlButtons.TabIndex = 2;
            // 
            // ibtnSignIn
            // 
            this.ibtnSignIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ibtnSignIn.FlatAppearance.BorderSize = 0;
            this.ibtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSignIn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ibtnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ibtnSignIn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnSignIn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ibtnSignIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSignIn.IconSize = 32;
            this.ibtnSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSignIn.Location = new System.Drawing.Point(0, 302);
            this.ibtnSignIn.Name = "ibtnSignIn";
            this.ibtnSignIn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnSignIn.Size = new System.Drawing.Size(215, 55);
            this.ibtnSignIn.TabIndex = 1;
            this.ibtnSignIn.Text = "Sign In";
            this.ibtnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSignIn.UseVisualStyleBackColor = true;
            this.ibtnSignIn.Click += new System.EventHandler(this.ibtnSignIn_Click);
            // 
            // ibtnBooks
            // 
            this.ibtnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ibtnBooks.FlatAppearance.BorderSize = 0;
            this.ibtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBooks.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ibtnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ibtnBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.ibtnBooks.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ibtnBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBooks.IconSize = 32;
            this.ibtnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnBooks.Location = new System.Drawing.Point(0, 0);
            this.ibtnBooks.Name = "ibtnBooks";
            this.ibtnBooks.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnBooks.Size = new System.Drawing.Size(215, 55);
            this.ibtnBooks.TabIndex = 0;
            this.ibtnBooks.Text = "Books";
            this.ibtnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnBooks.UseVisualStyleBackColor = true;
            this.ibtnBooks.Click += new System.EventHandler(this.ibtnBooks_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblUsername.Location = new System.Drawing.Point(65, 172);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Visitor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.pictureBox1.Location = new System.Drawing.Point(35, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(215, 34);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(855, 586);
            this.pnlContainer.TabIndex = 2;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1070, 620);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSideNavBar);
            this.Controls.Add(this.pnlTopGrip);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1070, 620);
            this.Name = "formMain";
            this.Text = "Form1";
            this.pnlTopGrip.ResumeLayout(false);
            this.pnlSideNavBar.ResumeLayout(false);
            this.pnlSideNavBar.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopGrip;
        private System.Windows.Forms.Panel pnlSideNavBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlButtons;
        private FontAwesome.Sharp.IconButton ibtnBooks;
        private FontAwesome.Sharp.IconButton ibtnSignIn;
        private System.Windows.Forms.Panel pnlContainer;
        private FontAwesome.Sharp.IconButton ibtnExit;
        private FontAwesome.Sharp.IconButton ibtnMinimize;
        private FontAwesome.Sharp.IconButton ibtnMaximize;
    }
}
