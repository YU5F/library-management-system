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
    public partial class BookInfoForm : Form
    {
        private int bookIndex;
        public BookInfoForm(int bookIndex)
        {
            InitializeComponent();
            this.bookIndex = bookIndex;
            label1.Text= bookIndex.ToString();
        }
    }
}
