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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.ibtnFilter = new FontAwesome.Sharp.IconButton();
            this.pnlBookButtons = new System.Windows.Forms.Panel();
            this.ibtnBorrowBook = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.pnlBookButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.AllowUserToResizeColumns = false;
            this.dgwBooks.AllowUserToResizeRows = false;
            this.dgwBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.dgwBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBooks.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgwBooks.GridColor = System.Drawing.SystemColors.Control;
            this.dgwBooks.Location = new System.Drawing.Point(12, 12);
            this.dgwBooks.Name = "dgwBooks";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
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
    }
}