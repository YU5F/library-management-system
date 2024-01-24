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
            Methods.Instance.DataRefresh("Books", dgwBooks);
        }

        private int lastSelectedRow = -1;
        private int selectedIndex = -1;
        private string selectedCategory;
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
            int bookISBN, borrowedByID, remainingDays;
            string bookCategory, borrowedByName;
            DateTime borrowedDate, deadline;

            bookISBN = selectedIndex;
            borrowedByID = AuthenticatedUser.LoggedInUser.Id;
            borrowedByName = AuthenticatedUser.LoggedInUser.Name;
            borrowedDate = DateTime.Now;
            deadline = borrowedDate.AddDays(7);
            remainingDays = (int)(deadline - borrowedDate).TotalDays;
            bookCategory = selectedCategory;

            if (DoesBookExist(bookISBN))
            {
                MessageBox.Show("You've already borrowed this book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string q = "Insert into BorrowInformation values('" + bookISBN + "','" + bookCategory + "','" + borrowedByID + "','" + borrowedByName + "','" + borrowedDate.ToString() + "','" + deadline.ToString() + "','" + remainingDays + "')";
                if (CRUD.ExecQuery(q))
                {
                    MessageBox.Show("You have borrowed the book!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private bool DoesBookExist(int ISBN)
        {
            string q = "Select * from BorrowInformation where BookISBN = '" + ISBN + "'";
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

        private void ibtnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
