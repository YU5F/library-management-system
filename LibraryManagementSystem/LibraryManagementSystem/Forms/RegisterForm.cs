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
    public partial class RegisterForm : Form
    {
        private SignForm signForm;
        public RegisterForm(SignForm parentForm)
        {
            InitializeComponent();
            signForm = parentForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            signForm.EnableLink();
            this.Close();
        }
    }
}
