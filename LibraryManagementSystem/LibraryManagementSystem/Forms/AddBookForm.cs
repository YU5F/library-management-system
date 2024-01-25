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
    public partial class AddBookForm : Form
    {
        private BooksForm parentForm;
        public AddBookForm(BooksForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnAddBook_Click(object sender, EventArgs e)
        {
            string bookName, bookCategory, bookAuthor, addedBy;
            int stock;
            if (!Methods.Instance.TextControlChecker(pnlContainer.Controls))
            {
                bookName = txtName.Texts;
                bookCategory = txtCategory.Texts;
                bookAuthor = txtAuthor.Texts;
                stock = Convert.ToInt32(txtStock.Texts);

                if (stock > 99)
                {
                    DialogResult result = MessageBox.Show("Maximum stock you can enter is 99\nDo you wish to enter the max amount?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        stock = 99;
                        txtStock.Texts = stock.ToString();
                        return;
                    }
                }

                DialogResult result1 = MessageBox.Show("Book is about to be added. Proceed?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result1 == DialogResult.Yes)
                {
                    addedBy = AuthenticatedUser.LoggedInUser.Name + " " + AuthenticatedUser.LoggedInUser.Surname;
                    string q = "Insert into Books(Name, Author, Category, AddedBy, Stock) values('" + bookName + "','" + bookAuthor + "','" + bookCategory + "','" + addedBy + "','" + stock + "')";
                    if (CRUD.ExecQuery(q))
                    {
                        MessageBox.Show("Book has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        parentForm.RefreshData();
                        this.Close();
                    }
                }
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
