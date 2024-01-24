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
        public BooksForm()
        {
            InitializeComponent();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            Methods.Instance.DataRefresh("Books", dgwBooks);
        }

        private int lastSelectedRow = -1;
        private int selectedIndex = -1;
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if(lastSelectedRow != -1)
                {
                    dgwBooks.Rows[lastSelectedRow].DefaultCellStyle.BackColor = Color.FromArgb(68, 60, 104);
                }

                dgwBooks.Rows[e.RowIndex].Selected = true;
                dgwBooks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 89, 133);

                selectedIndex = Convert.ToInt32(dgwBooks.Rows[e.RowIndex].Cells["ISBN"].Value);

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
            else
            {
                BookInfoForm info = new BookInfoForm(selectedIndex);
                info.ShowDialog();
            }
        }
    }
}
