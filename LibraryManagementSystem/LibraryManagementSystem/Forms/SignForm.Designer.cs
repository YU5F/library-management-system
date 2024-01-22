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
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(855, 586);
            this.Controls.Add(this.pnlSignForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.Load += new System.EventHandler(this.SignForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSignForm;
    }
}