using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LibraryManagementSystem.Forms
{
    public partial class RegisterForm : Form
    {
        private SignForm signForm;
        private string selectedFileName;
        private static string selectedPhotoPath = @"~\image\default.jpg";
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

            SavePicture(selectedFileName);
            string q = "Insert into Visitors(Email,Name,Surname,UserName,SignDate,Password,PhotoPath) Values('" + email + "','" + name + "','"
               + surname + "','" + username + "','" + signdate + "','" + password + "','" + selectedPhotoPath + "')";
            if (CRUD.ExecQuery(q))
            {
                MessageBox.Show("Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                signForm.EnableLink();
                this.Close();
            }
        }

        private void btnPhotoSelect_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All Files (*.*)|*.*";
                dialog.Title = "Select an image file";
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picturePhoto.ImageLocation = dialog.FileName.ToString();
                    selectedFileName = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SavePicture(string photoName)
        {
            string path = Path.Combine(@"~\image\");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName = System.IO.Path.GetFileName(photoName);
            path += fileName;
            selectedPhotoPath = path;
            File.Copy(photoName, path);
        }
    }
}
