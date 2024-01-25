using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Forms;

namespace LibraryManagementSystem
{
    public partial class formMain : Form
    {
        //Fields
        private IconButton currentButton;
        private Panel buttonLeftBorder;
        private Form currentChildForm;

        public formMain()
        {
            InitializeComponent();
            //Left border of current button style
            buttonLeftBorder = new Panel();
            buttonLeftBorder.Size = new Size(7, 55);
            pnlButtons.Controls.Add(buttonLeftBorder);


            //Remove border of the form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region Highlight Active Button
        //Methods for highlighting active button
        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();

                currentButton = (IconButton)sender;
                currentButton.BackColor = Color.FromArgb(24, 18, 43);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                buttonLeftBorder.BackColor = color;
                buttonLeftBorder.Location = new Point(0, currentButton.Location.Y);
                buttonLeftBorder.Visible = true;
                buttonLeftBorder.BringToFront();
            }
        }

        public void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(68, 60, 104);
                currentButton.ForeColor = Color.FromArgb(250, 247, 240);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.FromArgb(250, 247, 240);
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion

        #region Drag Form By Panel
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTopGrip_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Open Form Inside Panel
        //Opening another form inside container panel for avoiding navigation problems
        public void OpenChildForm(Form form)
        {
            //Close current form if opening a new one
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = form;
            Methods.Instance.OpenChildForm(form, pnlContainer);
        }
        #endregion

        #region Interface Changes
        public void LoggedInInterface()
        {
            ibtnSignOut.Visible = true;
            ibtnSignIn.Visible = false;
            ibtnSignIn.Enabled = false;
            ibtnSignOut.Enabled = true;
            ibtnMyBooks.Visible = true;
            ibtnMyBooks.Enabled = true;
            pictureUserProfile.ImageLocation = AuthenticatedUser.LoggedInUser.PhotoPath;
            lblUsername.Text = AuthenticatedUser.LoggedInUser.Name + " " + AuthenticatedUser.LoggedInUser.Surname;
            int parentCenterX = (pnlSideNavBar.Size.Width - lblUsername.Width) / 2;
            lblUsername.Location = new Point(parentCenterX, lblUsername.Location.Y);
            currentChildForm.Close();
            DisableButton();
        }
        public void DefaultInterface()
        {
            ibtnSignOut.Visible = false;
            ibtnSignIn.Visible = true;
            ibtnSignIn.Enabled = true;
            ibtnSignOut.Enabled = false;
            ibtnMyBooks.Visible = false;
            ibtnMyBooks.Enabled = false;
            pictureUserProfile.ImageLocation = AuthenticatedUser.LoggedInUser.PhotoPath;
            lblUsername.Text = AuthenticatedUser.LoggedInUser.Name;
            int parentCenterX = (pnlSideNavBar.Size.Width - lblUsername.Width) / 2;
            lblUsername.Location = new Point(parentCenterX, lblUsername.Location.Y);
            currentChildForm.Close();
            DisableButton();
        }
        public void ChangeChildForm(Form form)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = form;
            Methods.Instance.OpenChildForm(form, pnlContainer);
        }
        #endregion

        #region Button Click Methods
        private void ibtnBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(205, 252, 246));
            OpenChildForm(new BooksForm(this));
        }

        private void ibtnSignIn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(205, 252, 246));
            OpenChildForm(new SignForm(this));
        }

        private void ibtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ibtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ibtnSignOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're about to sign out. Proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                currentChildForm.Close();
                AuthenticatedUser.SignOut();
                DefaultInterface();
            }
        }
        private void ibtnMyBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(205, 252, 246));
            Methods.Instance.OpenChildForm(new UserBooks(this), pnlContainer);
        }
        #endregion
    }
}
