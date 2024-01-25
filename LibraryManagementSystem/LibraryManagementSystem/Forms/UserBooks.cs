using LibraryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class UserBooks : Form
    {
        public UserBooks()
        {
            InitializeComponent();
        }

        private int lastSelectedRow = -1;
        private int selectedIndex = -1;
        private string selectedCategory;
        private string selectedName;
        private DateTime borrowedDate, deadline;
        private int remainingDays;

        private void UserBooks_Load(object sender, EventArgs e)
        {
            string q = "Select BookISBN, BookName, BookCategory, BorrowedDate, Deadline from BorrowInformation where BorrowedByID = " + AuthenticatedUser.LoggedInUser.Id;
            DataTable dt = CRUD.Sort(q);
            dgwUserBooks.DataSource = dt;
        }
        private void dgwUserBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (lastSelectedRow != -1)
                {
                    dgwUserBooks.Rows[lastSelectedRow].DefaultCellStyle.BackColor = Color.FromArgb(68, 60, 104);
                }

                dgwUserBooks.Rows[e.RowIndex].Selected = true;
                dgwUserBooks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 89, 133);

                selectedIndex = Convert.ToInt32(dgwUserBooks.Rows[e.RowIndex].Cells["BookISBN"].Value);
                selectedCategory = dgwUserBooks.Rows[e.RowIndex].Cells["BookCategory"].Value.ToString();
                selectedName = dgwUserBooks.Rows[e.RowIndex].Cells["BookName"].Value.ToString();
                borrowedDate = Convert.ToDateTime(dgwUserBooks.Rows[e.RowIndex].Cells["BorrowedDate"].Value);
                deadline = Convert.ToDateTime(dgwUserBooks.Rows[e.RowIndex].Cells["Deadline"].Value);
                remainingDays = (int)(deadline - DateTime.Now).TotalDays;

                lastSelectedRow = e.RowIndex;
            }

            if (pnlDownBar.Visible == false)
            {
                pnlDownBar.Visible = true;
            }
            string q = "Select * from Books where ISBN = " + selectedIndex;
            DataTable dt = CRUD.Sort(q);

            if (dt.Rows.Count > 0)
            {
                ClearLabels();
                lblName.Text += dt.Rows[0]["Name"];
                lblAuthor.Text += dt.Rows[0]["Author"];
                lblBorrowedDate.Text += borrowedDate.Date.ToString("yyyy-MM-dd");
                lblCategory.Text += selectedCategory;
                lblDeadline.Text += deadline.Date.ToString("yyyy-MM-dd");
                lblRemainingDays.Text += remainingDays.ToString();
            }
        }
        private void ClearLabels()
        {
            lblName.Text = "Name: ";
            lblAuthor.Text = "Author: ";
            lblBorrowedDate.Text = "Borrowed Date: ";
            lblCategory.Text = "Category: ";
            lblDeadline.Text = "Deadline: ";
            lblRemainingDays.Text = "Remaining Days: ";
        }
    }
}
