namespace SchoolProject.Users
{
    partial class frmUserInfo
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
            lblTitle = new Label();
            ctrlUserCard1 = new ctrlUserCard();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(188, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(301, 45);
            lblTitle.TabIndex = 91;
            lblTitle.Text = "User Details";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.BackColor = Color.White;
            ctrlUserCard1.Location = new Point(1, 46);
            ctrlUserCard1.Margin = new Padding(5, 3, 5, 3);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(657, 405);
            ctrlUserCard1.TabIndex = 0;
            // 
            // frmUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(655, 454);
            Controls.Add(lblTitle);
            Controls.Add(ctrlUserCard1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmUserInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmUserInfo";
            Load += frmUserInfo_Load;
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private ctrlUserCard ctrlUserCard1;
    }
}