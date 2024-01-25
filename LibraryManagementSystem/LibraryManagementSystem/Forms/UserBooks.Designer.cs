namespace LibraryManagementSystem.Forms
{
    partial class UserBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwUserBooks = new System.Windows.Forms.DataGridView();
            this.pnlDownBar = new System.Windows.Forms.Panel();
            this.ibtnReturnBook = new FontAwesome.Sharp.IconButton();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblRemainingDays = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblBorrowedDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserBooks)).BeginInit();
            this.pnlDownBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUserBooks
            // 
            this.dgwUserBooks.AllowUserToAddRows = false;
            this.dgwUserBooks.AllowUserToResizeColumns = false;
            this.dgwUserBooks.AllowUserToResizeRows = false;
            this.dgwUserBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUserBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.dgwUserBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUserBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwUserBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwUserBooks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgwUserBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUserBooks.GridColor = System.Drawing.SystemColors.Control;
            this.dgwUserBooks.Location = new System.Drawing.Point(0, 0);
            this.dgwUserBooks.Name = "dgwUserBooks";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUserBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwUserBooks.Size = new System.Drawing.Size(855, 568);
            this.dgwUserBooks.TabIndex = 1;
            this.dgwUserBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUserBooks_CellClick);
            // 
            // pnlDownBar
            // 
            this.pnlDownBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.pnlDownBar.Controls.Add(this.ibtnReturnBook);
            this.pnlDownBar.Controls.Add(this.lblAuthor);
            this.pnlDownBar.Controls.Add(this.lblCategory);
            this.pnlDownBar.Controls.Add(this.lblRemainingDays);
            this.pnlDownBar.Controls.Add(this.lblDeadline);
            this.pnlDownBar.Controls.Add(this.lblBorrowedDate);
            this.pnlDownBar.Controls.Add(this.lblName);
            this.pnlDownBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDownBar.Location = new System.Drawing.Point(0, 402);
            this.pnlDownBar.Name = "pnlDownBar";
            this.pnlDownBar.Size = new System.Drawing.Size(855, 166);
            this.pnlDownBar.TabIndex = 2;
            this.pnlDownBar.Visible = false;
            // 
            // ibtnReturnBook
            // 
            this.ibtnReturnBook.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ibtnReturnBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnReturnBook.FlatAppearance.BorderSize = 2;
            this.ibtnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnReturnBook.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ibtnReturnBook.ForeColor = System.Drawing.Color.White;
            this.ibtnReturnBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.ibtnReturnBook.IconColor = System.Drawing.Color.White;
            this.ibtnReturnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnReturnBook.Location = new System.Drawing.Point(663, 93);
            this.ibtnReturnBook.Name = "ibtnReturnBook";
            this.ibtnReturnBook.Size = new System.Drawing.Size(180, 59);
            this.ibtnReturnBook.TabIndex = 4;
            this.ibtnReturnBook.Text = "Return";
            this.ibtnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnReturnBook.UseVisualStyleBackColor = true;
            this.ibtnReturnBook.Click += new System.EventHandler(this.ibtnReturnBook_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblAuthor.Location = new System.Drawing.Point(31, 111);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(99, 23);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author: ";
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblCategory.Location = new System.Drawing.Point(31, 72);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(121, 23);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category: ";
            // 
            // lblRemainingDays
            // 
            this.lblRemainingDays.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemainingDays.AutoSize = true;
            this.lblRemainingDays.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblRemainingDays.Location = new System.Drawing.Point(357, 111);
            this.lblRemainingDays.Name = "lblRemainingDays";
            this.lblRemainingDays.Size = new System.Drawing.Size(200, 23);
            this.lblRemainingDays.TabIndex = 3;
            this.lblRemainingDays.Text = "Remaining Days: ";
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblDeadline.Location = new System.Drawing.Point(357, 72);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(121, 23);
            this.lblDeadline.TabIndex = 3;
            this.lblDeadline.Text = "Deadline: ";
            // 
            // lblBorrowedDate
            // 
            this.lblBorrowedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBorrowedDate.AutoSize = true;
            this.lblBorrowedDate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorrowedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblBorrowedDate.Location = new System.Drawing.Point(357, 33);
            this.lblBorrowedDate.Name = "lblBorrowedDate";
            this.lblBorrowedDate.Size = new System.Drawing.Size(186, 23);
            this.lblBorrowedDate.TabIndex = 3;
            this.lblBorrowedDate.Text = "Borrowed Date: ";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(31, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name: ";
            // 
            // UserBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(855, 568);
            this.Controls.Add(this.pnlDownBar);
            this.Controls.Add(this.dgwUserBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserBooks";
            this.Text = "UserBooks";
            this.Load += new System.EventHandler(this.UserBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserBooks)).EndInit();
            this.pnlDownBar.ResumeLayout(false);
            this.pnlDownBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUserBooks;
        private System.Windows.Forms.Panel pnlDownBar;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRemainingDays;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblBorrowedDate;
        private FontAwesome.Sharp.IconButton ibtnReturnBook;
    }
}