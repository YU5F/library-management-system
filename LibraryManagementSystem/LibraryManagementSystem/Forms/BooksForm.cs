using LibraryManagementSystem.Classes;
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
            DataRefresh("Books", dataGridView1);
        }

        public void DataRefresh(string tableName, DataGridView dgw)
        {
            string q = "SELECT * FROM " + tableName;
            DataTable dt = CRUD.Sort(q);
            dgw.DataSource = dt;
        }
    }
}
