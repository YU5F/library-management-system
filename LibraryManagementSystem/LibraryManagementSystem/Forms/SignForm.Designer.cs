namespace LibraryManagementSystem
{
    partial class SignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSignForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pnlSignForm
            // 
            this.pnlSignForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSignForm.BackColor = System.Drawing.Color.Indigo;
            this.pnlSignForm.Location = new System.Drawing.Point(131, 97);
            this.pnlSignForm.Name = "pnlSignForm";
            this.pnlSignForm.Size = new System.Drawing.Size(593, 317);
            this.pnlSignForm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Don\'t have an account?";
            // 
            // linkSignUp
            // 
            this.linkSignUp.ActiveLinkColor = System.Drawing.Color.White;
            this.linkSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.linkSignUp.Location = new System.Drawing.Point(402, 421);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(93, 23);
            this.linkSignUp.TabIndex = 2;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Sign Up";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(855, 586);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSignForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.Load += new System.EventHandler(this.SignForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSignForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkSignUp;
    }
}