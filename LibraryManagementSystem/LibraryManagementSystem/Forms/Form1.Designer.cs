namespace LibraryManagementSystem.Forms
{
    partial class AddBookForm
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ibtnAddBook = new FontAwesome.Sharp.IconButton();
            this.txtStock = new LibraryManagementSystem.Controls.CustomTextBox();
            this.txtCategory = new LibraryManagementSystem.Controls.CustomTextBox();
            this.txtAuthor = new LibraryManagementSystem.Controls.CustomTextBox();
            this.txtName = new LibraryManagementSystem.Controls.CustomTextBox();
            this.pnlContainer.SuspendLayout();
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
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.pnlContainer.Controls.Add(this.txtStock);
            this.pnlContainer.Controls.Add(this.txtCategory);
            this.pnlContainer.Controls.Add(this.txtAuthor);
            this.pnlContainer.Controls.Add(this.txtName);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.lblName);
            this.pnlContainer.Controls.Add(this.ibtnAddBook);
            this.pnlContainer.Location = new System.Drawing.Point(12, 53);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(381, 260);
            this.pnlContainer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(65, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(29, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(51, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(63, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 23);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // ibtnAddBook
            // 
            this.ibtnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnAddBook.FlatAppearance.BorderSize = 2;
            this.ibtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAddBook.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.ibtnAddBook.ForeColor = System.Drawing.Color.White;
            this.ibtnAddBook.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.ibtnAddBook.IconColor = System.Drawing.Color.White;
            this.ibtnAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAddBook.IconSize = 32;
            this.ibtnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAddBook.Location = new System.Drawing.Point(250, 180);
            this.ibtnAddBook.Name = "ibtnAddBook";
            this.ibtnAddBook.Size = new System.Drawing.Size(101, 47);
            this.ibtnAddBook.TabIndex = 4;
            this.ibtnAddBook.Text = "Add";
            this.ibtnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAddBook.UseVisualStyleBackColor = true;
            this.ibtnAddBook.Click += new System.EventHandler(this.ibtnAddBook_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtStock.BorderColor = System.Drawing.Color.White;
            this.txtStock.BorderSize = 2;
            this.txtStock.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtStock.ForeColor = System.Drawing.Color.White;
            this.txtStock.Location = new System.Drawing.Point(141, 165);
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.Padding = new System.Windows.Forms.Padding(7);
            this.txtStock.PasswordChar = false;
            this.txtStock.Size = new System.Drawing.Size(74, 38);
            this.txtStock.TabIndex = 6;
            this.txtStock.Texts = "";
            this.txtStock.UnderlinedStyle = true;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtCategory.BorderColor = System.Drawing.Color.White;
            this.txtCategory.BorderSize = 2;
            this.txtCategory.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCategory.ForeColor = System.Drawing.Color.White;
            this.txtCategory.Location = new System.Drawing.Point(141, 121);
            this.txtCategory.Multiline = false;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Padding = new System.Windows.Forms.Padding(7);
            this.txtCategory.PasswordChar = false;
            this.txtCategory.Size = new System.Drawing.Size(210, 38);
            this.txtCategory.TabIndex = 6;
            this.txtCategory.Texts = "";
            this.txtCategory.UnderlinedStyle = true;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtAuthor.BorderColor = System.Drawing.Color.White;
            this.txtAuthor.BorderSize = 2;
            this.txtAuthor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtAuthor.ForeColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(141, 74);
            this.txtAuthor.Multiline = false;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Padding = new System.Windows.Forms.Padding(7);
            this.txtAuthor.PasswordChar = false;
            this.txtAuthor.Size = new System.Drawing.Size(210, 38);
            this.txtAuthor.TabIndex = 6;
            this.txtAuthor.Texts = "";
            this.txtAuthor.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(141, 33);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(210, 38);
            this.txtName.TabIndex = 6;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(405, 325);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Panel pnlContainer;
        private FontAwesome.Sharp.IconButton ibtnAddBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private Controls.CustomTextBox txtStock;
        private Controls.CustomTextBox txtCategory;
        private Controls.CustomTextBox txtAuthor;
        private Controls.CustomTextBox txtName;
    }
}