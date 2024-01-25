using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public class Methods
    {
        private static Methods instance;

        private Methods() { }

        public static Methods Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Methods();
                }
                return instance;
            }
        }
        public void DataRefresh(string tableName, DataGridView dgw)
        {
            string q = "SELECT * FROM " + tableName;
            DataTable dt = CRUD.Sort(q);
            dgw.DataSource = dt;
        }

        public bool TextControlChecker(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is CustomTextBox)
                {
                    CustomTextBox txtbox = c as CustomTextBox;
                    if (txtbox.Texts == string.Empty)
                    {
                        string txtboxName = txtbox.Name;
                        MessageBox.Show(txtboxName.Substring(3) + " is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }
            }
            return false;
        }
        public void OpenChildForm(Form form, Panel pnl)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnl.Controls.Add(form);
            pnl.Tag = form;
            form.BringToFront();
            form.Show();
        }
        public void IncreaseStock(int bookId)
        {
            string q = "Update Books set Stock = Stock + 1, BorrowedAmount = BorrowedAmount - 1 where ISBN = " + bookId;
            CRUD.ExecQuery(q);
        }
        public void DecreaseStock(int bookId)
        {
            string q = "Update Books set Stock = Stock - 1, BorrowedAmount = BorrowedAmount + 1 where ISBN = " + bookId;
            CRUD.ExecQuery(q);
        }
    }
}
