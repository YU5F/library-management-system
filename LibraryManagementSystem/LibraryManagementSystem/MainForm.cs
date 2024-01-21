﻿using System;
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

namespace LibraryManagementSystem
{
    public partial class formMain : Form
    {
        //Fields for active button info
        private IconButton currentButton;
        private Panel buttonLeftBorder;

        public formMain()
        {
            InitializeComponent();
            //Left border of current button style
            buttonLeftBorder = new Panel();
            buttonLeftBorder.Size = new Size(7, 55);
            pnlButtons.Controls.Add(buttonLeftBorder);


            //Remove border of the form
            this.Text= string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region HighlightActiveButton
        //Methods for highlighting active button
        private void ActivateButton(object sender, Color color)
        {
            if(sender != null)
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

        private void DisableButton()
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

        #region DragFormByPanel
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTopGrip_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void ibtnBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(205, 252, 246));
        }

        private void ibtnSignIn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(205, 252, 246));
            
        }

        private void ibtnSignOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(205, 252, 246));
        }
    }
}
