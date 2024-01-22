using LibraryManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class SignForm : Form
    {
        //Fields
        private Form currentChildForm;
        public SignForm()
        {
            InitializeComponent();
        }

        private void SignForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new LoginForm());
        }
        public void OpenChildForm(Form form)
        {
            //Close current form if opening a new one
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlSignForm.Controls.Add(form);
            pnlSignForm.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
