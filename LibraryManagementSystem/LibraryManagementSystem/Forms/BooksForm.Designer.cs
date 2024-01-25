namespace LibraryManagementSystem
{
    partial class BooksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.ibtnFilter = new FontAwesome.Sharp.IconButton();
            this.pnlBookButtons = new System.Windows.Forms.Panel();
            this.ibtnAddBook = new FontAwesome.Sharp.IconButton();
            this.ibtnBorrowBook = new FontAwesome.Sharp.IconButton();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new LibraryManagementSystem.Controls.CustomTextBox();
            this.txtCategory = new LibraryManagementSystem.Controls.CustomTextBox();
            this.txtName = new LibraryManagementSystem.Controls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.pnlBookButtons.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.AllowUserToAddRows = false;
            this.dgwBooks.AllowUserToDeleteRows = false;
            this.dgwBooks.AllowUserToResizeColumns = false;
            this.dgwBooks.AllowUserToResizeRows = false;
            this.dgwBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.dgwBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBooks.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgwBooks.GridColor = System.Drawing.SystemColors.Control;
            this.dgwBooks.Location = new System.Drawing.Point(12, 12);
            this.dgwBooks.Name = "dgwBooks";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgwBooks.Size = new System.Drawing.Size(652, 544);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            // 
            // ibtnFilter
            // 
            this.ibtnFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnFilter.FlatAppearance.BorderSize = 2;
            this.ibtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFilter.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ibtnFilter.ForeColor = System.Drawing.Color.White;
            this.ibtnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.ibtnFilter.IconColor = System.Drawing.Color.White;
            this.ibtnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnFilter.Location = new System.Drawing.Point(0, 499);
            this.ibtnFilter.Name = "ibtnFilter";
            this.ibtnFilter.Size = new System.Drawing.Size(180, 59);
            this.ibtnFilter.TabIndex = 1;
            this.ibtnFilter.Text = "Filter";
            this.ibtnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFilter.UseVisualStyleBackColor = true;
            this.ibtnFilter.Click += new System.EventHandler(this.ibtnFilter_Click);
            // 
            // pnlBookButtons
            // 
            this.pnlBookButtons.Controls.Add(this.ibtnAddBook);
            this.pnlBookButtons.Controls.Add(this.ibtnBorrowBook);
            this.pnlBookButtons.Controls.Add(this.ibtnFilter);
            this.pnlBookButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBookButtons.Location = new System.Drawing.Point(670, 0);
            this.pnlBookButtons.Name = "pnlBookButtons";
            this.pnlBookButtons.Padding = new System.Windows.Forms.Padding(0, 10, 5, 10);
            this.pnlBookButtons.Size = new System.Drawing.Size(185, 568);
            this.pnlBookButtons.TabIndex = 2;
            // 
            // ibtnAddBook
            // 
            this.ibtnAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnAddBook.FlatAppearance.BorderSize = 2;
            this.ibtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAddBook.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ibtnAddBook.ForeColor = System.Drawing.Color.White;
            this.ibtnAddBook.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.ibtnAddBook.IconColor = System.Drawing.Color.White;
            this.ibtnAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAddBook.Location = new System.Drawing.Point(0, 69);
            this.ibtnAddBook.Name = "ibtnAddBook";
            this.ibtnAddBook.Size = new System.Drawing.Size(180, 59);
            this.ibtnAddBook.TabIndex = 3;
            this.ibtnAddBook.Text = "Add";
            this.ibtnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAddBook.UseVisualStyleBackColor = true;
            this.ibtnAddBook.Click += new System.EventHandler(this.ibtnAddBook_Click);
            // 
            // ibtnBorrowBook
            // 
            this.ibtnBorrowBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnBorrowBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnBorrowBook.FlatAppearance.BorderSize = 2;
            this.ibtnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBorrowBook.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ibtnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.ibtnBorrowBook.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.ibtnBorrowBook.IconColor = System.Drawing.Color.White;
            this.ibtnBorrowBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBorrowBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnBorrowBook.Location = new System.Drawing.Point(0, 10);
            this.ibtnBorrowBook.Name = "ibtnBorrowBook";
            this.ibtnBorrowBook.Size = new System.Drawing.Size(180, 59);
            this.ibtnBorrowBook.TabIndex = 2;
            this.ibtnBorrowBook.Text = "Borrow";
            this.ibtnBorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnBorrowBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnBorrowBook.UseVisualStyleBackColor = true;
            this.ibtnBorrowBook.Click += new System.EventHandler(this.ibtnViewBook_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.pnlFilter.Controls.Add(this.txtAuthor);
            this.pnlFilter.Controls.Add(this.txtCategory);
            this.pnlFilter.Controls.Add(this.txtName);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.lblName);
            this.pnlFilter.Location = new System.Drawing.Point(670, 201);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(180, 292);
            this.pnlFilter.TabIndex = 4;
            this.pnlFilter.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(13, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(13, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtAuthor.BorderColor = System.Drawing.Color.White;
            this.txtAuthor.BorderSize = 2;
            this.txtAuthor.Font = new System.Drawing.Font("Verdana", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtAuthor.ForeColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(17, 197);
            this.txtAuthor.Multiline = false;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Padding = new System.Windows.Forms.Padding(7);
            this.txtAuthor.PasswordChar = false;
            this.txtAuthor.Size = new System.Drawing.Size(156, 35);
            this.txtAuthor.TabIndex = 7;
            this.txtAuthor.Texts = "";
            this.txtAuthor.UnderlinedStyle = true;
            this.txtAuthor._TextChanged += new System.EventHandler(this.txtAuthor__TextChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtCategory.BorderColor = System.Drawing.Color.White;
            this.txtCategory.BorderSize = 2;
            this.txtCategory.Font = new System.Drawing.Font("Verdana", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtCategory.ForeColor = System.Drawing.Color.White;
            this.txtCategory.Location = new System.Drawing.Point(17, 118);
            this.txtCategory.Multiline = false;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Padding = new System.Windows.Forms.Padding(7);
            this.txtCategory.PasswordChar = false;
            this.txtCategory.Size = new System.Drawing.Size(156, 35);
            this.txtCategory.TabIndex = 7;
            this.txtCategory.Texts = "";
            this.txtCategory.UnderlinedStyle = true;
            this.txtCategory._TextChanged += new System.EventHandler(this.txtCategory__TextChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Verdana", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(17, 42);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(156, 35);
            this.txtName.TabIndex = 7;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            this.txtName._TextChanged += new System.EventHandler(this.txtName__TextChanged);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(855, 568);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlBookButtons);
            this.Controls.Add(this.dgwBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.pnlBookButtons.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private FontAwesome.Sharp.IconButton ibtnFilter;
        private System.Windows.Forms.Panel pnlBookButtons;
        private FontAwesome.Sharp.IconButton ibtnBorrowBook;
        private FontAwesome.Sharp.IconButton ibtnAddBook;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblName;
        private Controls.CustomTextBox txtName;
        private Controls.CustomTextBox txtAuthor;
        private Controls.CustomTextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}