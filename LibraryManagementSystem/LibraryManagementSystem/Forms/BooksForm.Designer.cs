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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.ibtnFilter = new FontAwesome.Sharp.IconButton();
            this.pnlBookButtons = new System.Windows.Forms.Panel();
            this.ibtnBorrowBook = new FontAwesome.Sharp.IconButton();
            this.ibtnAddBook = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.pnlBookButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.AllowUserToAddRows = false;
            this.dgwBooks.AllowUserToResizeColumns = false;
            this.dgwBooks.AllowUserToResizeRows = false;
            this.dgwBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.dgwBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBooks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgwBooks.GridColor = System.Drawing.SystemColors.Control;
            this.dgwBooks.Location = new System.Drawing.Point(12, 12);
            this.dgwBooks.Name = "dgwBooks";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(855, 568);
            this.Controls.Add(this.pnlBookButtons);
            this.Controls.Add(this.dgwBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.pnlBookButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private FontAwesome.Sharp.IconButton ibtnFilter;
        private System.Windows.Forms.Panel pnlBookButtons;
        private FontAwesome.Sharp.IconButton ibtnBorrowBook;
        private FontAwesome.Sharp.IconButton ibtnAddBook;
    }
}