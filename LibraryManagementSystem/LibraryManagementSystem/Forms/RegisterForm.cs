using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Check if textboxes are empty
            if (Methods.Instance.TextControlChecker(this.Controls))
            {
                return;
            }
            Register();
        }
        private void Register()
        {
            //Insert data
            string name, surname, email, username, signdate, password;
            name = txtName.Texts;
            surname = txtSurname.Texts;
            email = txtEmail.Texts;
            if (name.Length <= 3 && surname.Length <= 3)
            {
                username = name + surname;
            }
            else
            {
                username = name.Substring(0, 3) + surname.Substring(0, 3);
            }
            signdate = DateTime.Now.ToString();
            password = txtPassword.Texts;

            string q = "Insert into Visitors(Email,Name,Surname,UserName,SignDate,Password) Values('" + email + "','" + name + "','"
               + surname + "','" + username + "','" + signdate + "','" + password + "')";
            if(CRUD.ExecQuery(q))
            {
                MessageBox.Show("Successfull");
                signForm.EnableLink();
                this.Close();
            }
        }
    }
}
