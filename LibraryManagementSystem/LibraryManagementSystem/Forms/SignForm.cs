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
        private formMain MainFormInstance;
        public SignForm(formMain MainFormInstance)
        {
            InitializeComponent();
            this.MainFormInstance = MainFormInstance;
        }

        private void SignForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(MainFormInstance);
            Methods.Instance.OpenChildForm(loginForm, pnlSignForm);
        }
        public void EnableLink()
        {
            linkSignUp.Enabled = true;
            label1.Visible = true;
            linkSignUp.Visible = true;
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Methods.Instance.OpenChildForm(new RegisterForm(this), pnlSignForm);
            linkSignUp.Enabled = false;
            label1.Visible = false;
            linkSignUp.Visible = false;
        }
    }
}
