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
    public partial class LoginForm : Form
    {
        private formMain parentForm;
        public LoginForm(formMain parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email, password;

            email = txtEmail.Texts;
            password = txtPassword.Texts;

            if (!Methods.Instance.TextControlChecker(this.Controls))
            {
                string q = "SELECT * from Visitors where Email= '" + email + "' AND Password= '" + password + "'";
                DataTable dt = CRUD.Sort(q);

                if(dt.Rows.Count > 0)
                {
                    User loggedInUser = new User {
                        Id = Convert.ToInt32(dt.Rows[0]["VisitorID"]),
                        Email = dt.Rows[0]["Email"].ToString(),
                        Name = dt.Rows[0]["Name"].ToString(),
                        Surname = dt.Rows[0]["Surname"].ToString(),
                        PhotoPath = dt.Rows[0]["PhotoPath"].ToString()
                    };
                    AuthenticatedUser.LoggedInUser = loggedInUser;
                    MessageBox.Show("Login successfull");
                    txtEmail.Texts = "";
                    txtPassword.Texts = "";
                    parentForm.LoggedInInterface();
                }
                else
                {
                    MessageBox.Show("Email or password wrong");
                }
            }
        }
    }
}
