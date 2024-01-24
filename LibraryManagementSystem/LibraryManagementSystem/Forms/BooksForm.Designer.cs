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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.ibtnFilter = new FontAwesome.Sharp.IconButton();
            this.pnlBookButtons = new System.Windows.Forms.Panel();
            this.ibtnViewBook = new FontAwesome.Sharp.IconButton();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwBooks.GridColor = System.Drawing.SystemColors.Control;
            this.dgwBooks.Location = new System.Drawing.Point(12, 12);
            this.dgwBooks.Name = "dgwBooks";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.ibtnFilter.Location = new System.Drawing.Point(0, 485);
            this.ibtnFilter.Name = "ibtnFilter";
            this.ibtnFilter.Size = new System.Drawing.Size(173, 59);
            this.ibtnFilter.TabIndex = 1;
            this.ibtnFilter.Text = "Filter";
            this.ibtnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFilter.UseVisualStyleBackColor = true;
            // 
            // pnlBookButtons
            // 
            this.pnlBookButtons.Controls.Add(this.ibtnViewBook);
            this.pnlBookButtons.Controls.Add(this.ibtnFilter);
            this.pnlBookButtons.Location = new System.Drawing.Point(670, 12);
            this.pnlBookButtons.Name = "pnlBookButtons";
            this.pnlBookButtons.Size = new System.Drawing.Size(173, 544);
            this.pnlBookButtons.TabIndex = 2;
            // 
            // ibtnViewBook
            // 
            this.ibtnViewBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnViewBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnViewBook.FlatAppearance.BorderSize = 2;
            this.ibtnViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnViewBook.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ibtnViewBook.ForeColor = System.Drawing.Color.White;
            this.ibtnViewBook.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.ibtnViewBook.IconColor = System.Drawing.Color.White;
            this.ibtnViewBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnViewBook.Location = new System.Drawing.Point(0, 0);
            this.ibtnViewBook.Name = "ibtnViewBook";
            this.ibtnViewBook.Size = new System.Drawing.Size(173, 59);
            this.ibtnViewBook.TabIndex = 2;
            this.ibtnViewBook.Text = "View";
            this.ibtnViewBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnViewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnViewBook.UseVisualStyleBackColor = true;
            this.ibtnViewBook.Click += new System.EventHandler(this.ibtnViewBook_Click);
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
        private FontAwesome.Sharp.IconButton ibtnViewBook;
    }
}