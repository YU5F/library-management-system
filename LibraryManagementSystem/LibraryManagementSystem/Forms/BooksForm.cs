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
            Methods.Instance.DataRefresh("Books", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AuthenticatedUser.LoggedInUser.Id.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthenticatedUser.SignOut();
        }
    }
}
