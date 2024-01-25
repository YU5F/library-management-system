using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BooksForm : Form
    {
        public formMain ParentForm;
        public BooksForm(formMain ParentForm)
        {
            InitializeComponent();
            this.ParentForm = ParentForm;
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private int lastSelectedRow = -1;
        private int selectedIndex = -1;
        private string selectedCategory;
        private string selectedName;
        private int stock;
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (lastSelectedRow != -1)
                {
                    dgwBooks.Rows[lastSelectedRow].DefaultCellStyle.BackColor = Color.FromArgb(68, 60, 104);
                }

                dgwBooks.Rows[e.RowIndex].Selected = true;
                dgwBooks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 89, 133);

                selectedIndex = Convert.ToInt32(dgwBooks.Rows[e.RowIndex].Cells["ISBN"].Value);
                selectedCategory = dgwBooks.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                selectedName = dgwBooks.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                stock = Convert.ToInt32(dgwBooks.Rows[e.RowIndex].Cells["Stock"].Value);

                lastSelectedRow = e.RowIndex;
            }
        }

        private void ibtnViewBook_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a book!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AuthenticatedUser.LoggedInUser.Id == -1)
            {
                DialogResult result = MessageBox.Show("You have to be logged in before borrowing a book! \nSign In?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ParentForm.ChangeChildForm(new SignForm(ParentForm));
                    ParentForm.DisableButton();
                }
                return;
            }
            int bookISBN, borrowedByID;
            string bookCategory, borrowedByName, bookName;
            DateTime borrowedDate, deadline;

            bookISBN = selectedIndex;
            borrowedByID = AuthenticatedUser.LoggedInUser.Id;
            borrowedByName = AuthenticatedUser.LoggedInUser.Name;
            borrowedDate = DateTime.Now;
            deadline = borrowedDate.AddDays(7);
            bookCategory = selectedCategory;
            bookName = selectedName;

            if (DoesBookExist(bookISBN, borrowedByID))
            {
                MessageBox.Show("You've already borrowed this book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (stock > 0)
                {
                    DialogResult result = MessageBox.Show("Borrow book " + bookName + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Methods.Instance.DecreaseStock(bookISBN);
                        string q = "Insert into BorrowInformation values('" + bookISBN + "','" + bookName + "','" + bookCategory + "','" + borrowedByID + "','" + borrowedByName + "','" + borrowedDate.ToString() + "','" + deadline.ToString() + "')";
                        if (CRUD.ExecQuery(q))
                        {
                            MessageBox.Show("You have borrowed the book!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        RefreshData();
                    }
                }
                else
                {
                    MessageBox.Show("This book is out of stocks.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool DoesBookExist(int ISBN, int visitorId)
        {
            string q = "Select * from BorrowInformation where BookISBN = '" + ISBN + "' AND BorrowedByID = '" + visitorId + "'";
            DataTable dt = CRUD.Sort(q);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RefreshData()
        {
            Methods.Instance.DataRefresh("Books", dgwBooks);
        }

        private void ibtnFilter_Click(object sender, EventArgs e)
        {

        }

        private void ibtnAddBook_Click(object sender, EventArgs e)
        {
            if (AuthenticatedUser.LoggedInUser.Id == -1)
            {
                DialogResult result = MessageBox.Show("You have to be logged in before adding a book! \nSign In?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ParentForm.ChangeChildForm(new SignForm(ParentForm));
                    ParentForm.DisableButton();
                }
                return;
            }
            AddBookForm addForm = new AddBookForm(this);
            addForm.ShowDialog();
        }
    }
}
